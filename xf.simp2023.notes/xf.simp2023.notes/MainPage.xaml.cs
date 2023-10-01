using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace xf.simp2023.notes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //btnLogIn.Clicked += Button_Clicked;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Message", $"Bienvenido usuario {entryUser.Text}", "Ok");
        }
    }
}

