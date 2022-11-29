using EfApp.Models;
using Microsoft.EntityFrameworkCore;
using EfApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfApp
{

    class Program
    {
        public static MainView mainView;
        public static UserAndBookDataUpdateView userandbookdataupdateview;
        public static UserAndBookInfoView userandbookinfoview;
        public static AddBaseView addbaseview;
        public static void Main(string[] args)
        {
            mainView = new MainView();
            userandbookdataupdateview = new UserAndBookDataUpdateView();
            userandbookinfoview = new UserAndBookInfoView();
            
            while (true)
            {
                mainView.Show();
            }
        }
    }
}
