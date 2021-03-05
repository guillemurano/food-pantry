using System;

namespace FoodPantry.Models
{
  public class Users
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Phone { get; set; }
    public string DOB { get; set; }
    public string Race { get; set; }
    public long AddressId { get; set; }
  }
}
