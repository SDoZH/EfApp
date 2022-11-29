using EfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfApp.Views
{
    public class AddBaseView
    {
        public static void AddInfo()
        {
            using (var db = new AppContext())
            {
                
                // Заполняем данными
                var book1 = new Book { Title = "Гроза", Year="1990", Genres="Фентази", Author="Грач" };
                var book2 = new Book { Title = "Варяг", Year = "1990", Genres = "Проза", Author = "Грач" };
                var book3 = new Book { Title = "Огонь и лед", Year = "1992", Genres = "Фентази", Author = "Румын" };
                var book4 = new Book { Title = "Му-му", Year = "1993", Genres = "Роман", Author = "Петухов" };
               
                db.Books.AddRange(book1, book2, book3, book4);

                var user1 = new User { Name = "Лёха", Email = "1@mail.com" };
                var user2 = new User { Name = "Петя", Email = "2@mail.com" };
                var user3 = new User { Name = "Вася", Email = "3@mail.com" };
                var user4 = new User { Name = "Гриша", Email = "4@mail.com" };

                db.Users.AddRange(user1, user2, user3, user4);
                db.SaveChanges();
            }
           
        }
    }
}
