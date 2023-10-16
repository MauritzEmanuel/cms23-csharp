using _02_SaveAndReadToFromFile.Models;
using Newtonsoft.Json;

namespace _02_SaveAndReadToFromFile.Services
{
    internal class CustomerService
    {
        private List<Customer> _customerList = new List<Customer>();
        public void AddToList(Customer customer)
        {
            _customerList.Add(customer);
            FileService.SaveToFile(JsonConvert.SerializeObject(_customerList));
        }

        public void GetCustomers()
        {
            var content = FileService.ReadFromFile();
            if (!string.IsNullOrEmpty(content))
                _customerList = JsonConvert.DeserializeObject<List<Customer>>(content)!;

            foreach (var customer in _customerList)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName} <{customer.Email}>");
            }
        }
    }
}
