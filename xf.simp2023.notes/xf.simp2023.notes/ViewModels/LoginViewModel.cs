using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using xf.simp2023.notes.Helpers;
using xf.simp2023.notes.Services;
using xf.simp2023.notes.Views;

namespace xf.simp2023.notes.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel()
        {
            OnLoginCommand = new Command(OnLogin);
        }

        private string _User;
        public string User
        {
            get => _User;
            set
            {
                _User = value;
                OnPropertyChanged();
            }
        }

        private string _Password;
        public string Password
        {
            get => _Password;
            set
            {
                _Password = value;
                OnPropertyChanged();
            }
        }

        private bool _IsBusy;
        public bool IsBusy
        {
            get => _IsBusy;
            set
            {
                _IsBusy = value;
                OnPropertyChanged();
            }
        }

        public ICommand OnLoginCommand { get; set; }

        private void OnLogin(object obj)
        {
            _ = ExecuteMethod();
        }

        private async Task ExecuteMethod()
        {
            try
            {
                IsBusy = true;
                //await Task.Delay(5000);
                //await App.Current.MainPage.DisplayAlert("Message", $"Bienvenido usuario {User}", "Ok");
                await App.Current.MainPage.Navigation.PushAsync(new NewsPage());
                IsBusy = false;
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}

