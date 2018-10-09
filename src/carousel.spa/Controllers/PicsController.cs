namespace carousel.spa.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using carousel.spa.Models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class PicsController
    {
        public async Task<List<Image>> Get() 
        {
            var httpClient = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://www.reddit.com/r/pics.json");


            var response = await httpClient.SendAsync(request);

            var data = await response.Content.ReadAsAsync(typeof(RedditWrapper)) as RedditWrapper;

            var result = new List<Image>();

            foreach(var item  in data.Data.Children.Where(c => c.Data.Preview != null)) {
                result.Add(new Image{
                    Title = item.Data.Title,
                    ImageSrc = item.Data.Preview.Images.FirstOrDefault()?.Source.Url
                });
            }

            return result;
        }
    }
}