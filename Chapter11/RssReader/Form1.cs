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
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        IEnumerable<string> xTitle,xLink;
        public Form1() {
            InitializeComponent();
        }

        private void btRSSget_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {

                var stream = wc.OpenRead(cbRSSurl.Text);

                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x => (string) x.Element("title"));
                xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));
                foreach (var data in xTitle) {
                    lbRSSTitle.Items.Add(data);

                }
            }
        }

        private void btback_Click(object sender, EventArgs e) {
            wbBrowser.GoBack();
        }

        private void btforward_Click(object sender, EventArgs e) {
            wbBrowser.GoForward();
        }

        private void Form1_Load(object sender, EventArgs e) {
            BackForwardButtonMaskCheck();
        }

        private void wvBrowser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e) {
            BackForwardButtonMaskCheck();
        }

        private void BackForwardButtonMaskCheck(){
        btback.Enabled = wvBrowser.CanGoBack;
            btforward.Enabled = wvBrowser.CanGoForward;
        }

        private void lbRSSTitle_click(object sender, EventArgs e) {
            int index = lbRSSTitle.SelectedIndex;
            var url = xLink.ElementAt(index);
            wvBrowser.Source = new Uri(url);
        }


    }
}
