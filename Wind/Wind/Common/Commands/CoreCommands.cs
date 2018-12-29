using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wind.Common.Commands
{
    
    public class ToggleFavoriteCommand : ICommand
    {
        private bool _isBusy = false;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return !_isBusy;
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public void Execute(object parameter)
        {
            ToggleFavoriteAsync(parameter as News.NewsInformation);
        }

        private async void ToggleFavoriteAsync(News.NewsInformation article)
        {
            this._isBusy = true;
            this.RaiseCanExecuteChanged();
            App.ViewModels.IsBusy = true;

            await App.ViewModels.Favorites.AddAsync(await article.AsFavorite("Technology"));

            this._isBusy = false;
            this.RaiseCanExecuteChanged();
            App.ViewModels.IsBusy = false;

        }
    }

    public class SpeakCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public void Execute(object parameter)
        {
            Helpers.GeneralHelper.Speak((string)parameter);
        }
    }

    public class NavigateToDetailCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public void Execute(object parameter)
        {
            var newsInformation = parameter as News.NewsInformation;

            if (newsInformation == null)
            {
                NavigateToDetailAsync(parameter as FavoriteInformation);
            }
            else
            {
                NavigateToDetailAsync(newsInformation);
            }
        }

        private async void NavigateToDetailAsync(News.NewsInformation article)
        {
            await App.MainNavigation.PushAsync(new Pages.ItemDetailPage(article), true);
        }

        private async void NavigateToDetailAsync(FavoriteInformation article)
        {
            await App.MainNavigation.PushAsync(new Pages.ItemDetailPage(article), true);
        }
    }

    public class RefreshNewsCommand : ICommand
    {
        private bool _isBusy = false;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return !_isBusy;
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public void Execute(object parameter)
        {
            RefreshNewsAsync((string)parameter);
        }

        private async void RefreshNewsAsync(string newsType)
        {
            this._isBusy = true;
            this.RaiseCanExecuteChanged();
            App.ViewModels.IsBusy = true;

            switch (newsType)
            {
                case "Search":
                    await App.ViewModels.RefreshSearchResults();
                    break;
                case "Technology":
                    await App.ViewModels.RefreshTechnologyNewsAsync();
                    break;
                case "Trending":
                    await App.ViewModels.RefreshTrendingNewsAsync();
                    break;                
            }

            this._isBusy = false;
            this.RaiseCanExecuteChanged();
            App.ViewModels.IsBusy = false;

        }
    }

    public class NavigateToSettingsCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public void Execute(object parameter)
        {
            NavigateAsync();
        }

        private async void NavigateAsync()
        {
            await App.MainNavigation.PushAsync(new Pages.SettingsPage(), true);
        }
    }

}
