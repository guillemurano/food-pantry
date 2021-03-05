using System;

namespace FoodPantry.Models
{
  public class FamilyGroup : EntityBase
  {
    public long UserId { get; set; }
    public long AddressId { get; set; }
    public int AdultCount { get; set; }
    public int ChildrenCount { get; set; }
    public int ElderCount { get; set; }
    public int InfantCount { get; set; }
  }
}
