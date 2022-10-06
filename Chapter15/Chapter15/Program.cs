using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {

            var years = new List<int>();
            int year;

            Console.WriteLine("出力したい西暦を入力 (終了 : -1)");
            year = int.Parse (Console.ReadLine());

            while (year != -1) {
                years.Add(year);
                year = int.Parse(Console.ReadLine());
            }

            int sort;

            Console.Write("昇順:1 降順:2 :");
            sort = int.Parse(Console.ReadLine());

            IEnumerable<Book> books;
            if(sort == 1) {
                books = Library.Books
                    .Where(b => years.Contains(b.PublishedYear))
                    .OrderBy(b => b.PublishedYear);
            }
            else {
                books = Library.Books
                    .Where(b => years.Contains(b.PublishedYear))
                    .OrderByDescending(b => b.PublishedYear);
            }

            foreach(var book in books) {
                Console.WriteLine(book);
            }

            Console.WriteLine();
            /*var groups = Library.Books
                .GroupBy(b => b.PublishedYear)
                .Select(group => group.OrderByDescending(b => b.Price).First())
                .Where(b => years.Contains(b.PublishedYear))
                .OrderBy(g => g.Key);*/

            var selected = Library.Books
                .Where(b => years.Contains(b.PublishedYear))
                .OrderByDescending(b => b.PublishedYear)
                .ThenBy(b => b.PublishedYear)
                .Join(Library.Categories,
                        book => book.CategoryId,
                        category => category.Id,
                        (book, Category) => new {
                            Title = book.Title,
                            Category = Category.Name,
                            PublishedYear = book.PublishedYear,
                            price = book.Price,
                        }
                ).ToList();

            foreach (var book in selected
                                    .OrderByDescending(x=>x.PublishedYear)
                                    .ThenBy(x=>x.Category)) {

                Console.WriteLine($"{book.PublishedYear},{book.Title},{book.Category},{book.price}");
            }
            Console.WriteLine($"金額の合計{selected.Sum(b => b.price)}円");

        }
    }
}
