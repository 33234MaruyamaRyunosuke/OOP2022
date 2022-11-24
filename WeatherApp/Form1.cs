using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
            tbPresenter.Text = json.publishingOffice;
            cbRegion.Text = json.targetArea;
            

            /*var now = DateTimeOffset.Now;
            tbWeatherInfo.Text = now.ToString();
            tbWeatherInfo.Text += "\r\n";*/

            
            pbWeatherIcon.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";

            
        }

        

        
    }
}
