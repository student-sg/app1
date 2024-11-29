using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using smartstick1.Models;

namespace smartstick1.Services
{
    class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://yourapiurl.com/");
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            var response = await _httpClient.PostAsJsonAsync("api/login", new { username, password });

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<User>();
            }

            return null;
        }

        public async Task<bool> RegisterAsync(User user)
        {
            var response = await _httpClient.PostAsJsonAsync("api/register", user);
            return response.IsSuccessStatusCode;
        }
    }

}
