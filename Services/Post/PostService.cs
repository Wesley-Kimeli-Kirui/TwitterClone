using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TwitterClone.Models;

namespace TwitterClone.Services.Post
{
    public class PostService : IPost
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://jsonplaceholder.typicode.com/posts";
        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UserPosts>> GetPosts()
        {
            var res = await _httpClient.GetAsync(_baseUrl);
            var response = await res.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<UserPosts>>(response.ToString());

            if (result != null)
            {
                return result;
            }

            return new List<UserPosts>();
        }
    }
}