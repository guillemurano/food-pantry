using System;

namespace FoodPantry.Models
{
  public class Pantry
  {
    public string Name { get; set; }
    public long AddressId { get; set; }
    public string Phone { get; set; }
    public string ServeZip { get; set; }
    public long OwnerId { get; set; }
  }
}
