using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QR_Code_Scanner
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new QRScanner();
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
