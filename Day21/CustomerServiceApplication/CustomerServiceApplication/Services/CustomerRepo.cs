using CustomerServiceApplication.Models;
using Newtonsoft.Json;
using System.Text;

namespace CustomerServiceApplication.Services
{
    public class CustomerRepo : IRepo<int, Customer>
    {
        private readonly HttpClient _httpClient;

        public CustomerRepo()
        {
            _httpClient = new HttpClient();
           
        }
        public async Task<Customer> Add(Customer item)
        {
            using (_httpClient)
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json");
                using(var response = await _httpClient.PostAsync("http://localhost:5070/api/Customer", content))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var customer = JsonConvert.DeserializeObject<Customer>(responseText);
                        return customer;
                    }
                }
            }
            return null;
        }

        public Customer Delete(int key)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync("http://localhost:5070/api/Customer"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string responseText = await response.Content.ReadAsStringAsync();
                        var customers = JsonConvert.DeserializeObject<List<Customer>>(responseText);
                        return customers.ToList();
                    }
                }
            }
            return null;
        }

        public Customer Update(Customer item)
        {
            throw new NotImplementedException();
        }

       
    }
}
