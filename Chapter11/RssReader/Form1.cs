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

        IEnumerable<string> xTitle;
        public Form1() {
            InitializeComponent();
        }

        private void btRSSget_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {

                var stream = wc.OpenRead(cbRSSurl.Text);

                var xdoc = XDocument.Load(stream);
                xTitle = xdoc.Root.Descendants("item").Select(x => (string) x.Element("title"));

                foreach (var data in xTitle) {
                    lbRSSTitle.Items.Add(data);

                }
            }
        }

        private void lbRSSTitle_click(object sender, EventArgs e) {
            int index = lbRSSTitle.SelectedIndex;

        }


    }
}
