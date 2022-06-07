using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0607 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btpush_Click(object sender, EventArgs e) {
            if(nudnum2.Value != 0) {
                nudAns.Value = nudnum1.Value / nudnum2.Value;
                nudMod.Value = nudnum1.Value % nudnum2.Value;
            }
            else {
                MessageBox.Show("0で割り算出来ません!",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }
    }
}
