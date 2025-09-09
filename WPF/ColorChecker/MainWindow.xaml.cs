using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();

        }
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i =>　new MyColor() { Color = (Color)i.GetValue(null), Name =i.Name}).ToArray();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

            byte red = (byte)rSlider.Value;
            byte green = (byte)gSlider.Value;
            byte blue = (byte)bSlider.Value;

            colorArea.Background = new SolidColorBrush(Color.FromRgb(red, green, blue));

        }

        private void Button_Click(object sender, RoutedEventArgs e) {

            byte r = (byte)rSlider.Value;
            byte g = (byte)gSlider.Value;
            byte b = (byte)bSlider.Value;

            Color currentColor = Color.FromRgb(r, g, b);
            string name = $"R:{r} G:{g} B:{b}";
        }
        //コンボボックスから色を選択
        private void colorSelectComboBox_SelectionChanged(object sender, SelectedCellsChangedEventArgs e) {
            var comboSelectMyColor = (MyColor)((ComboBox)sender).SelectedItem;
           setSliderValue( comboSelectMyColor.Color);

        }

        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void colorListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }
    }
}

