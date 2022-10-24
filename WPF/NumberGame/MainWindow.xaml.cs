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

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        Random random = new Random();

        private int correctNumber;

        public MainWindow() {
            InitializeComponent();
        }

        private void Button_click(object sender, RoutedEventArgs e) {
            Button bt = (Button)sender;
            if((string)bt.Content == correctNumber.ToString()) { 
            //if (int.Parse(bt.Content.ToString()) == correctnumber) {
                infoDisp.Text = "正解！";
                bt.Background = Brushes.Red;
            }
            else {
                infoDisp.Text 
                    = int.Parse((string)bt.Content) < correctNumber 
                                    ? "もっと大きいです！" : "もっと小さいです！";

                bt.Background = int.Parse((string)bt.Content) < correctNumber 
                                ? Brushes.CadetBlue : Brushes.YellowGreen;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            infoDisp.Text = "ゲームスタート";
            correctNumber = random.Next(25) + 1;
            this.Title = correctNumber.ToString();
        }
    }
}
