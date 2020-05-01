using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("ShiftHourReport", Schema = "App")]
  public partial class ShiftHourReport
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
    public int MachineID
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
    public DateTime? ShiftETA
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
    public decimal? ShiftCompletedPercent
    {
      get;
      set;
    }
    public double? ShiftTotal
    {
      get;
      set;
    }
    public double? ShiftTotalBad
    {
      get;
      set;
    }
    public double? ShiftTotalGood
    {
      get;
      set;
    }
    public double? ShiftGoodPercent
    {
      get;
      set;
    }
    public double? RejectRate
    {
      get;
      set;
    }
    public double? ShiftBadPercent
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
    public decimal? ShiftEfficiencyPercent
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
    public decimal? ShiftPercentCompletedH
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
    public double? ShiftTotalH
    {
      get;
      set;
    }
    public double? ShiftTotalBadH
    {
      get;
      set;
    }
    public double? ShiftTotalGoodH
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
