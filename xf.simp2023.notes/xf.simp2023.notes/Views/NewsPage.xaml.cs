using Xamarin.Forms;
using xf.simp2023.notes.ViewModels;

namespace xf.simp2023.notes.Views
{
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
            this.BindingContext = new NewsViewModel();
        }
    }
}