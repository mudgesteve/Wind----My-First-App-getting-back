using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind
{
    public class FavoritesCollection : ObservableCollection<FavoriteInformation>
    {
        public async Task AddAsync(FavoriteInformation article)
        {

            var favorite = new Favorite()
            {
                ArticleDate = article.ArticleDate,
                Description = article.Description,
                ImageUrl = article.ImageUrl,
                Title = article.Title,
            };

            await FavoritesManager.DefaultManager.SaveFavoriteAsync(favorite);
            
            this.Add(article);
        }
    }

    public class FavoriteInformation : Common.ObservableBase
    {
        private int _id;
        public int Id
        {
            get { return this._id; }
            set { this.SetProperty(ref this._id, value); }
        }

        private string _title;
        public string Title
        {
            get { return this._title; }
            set { this.SetProperty(ref this._title, value); }
        }

        private string _categoryTitle;
        public string CategoryTitle
        {
            get { return this._categoryTitle; }
            set { this.SetProperty(ref this._categoryTitle, value); }
        }

        private string _description;
        public string Description
        {
            get { return this._description; }
            set { this.SetProperty(ref this._description, value); }
        }

        private string _imageUrl;
        public string ImageUrl
        {
            get { return this._imageUrl; }
            set { this.SetProperty(ref this._imageUrl, value); }
        }

        private DateTime _articleDate;
        public DateTime ArticleDate
        {
            get { return this._articleDate; }
            set { this.SetProperty(ref this._articleDate, value); }
        }

        
    }
}
