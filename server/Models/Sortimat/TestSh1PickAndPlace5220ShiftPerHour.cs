using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("TestSH1_PickAndPlace_5220_Shift_PerHour", Schema = "dbo")]
  public partial class TestSh1PickAndPlace5220ShiftPerHour
  {
    [Key]
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
    public Int64? ShiftTotalGood2
    {
      get;
      set;
    }
    public Int64? ShiftTotalBad2
    {
      get;
      set;
    }
    public Int64? ShiftTotal
    {
      get;
      set;
    }

    [Column("STN 3 : Bad Part Locking SC Gasket (3_1aB10)")]
    public int? STN3BadPartLockingSCGasket3_1aB10
    {
      get;
      set;
    }

    [Column("STN 4 : Bad Part Syringe Carrier (4_1aB10)")]
    public int? STN4BadPartSyringeCarrier4_1aB10
    {
      get;
      set;
    }

    [Column("STN 6 : Bad Part Spring (6_1cB10)")]
    public int? STN6BadPartSpring6_1cB10
    {
      get;
      set;
    }

    [Column("STN 9 : Bad Part Syringe Housing (9_1bB10)")]
    public int? STN9BadPartSyringeHousing9_1bB10
    {
      get;
      set;
    }

    [Column("STN 5 : Bad part Spring Type")]
    public int? STN5BadpartSpringType
    {
      get;
      set;
    }

    [Column("STN 11 : Bad part Lockout Shroud Type")]
    public int? STN11BadpartLockoutShroudType
    {
      get;
      set;
    }

    [Column("STN 12 : Bad Part Shroud (12_1cB10)")]
    public int? STN12BadPartShroud12_1cB10
    {
      get;
      set;
    }

    [Column("STN 3 : CF1 3_1A70 SC Damper Gaskett")]
    public int? STN3CF13_1A70SCDamperGaskett
    {
      get;
      set;
    }

    [Column("STN 4 : CF2 4_1aA70 SC Tabs OK")]
    public int? STN4CF24_1aA70SCTabsOK
    {
      get;
      set;
    }

    [Column("STN 4 : CF11 4_1aA70 SC Type")]
    public int? STN4CF114_1aA70SCType
    {
      get;
      set;
    }

    [Column("STN 5 : CF12 5_1cA70 Spring Type")]
    public int? STN5CF125_1cA70SpringType
    {
      get;
      set;
    }

    [Column("STN 5 : CF13 5_1cA70 Spring Presence")]
    public int? STN5CF135_1cA70SpringPresence
    {
      get;
      set;
    }

    [Column("STN 6 : CF3 6_1cB10 Spring Presence")]
    public int? STN6CF36_1cB10SpringPresence
    {
      get;
      set;
    }

    [Column("STN 7 : CF9 7_1A70 Syringe Housing Roundness")]
    public int? STN7CF97_1A70SyringeHousingRoundness
    {
      get;
      set;
    }

    [Column("STN 9 : CF4 9_1bB10 Syringe Housing Presence")]
    public int? STN9CF49_1bB10SyringeHousingPresence
    {
      get;
      set;
    }

    [Column("STN 9 : CF5 9_1bB10/11 SH Orientation")]
    public int? STN9CF59_1bB1011SHOrientation
    {
      get;
      set;
    }

    [Column("STN 9 : CF6 9_1bB12 Syringe Housing Type")]
    public int? STN9CF69_1bB12SyringeHousingType
    {
      get;
      set;
    }

    [Column("STN 11 : CF10 11_1B7 Lockout Shroud Type")]
    public int? STN11CF1011_1B7LockoutShroudType
    {
      get;
      set;
    }

    [Column("STN 12 : CF7 12_1cB10 Shroud Presence")]
    public int? STN12CF712_1cB10ShroudPresence
    {
      get;
      set;
    }

    [Column("STN 12 : CF8 12_1aA70 LS Legs")]
    public int? STN12CF812_1aA70LSLegs
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
