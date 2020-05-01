using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("DailyProductionShift", Schema = "App")]
  public partial class AppDailyProductionShift
  {
    [Key]
    public DateTime Date
    {
      get;
      set;
    }
    public string DayName
    {
      get;
      set;
    }
    public string ShiftName
    {
      get;
      set;
    }
    public string DayShift
    {
      get;
      set;
    }
    public string DayOfWeekUK
    {
      get;
      set;
    }
    public string BatchID
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
    public string Shift
    {
      get;
      set;
    }
    public string WeekRange
    {
      get;
      set;
    }
    public double Rejects
    {
      get;
      set;
    }
    public double GoodDevices
    {
      get;
      set;
    }
    public decimal ActualYield
    {
      get;
      set;
    }
    public double PcsPerHour
    {
      get;
      set;
    }
    public decimal TargetAt70Percent10080
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
    public string WeekDay
    {
      get;
      set;
    }
  }
}
