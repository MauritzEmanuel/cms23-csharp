using _02_Classes_GettersAndSetters.Models;
using System.Text;

var customer = new Customer();

//set - sätt ett värde
customer.FirstName = "Jöns ";
customer.LastName = "Jacob";

//get - hämta värdet
var firstname = customer.FirstName;


var user = new User();
user.FirstName = "Jöns";
user.LastName = "Jacob";
user.Email = "Jöns.Jacob@hotmail.com";

user.SetSecurePassword("Currysås123");
var password = Encoding.UTF8.GetString(user.Password);
Console.WriteLine($"Password: {password}");

