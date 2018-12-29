using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using System;
using System.Linq;

namespace Wind.Data
{


    public class FavoritesDatabase
    {
        readonly SQLiteAsyncConnection database;

        public FavoritesDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);

            //database.DropTableAsync<Favorite>().Wait();
            database.DropTableAsync<NewsCategory>().Wait();

            database.CreateTableAsync<NewsCategory>().Wait();
            database.CreateTableAsync<Favorite>().Wait();
        }

        public Task<List<NewsCategory>> GetCategoriesAsync()
        {
            return database.Table<NewsCategory>().ToListAsync();
        }

        public Task<List<Favorite>> GetItemsAsync()
        {
            return database.Table<Favorite>().ToListAsync();
        }

        public async Task<List<Favorite>> GetItemsAsync(List<NewsCategory> categories)
        {
            var favorites = await database.Table<Favorite>().ToListAsync();

            foreach (var favorite in favorites)
            {
               // favorite.Category = categories.Where(w => w.Id == favorite.CategoryId).FirstOrDefault();
            }

            return favorites;
        }

        public Task<List<Favorite>> GetItemsByCategoryAsync(List<NewsCategory> categories)
        {
            if (categories != null && categories.Count > 0)
            {
                return database.QueryAsync<Favorite>($"SELECT * FROM [Favorite] WHERE [CategoryId] = {categories.FirstOrDefault().Id}");
            }
            else
            {
                return null;
            }

        }

        public Task<Favorite> GetItemAsync(string id)
        {
            return database.Table<Favorite>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<NewsCategory> GetCategoryAsync(string title)
        {
            return database.Table<NewsCategory>().Where(i => i.Title.Equals(title)).FirstOrDefaultAsync();
        }

        public Task<int> SaveCategoriesAsync(List<NewsCategory> categories)
        {
            return database.InsertAllAsync(categories);
        }

        public Task<int> SaveCategoryAsync(NewsCategory category)
        {
            if (category.Id != null)
            {
                return database.UpdateAsync(category);
            }
            else
            {
                return database.InsertAsync(category);
            }
        }

        public Task<int> SaveItemAsync(Favorite item)
        {
            if (item.Id != null)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Favorite item)
        {
            return database.DeleteAsync(item);
        }
    }
}
 