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
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }
        //色を表示
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {

            byte R = (byte)rSlider.Value;
            byte G = (byte)gSlider.Value;
            byte B = (byte)bSlider.Value;

            colorArea.Background = new SolidColorBrush(Color.FromRgb(R, G, B));

        }
        //カラーリスト
        private void colorListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

            if (colorListBox.SelectedItem is MyColor selectedColor) {
                setSliderValue(selectedColor.Color);


            }
        }    

        //ストックボタン
        private void Button_Click(object sender, RoutedEventArgs e) {

            byte r = (byte)rSlider.Value;
            byte g = (byte)gSlider.Value;
            byte b = (byte)bSlider.Value;

            Color currentColor = Color.FromRgb(r, g, b);
            string name = $"R:{r} G:{g} B:{b}";
//自
            MyColor newColor = new MyColor() { Name = name, Color = currentColor };



            bool colorExists = false;
            foreach (MyColor color in colorListBox.Items) {
                if (color.Color.Equals(currentColor)) {
                    colorExists = true;
                    break;
                }
            }

            // 色がリストに無ければカラー追加
            if (!colorExists) {
                colorListBox.Items.Add(newColor);
            }





            // カラーリストに追加
           // colorListBox.Items.Add(newColor);


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = mycolor.Color;
            var name = mycolor.Name;
        }
        //コンボボックスから色を選択
       
        //各スライダーの値を設定
        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        

        }

        private void colorSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var comboSelectMyColor = (MyColor)((ComboBox)sender).SelectedItem;
            //  currentColor = comboSelectMyColor;
            setSliderValue(comboSelectMyColor.Color);
        }
    }
}

