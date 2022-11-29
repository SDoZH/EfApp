
using System;
using System.Collections.Generic;
using System.Text;

namespace EfApp.Views
{
    public class MainView
    {
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выберете тип работы с БД");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("Редактирование информации (нажмите 1)");
            Console.WriteLine("Получение информации по книгам и пользователям (нажмите 2)");
            Console.WriteLine();
            Console.WriteLine("Создание таблиц и добавление информации (нажмите 3) (служебная)");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        UserAndBookDataUpdateView.DataUpdate();
                        break;
                    }

                case "2":
                    {
                        UserAndBookInfoView.Info();
                        break;
                    }

                case "3":
                    {
                        AddBaseView.AddInfo();
                        break;
                    }
            }
        }
    }
}