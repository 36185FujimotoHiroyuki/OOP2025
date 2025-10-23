using SQLite;
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
 // private List<Person> _persons = new List<Person>();
    public MainWindow(){
  
   // ublic MainWindow() {

        InitializeComponent();
       // ReadDatabase();



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

    private void ReadButton_Click(object sender, RoutedEventArgs e) {
        var person = new CarPerson() {
            Id = item.Id,
            Name = NameTextBox.Text,
            Phone = PhoneTextBox.Text,
            Address = AddressTextBox.Text,

        };
    

    private void DeleteButton_Click(object sender, RoutedEventArgs e) {

        var item = PersonListView.SelectedItem as CarPerson;

        if (item == null) {
            MessageBox.Show("行を選択して");
            return;

        }
}
    private void PersonListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {


    }
}