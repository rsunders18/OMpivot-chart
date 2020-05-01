using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("DailyProductionShift", Schema = "dbo")]
  public partial class DailyProductionShift
  {
    [Key]
    public string Machine
    {
      get;
      set;
    }
    public int MachineID
    {
      get;
      set;
    }
    public string Shift
    {
      get;
      set;
    }
    public string Shiftc
    {
      get;
      set;
    }
    public double? Rejects
    {
      get;
      set;
    }
    public double? GoodDevices
    {
      get;
      set;
    }
    public decimal? ActualYield
    {
      get;
      set;
    }
    public double? PcsPerHour
    {
      get;
      set;
    }
    public decimal? TargetAt70Percent10080
    {
      get;
      set;
    }
    public string DownTime
    {
      get;
      set;
    }
    public string MachineAutoStop
    {
      get;
      set;
    }
    public string StopTime
    {
      get;
      set;
    }
    public string CleaningTime
    {
      get;
      set;
    }
    public string LunchTime
    {
      get;
      set;
    }
    public string BreakTime
    {
      get;
      set;
    }
    public string ChangeOverTime
    {
      get;
      set;
    }
    public string MaintenanceTime
    {
      get;
      set;
    }
    public string MissingMaterialTime
    {
      get;
      set;
    }
  }
}
