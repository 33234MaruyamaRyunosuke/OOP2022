using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class  Program{
        static void Main(String[] args) {
            SelesCounter sales = new SelesCounter("sales.csv");
            IDictionary<string, int> amountPerStore = sales.GetPerStoreSales();
            foreach (KeyValuePair<string, int> obj in amountPerStore) {
                Console.WriteLine("{0}{1}", obj.Key, obj.Value);
            }
        }


    }
}
