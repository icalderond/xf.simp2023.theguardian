using System;
using System.Collections.Generic;

using Xamarin.Forms;
using xf.simp2023.notes.ViewModels;

namespace xf.simp2023.notes.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}

