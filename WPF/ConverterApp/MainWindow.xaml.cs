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

namespace ConverterApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();



            MetricUnit.ItemsSource = new List<string> { "mm", "cm", "m", "km" };


            ImperialUnit.ItemsSource = new List<string> { "インチ", "フィート", "ヤード", "マイル" };
            MetricUnit.SelectedIndex = 2; ImperialUnit.SelectedIndex = 1;
           

        }
        private void MetricUnit_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            // メートル法単位が変更された場合、変換を行う
            ConvertUnits();
        }

        private void ImperialUnit_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            // インペリアル単位が変更された場合、変換を行う
            ConvertUnits();
        }

        private void ImperialValue_TextChanged(object sender, TextChangedEventArgs e) {
            // インペリアル単位の値が変更された場合、メートル法の値を更新
            double imperialValue;
            if (double.TryParse(ImperialValue.Text, out imperialValue)) {
                string imperialUnit = ImperialUnit.SelectedItem as string;
                string metricUnit = MetricUnit.SelectedItem as string;
                double metricValue = ImperialToMetric(imperialValue, imperialUnit, metricUnit);
                MetricValue.Text = metricValue.ToString("F2");
            }
        }

        private void MetricValue_TextChanged(object sender, TextChangedEventArgs e) {
            // メートル法の値が変更された場合、インペリアル単位の値を更新
            double metricValue;
            if (double.TryParse(MetricValue.Text, out metricValue)) {
                string metricUnit = MetricUnit.SelectedItem as string;
                string imperialUnit = ImperialUnit.SelectedItem as string;
                double imperialValue = MetricToImperial(metricValue, metricUnit, imperialUnit);
                ImperialValue.Text = imperialValue.ToString("F2");
            }
        }

        // メートル法 → インペリアル単位の変換
        private double MetricToImperial(double value, string metricUnit, string imperialUnit) {
            double result = 0;

            if (metricUnit == "m") {
                if (imperialUnit == "インチ") {
                    result = value * 39.3701; // メートル -> インチ
                } else if (imperialUnit == "フィート") {
                    result = value * 3.28084; // メートル -> フィート
                } else if (imperialUnit == "ヤード") {
                    result = value * 1.09361; // メートル -> ヤード
                } else if (imperialUnit == "マイル") {
                    result = value * 0.000621371; // メートル -> マイル
                }
            } else if (metricUnit == "cm") {
                if (imperialUnit == "インチ") {
                    result = value * 0.393701; // センチメートル -> インチ
                } else if (imperialUnit == "フィート") {
                    result = value * 0.0328084; // センチメートル -> フィート
                } else if (imperialUnit == "ヤード") {
                    result = value * 0.0109361; // センチメートル -> ヤード
                } else if (imperialUnit == "マイル") {
                    result = value * 0.0000062137; // センチメートル -> マイル
                }
            }
            return result;
        }

        // インペリアル単位 → メートル法の変換
        private double ImperialToMetric(double value, string imperialUnit, string metricUnit) {
            double result = 0;

            if (imperialUnit == "インチ") {
                if (metricUnit == "m") {
                    result = value * 0.0254; // インチ -> メートル
                } else if (metricUnit == "cm") {
                    result = value * 2.54; // インチ -> センチメートル
                }
            } else if (imperialUnit == "フィート") {
                if (metricUnit == "m") {
                    result = value * 0.3048; // フィート -> メートル
                } else if (metricUnit == "cm") {
                    result = value * 30.48; // フィート -> センチメートル
                }
            } else if (imperialUnit == "ヤード") {
                if (metricUnit == "m") {
                    result = value * 0.9144; // ヤード -> メートル
                } else if (metricUnit == "cm") {
                    result = value * 91.44; // ヤード -> センチメートル
                }
            } else if (imperialUnit == "マイル") {
                if (metricUnit == "m") {
                    result = value * 1609.34; // マイル -> メートル
                } else if (metricUnit == "cm") {
                    result = value * 160934; // マイル -> センチメートル
                }
            }

            return result;
        }

        // ユーザーが入力した値を基に単位の変換を行うメソッド
        private void ConvertUnits() {
            string metricUnit = MetricUnit.SelectedItem as string;
            string imperialUnit = ImperialUnit.SelectedItem as string;

            double metricValue = 0;
            double imperialValue = 0;

            // メートル法の値が入力されている場合
            if (double.TryParse(MetricValue.Text, out metricValue)) {
                imperialValue = MetricToImperial(metricValue, metricUnit, imperialUnit);
                ImperialValue.Text = imperialValue.ToString("F2");
            }
            // インペリアルの値が入力されている場合
            else if (double.TryParse(ImperialValue.Text, out imperialValue)) {
                metricValue = ImperialToMetric(imperialValue, imperialUnit, metricUnit);
                MetricValue.Text = metricValue.ToString("F2");
            }
        }
    }
}