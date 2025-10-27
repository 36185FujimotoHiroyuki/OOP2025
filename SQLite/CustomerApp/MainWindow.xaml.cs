using Microsoft.Win32;
using SQLite;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomerApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window{
  private List<CarPerson> _persons = new List<CarPerson>();
    public MainWindow(){
  
   // ublic MainWindow() {

        InitializeComponent();
        //ReadDatabase();



    }

    private void UpdateButton_Click(object sender, RoutedEventArgs e) {
        var item = PersonListView.SelectedItem as CarPerson;
        if (item is null) return;

        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<CarPerson>();

            var person = new CarPerson() {
                Id = item.Id,
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
            };
           // connection.Update(CarPerson);
        }
}

    private void SaveButton_Click(object sender, RoutedEventArgs e) {

        var person = new CarPerson() {
            Name = NameTextBox.Text,
            Phone = PhoneTextBox.Text,
            Address = AddressTextBox.Text,
            Picture = ImageToByteArray(Image:(BitmapImage)pictureBox.Source),
        };
        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<CarPerson>();
            connection.Insert(person);
            

        }
        ReadDatabase();
    }


    private void DeleteButton_Click(object sender, RoutedEventArgs e) {

        var item = PersonListView.SelectedItem as CarPerson;

        if (item == null) {
            MessageBox.Show("行を選択して");
            return;
        }
            using (var connection = new SQLiteConnection(App.databasePath)) {
                connection.CreateTable<CarPerson>();

                connection.Delete(item);   //データベースから選択されているレコードの削除

                ReadDatabase();

                PersonListView.ItemsSource = _persons;
            }
        }
    }
    private void PersonListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {


        var item = PersonListView.SelectedItem as CarPerson;
        if (item is null) return;
        NameTextBox.Text = item.Name;
        PhoneTextBox.Text = item.Phone;
    }

   

    private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
        var query = SearchTextBox.Text.ToLower();

        // 名前 電話番号 住所 検索
        var filteredList = _persons.Where(p =>
            p.Name.ToLower().Contains(query) ||
            p.Phone.ToLower().Contains(query) ||
            p.Address.ToLower().Contains(query)
        ).ToList();

        // フィルタリングされたリストを表示
        PersonListView.ItemsSource = filteredList;
  
    }

    private void Image_Click(object sender, RoutedEventArgs e) {


        var dialog = new Microsoft.Win32.OpenFileDialog {
            Title = "画像を選択してください",
            Filter = "画像ファイル (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
        };

        // ファイルが選択されたら
        if (dialog.ShowDialog() == true) {
            // 選択した画像ファイルを BitmapImage に読み込む
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.UriSource = new Uri(dialog.FileName);
            bitmap.EndInit();

            // Image コントロールに表示
            picture.Source = bitmap;

            // もし後でDBに保存する場合、画像を保持しておく
            // _selectedImage = bitmap;


        } }
}
