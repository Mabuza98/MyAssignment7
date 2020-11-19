using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyWhatsAppStatusSaver
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StatusSaverMasterDetailPage();
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
