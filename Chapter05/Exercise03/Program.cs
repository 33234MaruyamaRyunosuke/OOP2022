﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
     class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
            Console.WriteLine("-----");
        }

        private static void Exercise3_1(string text) {
            int spaces = text.Count(c => c == ' ');
            Console.WriteLine("空白数:{0}", spaces);
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            int count = text.Split(' ').Length;
            Console.WriteLine("空白数:{0}",count);
        }

        private static void Exercise3_4(string text) {
            var s = text.Split(' ').Where(word => word.Length <=4);
            
            foreach (var item in s) {
                Console.WriteLine(item);
            }
            
        }

        private static void Exercise3_5(string text) {
            var array = text.Split(' ');
           if(array.Length > 0) {

                var sb = new StringBuilder(array[0]);
                foreach(var word in array.Skip(1)) {
                    
                    sb.Append(' ');
                    sb.Append(word);
                }

                var str = sb.ToString();
                Console.WriteLine(str);
           }
        }
     }
}
