using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Task01.Data;

namespace Task01
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Batteries.Init();

            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated(); 
            }

            var login = new View.LoginWindow();
            login.Show();
        }
    }
}
