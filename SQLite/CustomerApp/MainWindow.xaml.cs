using CustomerApp.Data;
using Microsoft.Win32;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CustomerApp {
    public partial class MainWindow : Window {
        private List<Customer> _customers = new List<Customer>();
        public MainWindow() {
            InitializeComponent();
            ReadDatabase();
            CustomerListView.ItemsSource = _customers;
        }

        private string _lastFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        private void PhotoButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                InitialDirectory = _lastFolder,
                Filter = "画像ファイル|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == true) {
                string filepath = openFileDialog.FileName;
                byte[] imageBytes = System.IO.File.ReadAllBytes(filepath);

                var bitmapImage = new BitmapImage();
                using (var stream = new System.IO.MemoryStream(imageBytes)) {
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.StreamSource = stream;
                    bitmapImage.EndInit();
                }

                ImageBox.Source = bitmapImage;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            byte[] imageBytes = null;
            if (ImageBox.Source is BitmapImage bitmapImage) {
                using (var ms = new System.IO.MemoryStream()) {
                    BitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                    encoder.Save(ms);
                    imageBytes = ms.ToArray();
                }
            }

            var customer = new Customer() {
                Name = NameText.Text,
                Phone = CallNumberText.Text,
                Address = AddressText.Text,
                Picture = imageBytes
            };

            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }

            ReadDatabase();
            CustomerListView.ItemsSource = _customers;
        }

        private void UpDateButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) return;

            byte[] imageBytes = null;
            if (ImageBox.Source is BitmapImage bitmapImage) {
                using (var ms = new System.IO.MemoryStream()) {
                    BitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                    encoder.Save(ms);
                    imageBytes = ms.ToArray();
                }
            }

            item.Name = NameText.Text;
            item.Phone = CallNumberText.Text;
            item.Address = AddressText.Text;
            item.Picture = imageBytes;

            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                connection.Update(item);
            }

            ReadDatabase();
            CustomerListView.ItemsSource = _customers;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("行を選択してください");
                return;
            }

            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);
            }

            ReadDatabase();
            CustomerListView.ItemsSource = _customers;
        }

        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) return;

            NameText.Text = item.Name;
            CallNumberText.Text = item.Phone;
            AddressText.Text = item.Address;
            ImageBox.Source = item.PictureImage;
        }

        private void SerchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            if (SerchTextBox.Text == "名前で検索") return;
            var search = _customers.Where(s => s.Name.Contains(SerchTextBox.Text));
            CustomerListView.ItemsSource = search;
        }

        // TextBoxヒント表示用
        private void SerchTextBox_GotFocus(object sender, RoutedEventArgs e) {
            if (SerchTextBox.Text == "名前で検索")
                SerchTextBox.Text = "";
        }

        private void SerchTextBox_LostFocus(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(SerchTextBox.Text))
                SerchTextBox.Text = "名前で検索";
        }

        private void ReadDatabase() {
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();
            }
        }
    }
}