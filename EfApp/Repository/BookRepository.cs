using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfApp.Models;

namespace EfApp.Repository
{
    public class BookRepository
    {
        //действия: выбор объекта из БД по его идентификатору
        public static void ChoiceBookForID()
        {
            using (var db = new AppContext())
            {
                var Books = db.Books.Where(book => book.Id == 1).ToList();
                foreach (var book in Books)
                {
                    Console.WriteLine(book.Title);
                }
                Console.WriteLine("Для следующего запроса нажмите любую клавишу");
                Console.ReadKey();
            }
        }
        //выбор всех объектов,
        public static void ChoiceAllBook()
        {
            using (var db = new AppContext())
            {
                var allBooksd = db.Books.ToList();

                foreach (var book in allBooksd)
                {

                    Console.WriteLine(book.Title);
                }
            }
            Console.WriteLine("Для следующего запроса нажмите любую клавишу");
            Console.ReadKey();
        }
        //добавление объекта .
        public static void AddBook()
        {
            using (var db = new AppContext())
            {
                var book1 = new Book { Title = "Фраза", Year = "1993", Genres = "Фентази", Author = "Грач" };
                db.Books.Add(book1);
                db.SaveChanges();
            }
            Console.WriteLine("Для следующего запроса нажмите любую клавишу");
            Console.ReadKey();
        }
        // удаление из БД
        public static void RemoveBook()
        {
            using (var db = new AppContext())
            {
                var book1 = new Book { Title = "Фраза" };
                db.Books.Remove(book1);
                db.SaveChanges();
            }
            Console.WriteLine("Для следующего запроса нажмите любую клавишу");
            Console.ReadKey();
        }
        //и обновление года выпуска книги(по Id).
        public static void UpdateBook()
        {
            using (var db = new AppContext())
            {
                var firstBook = db.Books.FirstOrDefault();
                firstBook.Year = "1990";
                db.SaveChanges();
            }
            Console.WriteLine("Для следующего запроса нажмите любую клавишу");
            Console.ReadKey();
        }

    }
}


