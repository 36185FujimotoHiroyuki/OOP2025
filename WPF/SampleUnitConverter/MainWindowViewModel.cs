using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    internal class MainWindowViewModel : ViewModel {// BindableBase {
       
        //フィールド
        private double metricValue;
        private double imperialValue;

        //▲で呼ばれるコマンド
        public ICommand ImperialUnitTometric { get; private set; }
        //▼で呼ばれるコマンド
        public ICommand MetricUnitToImperial { get; private set; }

        public MetricUnit CurrentMetricUnit { get; set; }
        public ImperialUnit CurrentImperialUnit { get; set; }



        //プロパティ
        public double MetricValue {

            get => metricValue;

            set {
                this.metricValue = value;
                this.OnPropertyChanged();

            }
        }
        public double ImperialValue {

            get => imperialValue;

            set {
                this.imperialValue = value;
                this.OnPropertyChanged();
            }
        }
        public MainWindowViewModel() {
            CurrentMetricUnit = MetricUnit.Unites.First();
            CurrentImperialUnit = ImperialUnit.Unite.First();


            ImperialUnitTometric = new DelegateCommand(
           () => MetricValue =
           CurrentMetricUnit.FromImperialUnit(CurrentImperialUnit, ImperialValue));

            MetricUnitToImperial = new DelegateCommand(
            () => ImperialValue =
               CurrentImperialUnit.FromMetricUnit(CurrentMetricUnit, MetricValue));



        }

    }
}

