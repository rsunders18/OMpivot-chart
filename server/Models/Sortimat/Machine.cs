using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("Machine", Schema = "Dim")]
  public partial class Machine
  {
    [Key]
    public int MachineID
    {
      get;
      set;
    }
    public double? CycleSpeed
    {
      get;
      set;
    }
    public int? PartsPerMinute
    {
      get;
      set;
    }
    public int? ShiftTarget70Percent
    {
      get;
      set;
    }
    public int? ShiftTarget100Percent
    {
      get;
      set;
    }
    public int? BatchTarget70Percent
    {
      get;
      set;
    }
    public int? BatchTarget100Percent
    {
      get;
      set;
    }

    [Column("Machine")]
    public string Machine1
    {
      get;
      set;
    }
    public string Description
    {
      get;
      set;
    }
    public DateTime? CreatedOn
    {
      get;
      set;
    }
  }
}
