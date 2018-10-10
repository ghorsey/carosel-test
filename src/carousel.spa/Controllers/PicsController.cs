namespace carousel.spa.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using carousel.spa.Models;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json.Linq;

    [Route("api/[controller]")]
    public class PicsController
    {
        public async Task<List<Image>> Get()
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://www.reddit.com/r/pics.json");

            var response = await httpClient.SendAsync(request);

            var data = await response.Content.ReadAsAsync(typeof(JObject)) as JObject;

            var result = new List<Image>();

            foreach (var item in data["data"]["children"].Where(i => i["data"]["preview"] != null))
            {
                result.Add(new Image
                {
                    Title = (string)item["data"]["title"],
                    ImageSrc = (string)item["data"]["preview"]["images"][0]["source"]["url"]
                });
            }

            return result;
        }
    }
}