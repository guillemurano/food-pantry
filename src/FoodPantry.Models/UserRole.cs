using System;

namespace FoodPantry.Models
{
  public class UserRole : EntityBase
  {
    public long UserId { get; set; }
    public long RoleId { get; set; }
  }
}
