using System;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using SQLite;

namespace Wind
{
    public class Favorite
    {
        string id;
        string categoryId;
        string title;
        string description;
        string imageUrl;
        DateTime articleDate;

        [JsonProperty(PropertyName = "id")]
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        [JsonProperty(PropertyName = "title")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        [JsonProperty(PropertyName = "categoryId")]
        public string CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

      

        [JsonProperty(PropertyName = "description")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }

        [JsonProperty(PropertyName = "articleDate")]
        public DateTime ArticleDate
        {
            get { return articleDate; }
            set { articleDate = value; }
        }

        [Version]
        public string Version { get; set; }
    }

    //public class Favorite
    //{
    //    [PrimaryKey, AutoIncrement]
    //    public int Id { get; set; }

    //    [Ignore]
    //    public NewsCategory Category { get; set; }
    //    public int CategoryId { get; set; }

    //    [MaxLength(64)]
    //    public string Title { get; set; }
    //    public string Description { get; set; }
    //    public string ImageUrl { get; set; }
    //    public DateTime ArticleDate { get; set; }
    //}

    //public class NewsCategory
    //{
    //    [PrimaryKey, AutoIncrement]
    //    public int Id { get; set; }
    //    public string Title { get; set; }

    //    [Ignore]
    //    public string InternalName { get; set; }
    //}

}
