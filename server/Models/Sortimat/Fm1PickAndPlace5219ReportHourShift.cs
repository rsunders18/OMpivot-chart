using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("FM1_PickAndPlace_5219_ReportHour_Shift", Schema = "App")]
  public partial class Fm1PickAndPlace5219ReportHourShift
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
    public string ExportDateStamp
    {
      get;
      set;
    }
    public string ExportTimeStamp
    {
      get;
      set;
    }
    public DateTime? DateHour
    {
      get;
      set;
    }
    public string ActualProduct
    {
      get;
      set;
    }
    public string MachineID
    {
      get;
      set;
    }
    public string Shift
    {
      get;
      set;
    }
    public double? ShiftTime
    {
      get;
      set;
    }
    public double? AutomaticTime
    {
      get;
      set;
    }
    public double? AlarmTime
    {
      get;
      set;
    }
    public double? StopTime
    {
      get;
      set;
    }
    public double? RestartTime
    {
      get;
      set;
    }
    public Int64? TotalCycles
    {
      get;
      set;
    }
    public Int64? TotalAlarms
    {
      get;
      set;
    }
    public Int64? GuardDoorOpened
    {
      get;
      set;
    }
    public Int64? AutomaticStarts
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
    public double? CleaningTime
    {
      get;
      set;
    }
    public double? MissingMaterialTime
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
    public Int64? ShiftTotalGood
    {
      get;
      set;
    }
    public Int64? ShiftTotalBad
    {
      get;
      set;
    }
    public Int64? ShiftPresetGoodParts
    {
      get;
      set;
    }
    public Int64? ShiftGoodPartsAssembled
    {
      get;
      set;
    }
    public Int64? ShiftPartsToAssemble
    {
      get;
      set;
    }
    public string StartShiftDate
    {
      get;
      set;
    }
    public string EndShiftDate
    {
      get;
      set;
    }
    public Int64? GoodPartsTrack1
    {
      get;
      set;
    }
    public Int64? BadPartsTrack1
    {
      get;
      set;
    }

    [Column("ShiftGood%")]
    public double? ShiftGood
    {
      get;
      set;
    }

    [Column("ShiftBad%")]
    public double? ShiftBad
    {
      get;
      set;
    }

    [Column("ShiftEfficiency%")]
    public double? ShiftEfficiency
    {
      get;
      set;
    }
    public Int64? ShiftTotal
    {
      get;
      set;
    }

    [Column("STN 3 : Bad Part Locking Pin Cap")]
    public int? STN3BadPartLockingPinCap
    {
      get;
      set;
    }

    [Column("STN 5 : Bad Part Spring")]
    public int? STN5BadPartSpring
    {
      get;
      set;
    }

    [Column("STN 11 : Bad Part Firing Button")]
    public int? STN11BadPartFiringButton
    {
      get;
      set;
    }

    [Column("STN 3 : CF1 3_1bB10 Locking Pin Cap Present")]
    public int? STN3CF13_1bB10LockingPinCapPresent
    {
      get;
      set;
    }

    [Column("STN 6 : CF2 6_1cB10 Spring Present")]
    public int? STN6CF26_1cB10SpringPresent
    {
      get;
      set;
    }

    [Column("STN 11 : CF3 11_1aB10 Firing Button Present")]
    public int? STN11CF311_1aB10FiringButtonPresent
    {
      get;
      set;
    }

    [Column("STN 11 : CF5 11_1aB11 Firing Button Type")]
    public int? STN11CF511_1aB11FiringButtonType
    {
      get;
      set;
    }
    public decimal? OEE_Availability
    {
      get;
      set;
    }
    public decimal? OEE_Performance
    {
      get;
      set;
    }
    public decimal? OEE_Quality
    {
      get;
      set;
    }
    public decimal? OEE_OEE
    {
      get;
      set;
    }
    public decimal? ShiftPercentComplete
    {
      get;
      set;
    }
    public double AutomaticTimeH
    {
      get;
      set;
    }
    public double AlarmTimeH
    {
      get;
      set;
    }
    public double StopTimeH
    {
      get;
      set;
    }
    public double RestartTimeH
    {
      get;
      set;
    }
    public Int64 TotalCyclesH
    {
      get;
      set;
    }
    public Int64 TotalAlarmsH
    {
      get;
      set;
    }
    public Int64 GuardDoorOpenedH
    {
      get;
      set;
    }
    public Int64 AutomaticStartsH
    {
      get;
      set;
    }
    public double LunchTimeH
    {
      get;
      set;
    }
    public double BreakTimeH
    {
      get;
      set;
    }
    public double CleaningTimeH
    {
      get;
      set;
    }
    public double MissingMaterialTimeH
    {
      get;
      set;
    }
    public double ChangeOverTimeH
    {
      get;
      set;
    }
    public double MaintenanceTimeH
    {
      get;
      set;
    }
    public Int64 ShiftTotalGoodH
    {
      get;
      set;
    }
    public Int64 ShiftTotalBadH
    {
      get;
      set;
    }

    [Column("ShiftGood%H")]
    public double ShiftGoodH
    {
      get;
      set;
    }

    [Column("ShiftBad%H")]
    public double ShiftBadH
    {
      get;
      set;
    }

    [Column("ShiftEfficiency%H")]
    public double ShiftEfficiencyH
    {
      get;
      set;
    }
    public Int64 ShiftTotalH
    {
      get;
      set;
    }

    [Column("STN 3 : Bad Part Locking Pin CapH")]
    public int STN3BadPartLockingPinCapH
    {
      get;
      set;
    }

    [Column("STN 5 : Bad Part SpringH")]
    public int STN5BadPartSpringH
    {
      get;
      set;
    }

    [Column("STN 11 : Bad Part Firing ButtonH")]
    public int STN11BadPartFiringButtonH
    {
      get;
      set;
    }

    [Column("STN 3 : CF1 3_1bB10 Locking Pin Cap PresentH")]
    public int STN3CF13_1bB10LockingPinCapPresentH
    {
      get;
      set;
    }

    [Column("STN 6 : CF2 6_1cB10 Spring PresentH")]
    public int STN6CF26_1cB10SpringPresentH
    {
      get;
      set;
    }

    [Column("STN 11 : CF3 11_1aB10 Firing Button PresentH")]
    public int STN11CF311_1aB10FiringButtonPresentH
    {
      get;
      set;
    }

    [Column("STN 11 : CF5 11_1aB11 Firing Button TypeH")]
    public int STN11CF511_1aB11FiringButtonTypeH
    {
      get;
      set;
    }
  }
}
