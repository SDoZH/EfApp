
using EfApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using EfApp.Repository;

namespace EfApp.Views
{
    public class UserAndBookDataUpdateView
    {

        public static void DataUpdate()
        {

            while (true)
            {
                Console.WriteLine("Добавить книгу:1");
                Console.WriteLine("Удалить книгу:2");
                Console.WriteLine("Обновить название книги^3");
                Console.WriteLine();
                Console.WriteLine("Добавить читателя:4");
                Console.WriteLine("Удалить читателя:5");
                Console.WriteLine("Обновить имя читателя:6");
                Console.WriteLine();
                Console.WriteLine("Выбрать книгу по ID:7");
                Console.WriteLine("Выбрать читателя по ID:8 ");
                Console.WriteLine();
                Console.WriteLine("Показать список книг:9");
                Console.WriteLine("Показать список читателей:10");

                string keyValue = Console.ReadLine();

                if (keyValue == "11") break;

                switch (keyValue)
                {
                    case "1":
                        {
                            BookRepository.AddBook();
                            break;
                        }
                    case "2":
                        {
                            BookRepository.RemoveBook();
                            break;
                        }
                    case "3":
                        {
                            BookRepository.UpdateBook();
                            break;
                        }

                    case "4":
                        {
                            UserRepository.AddUser();
                            break;
                        }

                    case "5":
                        {

                            UserRepository.RemoveUser();
                            break;
                        }

                    case "6":
                        {
                            UserRepository.UpdateUser();
                            break;
                        }
                    case "7":
                        {
                            BookRepository.ChoiceBookForID();
                            break;
                        }
                    case "8":
                        {
                            UserRepository.ChoiceUserForID();
                            break;
                        }
                    case "9":
                        {
                            BookRepository.ChoiceAllBook();
                            break;
                        }
                    case "10":
                        {
                            UserRepository.ChoiceAllUsers();
                            break;
                        }
                }
            }

        }    
    }
}