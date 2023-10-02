using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using xf.simp2023.notes.Helpers;
using xf.simp2023.notes.Models;
using xf.simp2023.notes.Services;

namespace xf.simp2023.notes.ViewModels
{
    public class NewsViewModel : ViewModelBase
    {
        public NewsViewModel()
        {
            _ = Initialialize();
        }

        private ObservableCollection<FeedNew> _FeedNews;
        public ObservableCollection<FeedNew> FeedNews
        {
            get => _FeedNews;
            set
            {
                _FeedNews = value;
                OnPropertyChanged();
            }
        }

        private FeedNew _MainFeedNew;
        public FeedNew MainFeedNew
        {
            get => _MainFeedNew;
            set
            {
                _MainFeedNew = value;
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

        private async Task Initialialize()
        {
            try
            {
                IsBusy = true;
                RSSService rSSService = new RSSService();
                var resultList = await rSSService.GetNews();

                MainFeedNew = resultList.FirstOrDefault();
                FeedNews = new ObservableCollection<FeedNew>(resultList.GetRange(1, resultList.Count - 1));
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}

