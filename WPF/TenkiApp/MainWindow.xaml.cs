using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TenkiApp {

    public partial class MainWindow : Window {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string API_BASE_URL = "https://api.open-meteo.com/v1/forecast";

        private const string GEOLOCATION_API_URL = "https://geoapi.heartrails.com/api/json?method=searchByGeoLocation";

        public MainWindow() {
            InitializeComponent();

            // 修正: 起動時にデフォルトの座標（東京）を設定して天気を取得
            LatitudeInput.Text = "35.6895";
            LongitudeInput.Text = "139.6917";
            FetchWeather(LatitudeInput.Text, LongitudeInput.Text);
        }


        private string GetWeatherDescription(double code) {
            switch (code) {
                case 0: return "☀️ 快晴";
                case 1: case 2: case 3: return "☁️ 曇り";
                case 45: case 48: return "🌫️ 霧";
                case 51: case 53: case 55: return "🌧️ 霧雨";
                case 61: case 63: case 65: return "🌧️ 雨";
                case 71: case 73: case 75: return "❄️ 雪";
                case 80: case 81: case 82: return "☔ にわか雨";
                case 85: case 86: return "🌨️ 雪のシャワー";
                case 95: case 96: case 99: return "⚡ 雷雨";
                default: return "---";
            }
        }


        private async Task<string> GetPrefectureName(double lat, double lon) {
            try {

                string geoUrl = $"{GEOLOCATION_API_URL}&y={lat}&x={lon}";

                var geoResponse = await _httpClient.GetFromJsonAsync<GeoApiResult>(geoUrl);

                var location = geoResponse?.response?.location?.FirstOrDefault();

                if (location != null && !string.IsNullOrEmpty(location.prefecture)) {

                    return $"{location.prefecture} {location.city}";
                }
                return "場所: 不明な地域";
            }
            catch (Exception) {
                return "場所: 取得エラー (API通信失敗)";
            }
        }


        private async Task FetchWeather(string latitude, string longitude, string? customLocationName = null) {

            if (!double.TryParse(latitude, out double lat) || !double.TryParse(longitude, out double lon)) {
                // 座標が空欄の場合、エラーメッセージは出さずに終了する
                if (string.IsNullOrEmpty(latitude) && string.IsNullOrEmpty(longitude)) return;

                MessageBox.Show("緯度または経度の値が不正です。", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            LocationTextBlock.Text = "場所: 取得中...";
            TemperatureTextBlock.Text = "気温: 取得中...";
            WindSpeedTextBlock.Text = "風速: 取得中...";
            HumidityTextBlock.Text = "湿度: 取得中...";
            TimeTextBlock.Text = "取得時刻: 接続中...";
            ForecastListView.ItemsSource = null;

            string finalLocationName = "現在地: --";


            if (customLocationName == null) {

                finalLocationName = await GetPrefectureName(lat, lon);
            } else {

                finalLocationName = customLocationName;
            }
            LocationTextBlock.Text = $"場所: {finalLocationName}";


            try {

                const string API_OPTIONS = "current=temperature_2m,wind_speed_10m,relative_humidity_2m,weather_code&daily=weather_code,temperature_2m_max,temperature_2m_min&temperature_unit=celsius&windspeed_unit=ms&timezone=Asia%2FTokyo";


                string apiUrl = $"{API_BASE_URL}?latitude={lat}&longitude={lon}&{API_OPTIONS}";

                var response = await _httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var apiResponse = await response.Content.ReadFromJsonAsync<CurrentWeatherResponse>();


                if (apiResponse?.current != null) {
                    var cw = apiResponse.current;


                    DateTime utcTime = DateTime.Parse(cw.time, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
                    DateTime localTime = utcTime.AddSeconds(apiResponse.utc_offset_seconds);


                    TimeTextBlock.Text = $"取得時刻: {localTime:yyyy/MM/dd HH:mm}";
                    // 修正: 天気コードの説明を()から削除し、視認性を上げる
                    TemperatureTextBlock.Text = $"気温: {cw.temperature:F1} °C";
                    WindSpeedTextBlock.Text = $"風速: {cw.windspeed:F1} m/s";

                    // 天気コードの説明をLocationTextBlockの隣に追記
                    LocationTextBlock.Text = $"{finalLocationName} ({GetWeatherDescription(cw.weathercode)})";

                    HumidityTextBlock.Text = $"湿度: {cw.relative_humidity:F0} %";
                } else {
                    throw new Exception("現在の天気データが見つかりませんでした。");
                }


                if (apiResponse.daily?.time != null) {
                    var daily = apiResponse.daily;
                    var forecastItems = new List<ForecastItem>();


                    for (int i = 0; i < daily.time.Length; i++) {

                        if (i < daily.weather_code.Length && i < daily.temperature_2m_max.Length && i < daily.temperature_2m_min.Length) {

                            forecastItems.Add(new ForecastItem {
                                Date = DateTime.Parse(daily.time[i]).ToString("MM/dd (ddd)"),
                                WeatherCode = GetWeatherDescription(daily.weather_code[i]),
                                MaxTemperature = $"{daily.temperature_2m_max[i]:F1} °C",
                                MinTemperature = $"{daily.temperature_2m_min[i]:F1} °C"
                            });
                        }
                    }

                    ForecastListView.ItemsSource = forecastItems;
                }

            }
            catch (HttpRequestException) {
                MessageBox.Show("天気情報の取得中に通信エラーが発生しました。", "通信エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                LocationTextBlock.Text = $"場所: {finalLocationName} (通信エラー)";
            }
            catch (Exception ex) {
                MessageBox.Show($"予期せぬエラーが発生しました: {ex.Message}", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);
                LocationTextBlock.Text = $"場所: {finalLocationName} (エラー)";
            }
        }



        // 修正: UpdateButton_Clickは現在の座標でFetchWeatherを再呼び出しする
        private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
            await FetchWeather(LatitudeInput.Text, LongitudeInput.Text);
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e) {
            string searchPrefecture = PrefectureInput.Text.Trim();
            if (string.IsNullOrEmpty(searchPrefecture)) {
                MessageBox.Show("県名を入力してください。", "検索エラー");
                return;
            }


            string coordinateListText = (string)((TextBox)this.FindName("TextBox")).Text;

            var lines = coordinateListText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            string? foundLatitude = null;
            string? foundLongitude = null;
            string? foundPrefecture = null;

            foreach (var line in lines) {
                var parts = line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 3) {
                    string prefectureName = parts[0].Trim();


                    if (prefectureName.Contains(searchPrefecture) || searchPrefecture.Contains(prefectureName)) {
                        foundPrefecture = prefectureName;
                        foundLatitude = parts[1].Trim();
                        foundLongitude = parts[2].Trim();
                        break;
                    }
                }
            }

            if (foundLatitude != null && foundLongitude != null) {

                LatitudeInput.Text = foundLatitude;
                LongitudeInput.Text = foundLongitude;


                FetchWeather(foundLatitude, foundLongitude, foundPrefecture);
            } else {
                MessageBox.Show($"「{searchPrefecture}」に対応する座標が見つかりませんでした。", "検索失敗");
                LocationTextBlock.Text = "場所: ---";
                ForecastListView.ItemsSource = null;
            }
        }


        private void Ido_TextChanged(object sender, TextChangedEventArgs e) { }
        private void Keido_TextChanged(object sender, TextChangedEventArgs e) { }
        private void ForecastListView_SelectionChanged(object sender, SelectionChangedEventArgs e) { }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) { }

        private void PrefectureInput_TextChanged(object sender, TextChangedEventArgs e) {

        }
    }
}