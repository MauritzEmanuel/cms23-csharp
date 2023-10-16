using _01_Classes.Models;

namespace _01_Classes.Service;

internal class CustomerService
{
    // service = 90% Methods

    //fields
    private List<Customer> _customerList;

    // Methods(propertyName)
    public void CreateCustomer(Customer customer) { }
    public void GetCustomer() { }
    public List<Customer> GetCustomers() 
    {
        return _customerList;
    }
    public void UpdateCustomer() { }
    public void DeleteCustomer() { }
}
