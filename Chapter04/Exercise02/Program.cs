﻿using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            // 4.2.1
            var ymCollection = new YearMonth[] {
               new YearMonth(2017,9),
               new YearMonth(2002,8),
               new YearMonth(1994,5),
               new YearMonth(2020,2),
               new YearMonth(2009,10),  //最後のカンマはつけておく
            };

            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("----");

            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("----");

            //4.2.5
            Exercise2_5(ymCollection);

            Exercise2_6(ymCollection);
        }

        private static void Exercise2_6(YearMonth[] ymCollection) {
            foreach(var ym in ymCollection.Where(ym => DateTime.IsLeapYear(ym.Year))) {
                Console.WriteLine(ym);
            }

            var data = ymCollection.Max(ym=>ym.Month);
            Console.WriteLine(data);
        }

        //4.2.3
        //最初に見つかった21世紀のオブジェクトを返す
        //見つからない場合はnullを返す
        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach(var ym in yms) {
                if (ym.Is21Century) {
                    return ym;
                }
            }

            return null;
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);

            }
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var yearmonth = FindFirst21C(ymCollection);
            if(yearmonth != null) {
                Console.WriteLine(yearmonth);
            }
            else {
                Console.WriteLine("21世紀のデータはありません");
            }
        }
        
        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach(var ym in array) {
                Console.WriteLine(ym);
            }
        }

        


    }
}
