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

            /*var now = DateTimeOffset.Now;
            tbWeatherInfo.Text = now.ToString();
            tbWeatherInfo.Text += "\r\n";*/


            pbWeatherIcon.ImageLocation = "https://www.jma.go.jp/bosai/forecast/img/101.png";

            
        }

        private void Form1_Load(object sender, EventArgs e) {
            pbJapanMap.ImageLocation = "https://deliver.commons.nicovideo.jp/thumbnail/nc71002?size=l";

            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };


            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/090000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
            tbPresenter.Text = json.publishingOffice;
            cbRegion.Text = json.targetArea;

        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            
        }

        private void btHokkaido_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            cbRegion.Items.Clear();

            cbRegion.Items.Add("宗谷地方");
            cbRegion.Items.Add("上川・留萌地方");
            cbRegion.Items.Add("網走・北見・紋別地方");
            cbRegion.Items.Add("十勝地方");
            cbRegion.Items.Add("釧路・根室地方");
            cbRegion.Items.Add("胆振・日高地方");
            cbRegion.Items.Add("石狩・空知・後志地方");
            cbRegion.Items.Add("渡島・檜山地方");

            cbRegion.SelectedItem = "宗谷地方";
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/011000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
            tbPresenter.Text = json.publishingOffice;

        }

        private void btTohoku_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            cbRegion.Items.Clear();

            cbRegion.Items.Add("青森県");
            cbRegion.Items.Add("岩手県");
            cbRegion.Items.Add("宮城県");
            cbRegion.Items.Add("秋田県");
            cbRegion.Items.Add("山形県");
            cbRegion.Items.Add("福島県");

            cbRegion.SelectedItem = "青森県";
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/020000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
            tbPresenter.Text = json.publishingOffice;

        }

        private void btKantoKousinetu_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            cbRegion.Items.Clear();

            cbRegion.Items.Add("茨城県");
            cbRegion.Items.Add("栃木県");
            cbRegion.Items.Add("群馬県");
            cbRegion.Items.Add("埼玉県");
            cbRegion.Items.Add("千葉県");
            cbRegion.Items.Add("東京都");
            cbRegion.Items.Add("神奈川県");
            cbRegion.Items.Add("新潟県");
            cbRegion.Items.Add("山梨県");
            cbRegion.Items.Add("長野県");

            cbRegion.SelectedItem = "茨城県";
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/080000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
            tbPresenter.Text = json.publishingOffice;

        }

        private void btHokuriku_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            cbRegion.Items.Clear();

            cbRegion.Items.Add("富山県");
            cbRegion.Items.Add("石川県");
            cbRegion.Items.Add("福井県");

            cbRegion.SelectedItem = "富山県";
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/160000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
            tbPresenter.Text = json.publishingOffice;

        }

        private void btTokai_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            cbRegion.Items.Clear();

            cbRegion.Items.Add("岐阜県");
            cbRegion.Items.Add("静岡県");
            cbRegion.Items.Add("愛知県");
            cbRegion.Items.Add("三重県");

            cbRegion.SelectedItem = "岐阜県";
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/210000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
            tbPresenter.Text = json.publishingOffice;

        }

        private void btKinki_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            cbRegion.Items.Clear();

            cbRegion.Items.Add("滋賀県");
            cbRegion.Items.Add("京都府");
            cbRegion.Items.Add("大阪府");
            cbRegion.Items.Add("兵庫県");
            cbRegion.Items.Add("奈良県");
            cbRegion.Items.Add("和歌山県");

            cbRegion.SelectedItem = "滋賀県";
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/250000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
            tbPresenter.Text = json.publishingOffice;

        }

        private void btTyugokuSikoku_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            cbRegion.Items.Clear();

            cbRegion.Items.Add("鳥取県");
            cbRegion.Items.Add("島根県");
            cbRegion.Items.Add("岡山県");
            cbRegion.Items.Add("広島県");
            cbRegion.Items.Add("山口県");
            cbRegion.Items.Add("徳島県");
            cbRegion.Items.Add("香川県");
            cbRegion.Items.Add("愛媛県");
            cbRegion.Items.Add("高知県");

            cbRegion.SelectedItem = "鳥取県";
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/310000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
            tbPresenter.Text = json.publishingOffice;

        }

        private void btKyusyu_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            cbRegion.Items.Clear();

            cbRegion.Items.Add("福岡県");
            cbRegion.Items.Add("佐賀県");
            cbRegion.Items.Add("長崎県");
            cbRegion.Items.Add("大分県");
            cbRegion.Items.Add("熊本県");
            cbRegion.Items.Add("宮崎県");
            cbRegion.Items.Add("鹿児島県");
            cbRegion.Items.Add("奄美地方");

            cbRegion.SelectedItem = "福岡県";
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/400000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
            tbPresenter.Text = json.publishingOffice;

        }

        private void btOkinawa_Click(object sender, EventArgs e) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };

            cbRegion.Items.Clear();

            cbRegion.Items.Add("沖縄本島地方");
            cbRegion.Items.Add("大東島地方");
            cbRegion.Items.Add("宮古島地方");
            cbRegion.Items.Add("八重山地方");

            cbRegion.SelectedItem = "沖縄本島地方";
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/forecast/data/overview_forecast/471000.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);

            tbWeatherInfo.Text = json.text;
            tbPresenter.Text = json.publishingOffice;

        }
    }
}
