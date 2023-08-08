using Notas_app.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notas_app
{
    public partial class App : Application
    {
        public static String Nome_DataBase;
        public static String DataBase;
        public App()
        {
            InitializeComponent();

            MainPage = new Principal();
        }
        public App(String Nome_DataBase, string DataBase)
        {
            InitializeComponent();
            App.Nome_DataBase = Nome_DataBase;
            App.DataBase = DataBase;

            MainPage = new Principal();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
