using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    public class SalesCounter {
        private IEnumerable<Sale> _sales; //csvファイルから読み込んだデータ

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        //科目別点数を求める
        public IDictionary<String, int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }

        //生徒データを読み込み、Studentオブジェクトのリストを返す
        public static IEnumerable<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] Lines = File.ReadAllLines(filePath);
            foreach (string Line in Lines) {
                string[] items = Line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    productCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
}
