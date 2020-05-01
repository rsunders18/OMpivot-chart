using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("DashData", Schema = "App")]
  public partial class DashDatum
  {
    [Key]
    public int MachineID
    {
      get;
      set;
    }
    [Key]
    public int RowID
    {
      get;
      set;
    }
    public DateTime? CreatedOn
    {
      get;
      set;
    }
    public string Machine
    {
      get;
      set;
    }
    public string BatchID
    {
      get;
      set;
    }
    public DateTime? RecordedOnDate
    {
      get;
      set;
    }
    public int? RecordedOnHour
    {
      get;
      set;
    }
    public DateTime? DateHour
    {
      get;
      set;
    }
    public double? PlannedRunTime
    {
      get;
      set;
    }
    public double? ActualRunTime
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? BatchETA
    {
      get;
      set;
    }
    public decimal? BatchCompletedPercent
    {
      get;
      set;
    }
    public double? BatchTotal
    {
      get;
      set;
    }
    public double? BatchTotalBad
    {
      get;
      set;
    }
    public double? BatchTotalGood
    {
      get;
      set;
    }
    public double? BatchGoodPercent
    {
      get;
      set;
    }
    public double? RejectRate
    {
      get;
      set;
    }
    public double? BatchBadPercent
    {
      get;
      set;
    }
    public double? TotalCycles
    {
      get;
      set;
    }
    public decimal? Availability
    {
      get;
      set;
    }
    public decimal? Performance
    {
      get;
      set;
    }
    public decimal? Quality
    {
      get;
      set;
    }
    public decimal? OEE
    {
      get;
      set;
    }
    public double? TotalAlarms
    {
      get;
      set;
    }
    public double? GuardDoorOpened
    {
      get;
      set;
    }
    public double? AutomaticStarts
    {
      get;
      set;
    }
    public double? TotalStopTime
    {
      get;
      set;
    }
    public double? StopTime
    {
      get;
      set;
    }
    public double? AlarmTime
    {
      get;
      set;
    }
    public double? CleaningTime
    {
      get;
      set;
    }
    public double? LunchTime
    {
      get;
      set;
    }
    public double? BreakTime
    {
      get;
      set;
    }
    public double? ChangeOverTime
    {
      get;
      set;
    }
    public double? MaintenanceTime
    {
      get;
      set;
    }
    public double? MissingMaterialTime
    {
      get;
      set;
    }
    public double? RestartTime
    {
      get;
      set;
    }
    public decimal? BatchPercentCompletedH
    {
      get;
      set;
    }
    public double? PlannedRunTimeH
    {
      get;
      set;
    }
    public double? ActualRunTimeH
    {
      get;
      set;
    }
    public double? BatchTotalH
    {
      get;
      set;
    }
    public double? BatchTotalBadH
    {
      get;
      set;
    }
    public double? BatchTotalGoodH
    {
      get;
      set;
    }
    public double? TotalAlarmsH
    {
      get;
      set;
    }
    public double? GuardDoorOpenedH
    {
      get;
      set;
    }
    public double? TotalStopTimeH
    {
      get;
      set;
    }
    public double? StopTimeH
    {
      get;
      set;
    }
    public double? AlarmTimeH
    {
      get;
      set;
    }
    public double? CleaningTimeH
    {
      get;
      set;
    }
    public double? LunchTimeH
    {
      get;
      set;
    }
    public double? BreakTimeH
    {
      get;
      set;
    }
    public double? ChangeOverTimeH
    {
      get;
      set;
    }
    public double? MaintenanceTimeH
    {
      get;
      set;
    }
    public double? MissingMaterialTimeH
    {
      get;
      set;
    }
    public double? RestartTimeH
    {
      get;
      set;
    }
  }
}
