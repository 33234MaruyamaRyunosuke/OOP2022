using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Exercise1 {
    class ToHanKaKuProcessor : TextProcessor{

        private static Dictionary<char, char> _dictionary = new Dictionary<char, char>() {
                {'０','0'}
        };

        protected override void Execute(string line) {

        }
    }
}
