using Sample.Data;
using SQLite;
using System;
using System.Collections.ObjectModel;
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

namespace Sample;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window{
    private ObservableCollection<Person> _persons = new ObservableCollection<Person>();


    public MainWindow() {

        InitializeComponent();
        //ReadDatabase();
        _persons.Add(new Person { Id = 1, Name = "rrrrrrrrrr", Phone = "56678" });
        PersonListView.ItemsSource = _persons;

        // _persons.Add(new Person { Id = 10, Name = "fffffff", Phone = "55555555555" });
        // _persons.Add(new Person { Id = 11, Name = "fyyyyyyy", Phone = "777777755" });
        // _persons.Add(new Person { Id = 12, Name = "eeeeeef", Phone = "1111111115" });
    }
    private void ReadDatabase() {


        using (var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
          //  PersonListView.ItemsSource = connection.Table<Person>().ToList();

        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e) {

        var person = new Person() {
            Name = NameTextBox.Text,
            Phone = PhoneTextBox.Text,


        };
        using(var connection = new SQLiteConnection(App.databasePath)) {
            connection.CreateTable<Person>();
            connection.Insert(person);


        }
    }

    private void ReadButton_Click(object sender, RoutedEventArgs e) {

        //using (var connection = new SQLiteConnection(App.databasePath)) {
        // connection.CreateTable<Person>();

        // var persons = connection.Table<Person>().ToList();


        _persons.Add(new Person { Id = 1, Name = "lllllllll", Phone = "4568778798" });
        // ReadDatabase();




    }
        

    }
