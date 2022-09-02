using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample {
    class Singleton {

        private static Singleton singleton;

        private Singleton() {
            Console.WriteLine("インスタンスを生成しました。");
        }

        public static Singleton getInstance() {
            
            if(singleton == null) {
                singleton = new Singleton();
            }
            return singleton;
        }
    }
}
