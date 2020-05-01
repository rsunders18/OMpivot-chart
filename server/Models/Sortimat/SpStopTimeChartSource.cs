using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("sp_StopTimeChartSource", Schema = "App")]
  public partial class SpStopTimeChartSource
  {
    public string BatchID
    {
      get;
      set;
    }
    [Key]
    public int MachineID
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
    public double? TotalStopTime
    {
      get;
      set;
    }
    public decimal? PercentageStopTime
    {
      get;
      set;
    }
  }
}
