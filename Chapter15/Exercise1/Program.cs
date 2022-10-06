using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.First(b => b.Price == max);
            Console.WriteLine(book);       
        }

        private static void Exercise1_3() {
            var query = Library.Books.GroupBy(b => b.PublishedYear);
                
            
            foreach(var item in query.OrderBy(b=>b.Key)) {
                Console.WriteLine("{0}年 {1}冊", item.Key, item.Count());
            }
        }

        private static void Exercise1_4() {
            var query = Library.Books
                .Join(Library.Categories,
                    book => book.CategoryId,
                    Category => Category.Id,
                    (book, Category) => new {
                        book.Title,
                        book.PublishedYear,
                        book.Price,
                        CategoryName = Category.Name
                    })
                .OrderByDescending(x => x.PublishedYear)
                .ThenByDescending(x => x.Price);

            foreach (var item in query)
                Console.WriteLine("{0}年 {1}円 {2} ({3})",
                    item.PublishedYear,
                    item.Price,
                    item.Title,
                    item.CategoryName
                    );
                    
        }

        private static void Exercise1_5() {
            var query = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                    book => book.CategoryId,
                    Category => Category.Id,
                    (book, Category) => Category.Name)
                .Distinct();

            foreach (var name in query)
                Console.WriteLine(name);
        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}
