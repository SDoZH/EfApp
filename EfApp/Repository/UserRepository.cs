using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfApp.Models;

namespace EfApp.Repository
{
    public class UserRepository
    {
        //выбор объекта из БД по его идентификатору
        public static void ChoiceUserForID()
        {

            using (var db = new AppContext())
            {
                var Users = db.Users.Where(user => user.Id == 1).ToList();
                foreach (var user in Users)
                {
                    Console.WriteLine(user.Name);
                }
            }
            Console.WriteLine("Для следующего запроса нажмите любую клавишу");
            Console.ReadKey();
        }
        //выбор всех объектов,
        public static void ChoiceAllUsers()
        {
            using (var db = new AppContext())
            {
                var allUsersd = db.Users.ToList();

                foreach (var User in allUsersd)
                {

                    Console.WriteLine(User.Name);
                }
            }
            Console.WriteLine("Для следующего запроса нажмите любую клавишу");
            Console.ReadKey();
        }
        //добавление объекта .
        public static void AddUser()
        {
            using (var db = new AppContext())
            {
                var user1 = new User { Name = "Лёха", Email = "1@mail.com" };
                db.Users.Add(user1);
                db.SaveChanges();
            }
            Console.WriteLine("Для следующего запроса нажмите любую клавишу");
            Console.ReadKey();
        }
        // удаление из БД
        public static void RemoveUser()
        {
            using (var db = new AppContext())
            {
                var user1 = new User { Name = "Лёха" };
                db.Users.Remove(user1);
                db.SaveChanges();
            }
            Console.WriteLine("Для следующего запроса нажмите любую клавишу");
            Console.ReadKey();
        }
        // обновление имени пользователя(по Id)
        public static void UpdateUser()
        {
            using (var db = new AppContext())
            {
                var firstUser = db.Users.FirstOrDefault();
                firstUser.Name = "Петросян";
                db.SaveChanges();
            }
            Console.WriteLine("Для следующего запроса нажмите любую клавишу");
            Console.ReadKey();
        }
    }
        
}

