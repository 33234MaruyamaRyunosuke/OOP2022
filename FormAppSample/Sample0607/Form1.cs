﻿using System;
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

        Random rand = new Random();

        public Form1() {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e) {

            Number.Value = rand.Next(minValue: (int)Minnum.Value, maxValue: (int)Maxnum.Value + 1);
        }
    }
}
