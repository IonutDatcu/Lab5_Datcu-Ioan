using System;
using Lab5_DatcuIoan.Data;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab5_Datcu;

namespace Lab5_Datcu_Ioan
{
    public partial class App : Application
    {
        static AgendaDatabase database;
        public static AgendaDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   AgendaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new AgendaPage());
        }
    }
}