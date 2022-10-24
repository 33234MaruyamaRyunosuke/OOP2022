using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel{
        private double metricValue, imperialValue;

        public double MetricValue {
            get { return this.metricValue; }
            set {
                this.metricValue = value;
                this.OnPropertyChanged();
            }
        }

        public double ImperialValue {
            get { return this.imperialValue; }
            set {
                this.imperialValue = value;
                this.OnPropertyChanged();
            }
        }

        public MetricUnit CurrentMetricUnit { get; set; }

        public ImperialUnit CurrentImperialUnit {get; set; }

        public ICommand InperialUnitToMetric { get; private set; }

        public ICommand MetricToInperialUnit { get; private set; }

        public MainWindowViewModel() {

            this.CurrentMetricUnit = MetricUnit.Units.First();
            this.CurrentImperialUnit = ImperialUnit.Units.First();

            this.MetricToInperialUnit = new DelegateCommand(
                () => this.imperialValue = this.CurrentImperialUnit.FromMetricUnit(
                    this.CurrentMetricUnit, this.metricValue));

            this.InperialUnitToMetric = new DelegateCommand(
                () => this.MetricValue = this.CurrentMetricUnit.FromImperialUnit(
                    this.CurrentImperialUnit, this.metricValue));
        }
    }
}
