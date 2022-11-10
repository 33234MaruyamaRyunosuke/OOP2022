﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {

        List<MyColor> colorList = new List<MyColor>();
        

        //コンストラクタ
        public MainWindow() {
            InitializeComponent();

            DataContext = GetcolorList(); //←追加

        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetcolorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            setColor();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            setColor();
        }

        private void setColor() {
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);

            Color color = Color.FromRgb(r, g, b);

            colorArea.Background = new SolidColorBrush(color);


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            //var color = mycolor.Color;
            //var name = mycolor.Name;

            rSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.R;
            gSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.G;
            bSlider.Value = ((MyColor)((ComboBox)sender).SelectedItem).Color.B;
            setColor();
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {

            MyColor stColor = new MyColor();
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);
            stColor.Color = Color.FromRgb(r, g, b);

            var colorName = ((IEnumerable<MyColor>)DataContext)
                                .Where(c => c.Color.R == stColor.Color.R && c.Color.G == stColor.Color.G && c.Color.B == stColor.Color.B).FirstOrDefault();

            stockList.Items.Insert(0, colorName?.Name ?? "R：" + rValue.Text + "　G：" + gValue.Text + "　B：" + bValue.Text);
            colorList.Insert(0,stColor);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (stockList.SelectedIndex == -1) return;

            rSlider.Value = colorList[stockList.SelectedIndex].Color.R;
            gSlider.Value = colorList[stockList.SelectedIndex].Color.G;
            bSlider.Value = colorList[stockList.SelectedIndex].Color.B;
            setColor();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e) {
            var delIndex = stockList.SelectedIndex;

            if (delIndex == -1) return;

            stockList.Items.RemoveAt(delIndex);
            colorList.RemoveAt(delIndex);

        }

        
    }

    /// <summary>
    /// 色と色名を保持するクラス
    /// </summary>
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
