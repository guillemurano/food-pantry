using System;

public abstract class EntityBase
{
  public long Id { get; set; }
  public bool IsDeleted { get; set; }
  public string CreatedBy { get; set; }
  public DateTime CreatedDate { get; set; }
  public string UpdatedBy { get; set; }
  public DateTime UpdatedDate { get; set; }
}
