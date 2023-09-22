using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TwitterClone.Models;

namespace TwitterClone.Services.User
{
    public class UserService : IUser
    {
        private readonly HttpClient _httpClient;

        private readonly string _baseUrl = "https://jsonplaceholder.typicode.com/users";
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Users>> GetUsers()
        {
            var res = await _httpClient.GetAsync(_baseUrl);
            var response = await res.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Users>>(response.ToString());
            if (result != null)
            {
                return result;
            }
            return new List<Users>();
        }
    }
}