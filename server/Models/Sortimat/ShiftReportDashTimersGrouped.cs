using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("ShiftReportDashTimersGrouped", Schema = "App")]
  public partial class ShiftReportDashTimersGrouped
  {
    [Key]
    public int? MachineID
    {
      get;
      set;
    }
    public string BatchID
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string Shift
    {
      get;
      set;
    }
    public string TagName
    {
      get;
      set;
    }
    public double? Value
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string ValueChar
    {
      get;
      set;
    }
  }
}
