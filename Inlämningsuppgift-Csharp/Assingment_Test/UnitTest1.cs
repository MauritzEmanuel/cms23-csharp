using Assingment.Models;
using Assingment.Services;
using Xunit;

namespace Assingment_Test
{
    public class UnitTest1
    {
        [Fact]
        public void CreateCustomer_ShouldAddCustomerToCustomerList()
        {
            // Arrange
            CustomerService _customerService = new CustomerService();
            Customer customer = new Customer();

            // Act
            _customerService.CreateCustomer(customer); // Här skapas en ny kund

            // Assert
            Assert.Contains(customer, _customerService.GetCustomerList()); // Kontrollera om den nya kunden har lagts till i kundlistan
        }
    }
}