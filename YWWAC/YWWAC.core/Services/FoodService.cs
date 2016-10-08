using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Models;

namespace YWWAC.core.Services
{
    class FoodService
    {
        public async Task<List<FoodSearchResults>> GetFoods(string searchTerm)
        {
            WebRequest request = WebRequest.CreateHttp(String.Format("{0}{1}?results=0:5&appId={2}&appKey={3}",
                FoodApp.SearchEndpoint,
                WebUtility.HtmlEncode(searchTerm),
                FoodApp.AppId,
                FoodApp.ApiKey));
            string responseValue = null;
            using (var response = await request.GetResponseAsync())
            {
                using (var stream = response.GetResponseStream())
                {
                    if (stream != null)
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            responseValue = await reader.ReadToEndAsync();
                        }
                    }
                }
            }
            var hitsReponse = JObject.Parse(responseValue).SelectToken("hits").ToString();
            var sresponse = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FoodSearchResults>>(hitsReponse);
            if (sresponse != null)
            {
                return sresponse;
            }
            else
            {
                return null;
            }
        }
        public async Task<Nutrition> GetNutrition(string foodId)
        {
            WebRequest request = WebRequest.CreateHttp(String.Format("{0}?id={1}&appId={2}&appKey={3}",
                FoodApp.NutritionEndpoint,
                WebUtility.HtmlEncode(foodId),
                FoodApp.AppId,
                FoodApp.ApiKey));
            string responseValue = null;
            using (var response = await request.GetResponseAsync())
            {
                using (var stream = response.GetResponseStream())
                {
                    if (stream != null)
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            responseValue = await reader.ReadToEndAsync();
                        }
                    }
                }
            }
            Debug.WriteLine(responseValue);
            var sresponse = Newtonsoft.Json.JsonConvert.DeserializeObject<Nutrition>(responseValue);
            if (sresponse != null)
            {
                return sresponse;
            }
            else
            {
                return null;
            }
        }
    }
}
