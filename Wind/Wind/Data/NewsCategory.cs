using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Data
{
    public class NewsCategory
    {
        [PrimaryKey, AutoIncrement]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [Ignore]
        [JsonProperty(PropertyName = "InternalName")]
        public string InternalName { get; set; }
    }
}
