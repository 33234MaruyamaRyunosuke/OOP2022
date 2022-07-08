using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercise01 {

    public class Employees {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Hiredate { get; set; }
    }

    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            //Exercise1_2("employees.xml");
            //Exercise1_3("employees.xml");
            //Console.WriteLine();

            //Exercise1_4("employees.json");

            //// これは確認用
            //Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            var emp = new Employees {
                Id = 123,
                Name = "出井 秀行",
                Hiredate = new DateTime(2001, 5, 10)
            };

            //using (var writer = XmlWriter.Create()) {
            //    var serializer = new DataContractSerializer(novels.GetType());
            //    serializer.WriteObject(writer, novels);
            //}

            //using (var reader = XmlReader.Create()) {
            //    var serializer = new DataContractSerializer(typeof(Novel[]));
            //    var novels = serializer.ReadObject(reader) as Novel[];
            //    //Console.WriteLine(novel);
            //    foreach (var novel in novels) {
            //        Console.WriteLine(novel);
            //    }
            //}
        }

        private static void Exercise1_2(string v) {
            
        }

        private static void Exercise1_3(string v) {
            
        }

        private static void Exercise1_4(string v) {
            
        }
    }
}
