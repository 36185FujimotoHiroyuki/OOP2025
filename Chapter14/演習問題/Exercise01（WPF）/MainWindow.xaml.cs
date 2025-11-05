using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Exercise01_WPF_ {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
     
        public ObservableCollection<string> TextLines { get; set; }

        public MainWindow() {
            InitializeComponent();
            TextLines = new ObservableCollection<string>();
            textListView.ItemsSource = TextLines; 
        }


        private async void LoadingButton_Click(object sender, RoutedEventArgs e) {
            try {
           
                string filePath = @"C:\Users\infosys\source\repos\OOP2025\Chapter14\演習問題\Exercise01（WPF）\走れメロス.txt";

           
                string fileContent = await TextReaderSample.ReadText(filePath);

              
                TextLines.Clear(); 
                foreach (var line in fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.None)) {
                    TextLines.Add(line); 
                }

              
                label1.Content = "読み込み完了";
            }
            catch (Exception ex) {
              
                label1.Content = $"エラー: {ex.Message}";
            }
        }
    }

  
    static class TextReaderSample {
       
        public static async Task<string> ReadText(string filePath) {
            var sb = new StringBuilder();
            using (var sr = new StreamReader(filePath, Encoding.UTF8)) {
             
                while (!sr.EndOfStream) {
                    string? line = await sr.ReadLineAsync();
                    sb.AppendLine(line); 
                }
            }
            return sb.ToString();
        }
    }
}
