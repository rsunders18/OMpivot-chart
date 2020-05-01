using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("BatchReportDashTimersGrouped", Schema = "App")]
  public partial class BatchReportDashTimersGrouped
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
