using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xf.simp2023.notes.Views;

namespace xf.simp2023.notes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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

