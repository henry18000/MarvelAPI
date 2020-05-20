using MarvelAPI.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarvelAPI
{
    public partial class App : Application
    {
        public static MarvelManager MarvelManager1 { get; private set; }
        public App()
        {
            InitializeComponent();
            MarvelManager1 = new MarvelManager(new RestService());

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
