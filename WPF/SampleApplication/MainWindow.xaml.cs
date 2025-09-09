using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleApplication {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void seasonComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            seasonTextBlock.Text = (string)((ComboBoxItem)(seasonComboBox.SelectedItem)).Content;
        }

        private void redRadioBUtton_Checked(object sender, RoutedEventArgs e) {
            colorText.Text = "赤";

        }
        // private void colorRadioBUtton_Checked(object sender, RoutedEventArgs e) {
        // colorText.Text = (string)((RadioBUtton)(sender)).Content;

        private void yellowRadioBUtton_Checked(object sender, RoutedEventArgs e) {
            colorText.Text = "黄";

        }
        private void blueRadioBUtton_Checked(object sender, RoutedEventArgs e) {

            colorText.Text = "青";
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e) {

            checkBoxTextBlock.Text = "チェック済み";
        }
     

        }
    }
