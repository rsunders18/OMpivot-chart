using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("sp_BatchList", Schema = "App")]
  public partial class SpBatchList
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
    public DateTime? BatchStartDate
    {
      get;
      set;
    }
    public DateTime? BatchEndDate
    {
      get;
      set;
    }
    public int? LastRowID
    {
      get;
      set;
    }
    public decimal? BatchCompletedPercent
    {
      get;
      set;
    }
    public double? BatchTotalGood
    {
      get;
      set;
    }
  }
}
