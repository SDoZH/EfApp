using EfApp.Models;
using System;
using System.Text;
using EfApp.Models;
using System.Linq;

namespace EfApp.Views
{
    public class UserAndBookInfoView
    {
        public static void Info()
        {
            BooksGenres();
            BooksAuthor();
            BooksAny();
            SelectedBook();
            SelectedBookDescending();

        }
        public static void BooksGenres()
        {
            using (var db = new AppContext())
            {
                //Получать список книг определенного жанра и вышедших между определенными годами.
                var booksGenres = db.Books.Where(u => u.Genres == "Фентази" && u.Year == "1990");
                foreach (var book in booksGenres)
                {
                    Console.WriteLine(book.Title, book.Author);
                }
            }
        }
        public static void BooksAuthor()
        {
            using (var db = new AppContext())
            {
                //Получать количество книг определенного автора в библиотеке.
                var booksAuthor = db.Books.Count(u => u.Author == "Грач");

                Console.WriteLine(booksAuthor);
            }
        }
        public static void BooksAny()
        {
            //Получать булевый флаг о том, есть ли книга определенного автора и с определенным названием в библиотеке.
            using (var db = new AppContext())
            {
                var booksAny = db.Books.Any(u => u.Title == "Фентази" && u.Author == "Грач");

                Console.WriteLine(booksAny);
            }
        }
        public static void SelectedBook()
        {
            //Получение списка всех книг, отсортированного в алфавитном порядке по названию.
            using (var db = new AppContext())
            {
                var selectedbook = db.Books.OrderBy(p => p.Title);
                foreach (var book in selectedbook)
                {
                    Console.WriteLine(book.Title);
                }
            }
        }
        public static void SelectedBookDescending()
        {
            //Получение списка всех книг, отсортированного в порядке убывания года их выхода
            using (var db = new AppContext())
            {
                var selectedbookDescending = db.Books.OrderByDescending(p => p.Year);
                foreach (var book in selectedbookDescending)
                {
                    Console.WriteLine(book.Title);
                }
            }
        }
        //Получать булевый флаг о том, есть ли определенная книга на руках у пользователя.

        //Получать количество книг на руках у пользователя.

        //Получение последней вышедшей книги.

    }
}


