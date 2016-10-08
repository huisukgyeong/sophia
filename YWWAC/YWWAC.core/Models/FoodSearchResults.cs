using Newtonsoft.Json;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Models
{
    public class FoodSearchResults
    {
        [PrimaryKey, AutoIncrement]
        public int resultId { get; set; }
        [JsonProperty("_index")]
        public string Index { get; set; }
        [JsonProperty("_type")]
        public string Type { get; set; }
        [JsonProperty("_id")]
        public string Id { get; set; }
        [JsonProperty("_score")]
        public double Score { get; set; }
        public Fields fields { get; set; }
        public class Fields
        {
            public string item_id { get; set; }
            [JsonProperty("item_name")]
            public string ItemName { get; set; }
            public string brand_id { get; set; }
            [JsonProperty("brand_name")]
            public string BrandName { get; set; }
            public string nf_serving_size_qty { get; set; }
            public string nf_serving_size_unit { get; set; }
        }
    }
}
