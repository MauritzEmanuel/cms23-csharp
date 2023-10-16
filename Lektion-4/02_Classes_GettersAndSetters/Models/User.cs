using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

namespace _02_Classes_GettersAndSetters.Models;

internal class User
{
    private string email;

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get => email; set => email = value.ToLower(); }
    public byte[] Password { get; private set; }
    public byte[] SecurityKey { get; private set; } 

    public void SetSecurePassword(string password)
    {
        using var hmac = new HMACSHA512();
        Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }
}
