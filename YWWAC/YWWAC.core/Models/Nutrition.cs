using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YWWAC.core.Models
{
    public class Nutrition
    {
        public string item_id { get; set; }
        [JsonProperty("item_name")]
        public string ItemName { get; set; }
        public string brand_id { get; set; }
        public string brand_name { get; set; }
        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public double nf_calories { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_calories_from_fat { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_total_fat { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_saturated_fat { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_trans_fatty_acid { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_polyunsaturated_fat { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_monounsaturated_fat { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_cholesterol { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_sodium { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_total_carbohydrate { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_dietary_fiber { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_sugars { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_protein { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_vitamin_a_dv { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_vitamin_c_dv { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_calcium_dv { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_iron_dv { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_refuse_pct { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int nf_servings_per_container { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_serving_size_qty { get; set; }
        public string nf_serving_size_unit { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double nf_serving_weight_grams { get; set; }
    }
}
