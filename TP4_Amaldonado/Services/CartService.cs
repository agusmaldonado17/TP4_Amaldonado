using System.Net.Http.Json;
using TP4_Amaldonado.Models;

namespace TP4_Amaldonado.Services
{
    public class CartService
    {
        private readonly HttpClient _httpClient;

        public CartService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Cart>> GetCartsAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<CartResponse>("carts");
                return response?.Carts ?? new List<Cart>();
            }
            catch
            {
                return new List<Cart>();
            }
        }

        public async Task<Cart?> GetCartByIdAsync(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<Cart>($"carts/{id}");
            }
            catch
            {
                return null;
            }
        }

        public async Task<Cart?> CreateCartAsync(CartRequest cartRequest)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("carts/add", cartRequest);

                if (!response.IsSuccessStatusCode)
                    return null;

                return await response.Content.ReadFromJsonAsync<Cart>();
            }
            catch
            {
                return null;
            }
        }

        public async Task<Cart?> UpdateCartAsync(int id, CartRequest cartRequest)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"carts/{id}", cartRequest);

                if (!response.IsSuccessStatusCode)
                    return null;

                return await response.Content.ReadFromJsonAsync<Cart>();
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> DeleteCartAsync(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"carts/{id}");
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}