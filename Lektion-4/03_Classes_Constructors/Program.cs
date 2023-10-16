using _03_Classes_Constructors.Models;

var customer_1 = new Customer()
{
    Id = 1,
    Name = "Emanuel",
    Email = "Emanuel@gmail.com",
    PhoneNumber = "1234567890",
};

var customer_2 = new Customer()
{
    Id = 2,
    Name = "Emanuel",
    Email = "HEj@gmail.com",
    PhoneNumber = "1234567890",
};
customer_1.Id = 2;
customer_1.Name = "Emanuel";
customer_1.Email = "Emanuel@gmail.com";


var customer_3 = new Customer("Emanuel0", "Min@Mail.com");

var c4 = new Customer();