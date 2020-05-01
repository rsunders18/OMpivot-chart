using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("FM1_PickAndPlace_5219_PerShift_PerCycle", Schema = "dbo")]
  public partial class Fm1PickAndPlace5219PerShiftPerCycle
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
    public double? ShiftTime
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
    public double? OEE_Availability
    {
      get;
      set;
    }
    public double? OEE_Performance
    {
      get;
      set;
    }
    public double? OEE_Quality
    {
      get;
      set;
    }
    public double? OEE_OEE
    {
      get;
      set;
    }
    public double? ShiftPercentComplete
    {
      get;
      set;
    }
  }
}
