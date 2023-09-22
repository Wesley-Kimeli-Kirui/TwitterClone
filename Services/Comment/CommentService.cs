using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TwitterClone.Models;

namespace TwitterClone.Services.Comment
{
    public class CommentService : IComment
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://jsonplaceholder.typicode.com/comments";
        public CommentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<UserComments>> GetComments()
        {
            var res = await _httpClient.GetAsync(_baseUrl);
            var response = await res.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<UserComments>>(response.ToString());

            if (result != null)
            {
                return result;
            }

            return new List<UserComments>();
        }
    }
}