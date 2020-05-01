using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("FM2_Assembly_5306_Shift", Schema = "Abbvie")]
  public partial class Fm2Assembly5306Shift
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
    public string ActualProduct
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
    public Int64? ShiftGoodPartsAssemble
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

    [Column("STN 13- 1: Bad Parts Button / Pin / Spring")]
    public int? STN131BadPartsButtonPinSpring
    {
      get;
      set;
    }

    [Column("STN 15- 1: Bad Parts Firing Body")]
    public int? STN151BadPartsFiringBody
    {
      get;
      set;
    }

    [Column("STN 17- 1: Bad Parts Print")]
    public int? STN171BadPartsPrint
    {
      get;
      set;
    }

    [Column("STN 18- 1: Bad Parts Firing Button/Pin")]
    public int? STN181BadPartsFiringButtonPin
    {
      get;
      set;
    }

    [Column("STN 19- 1: Bad Parts Spring")]
    public int? STN191BadPartsSpring
    {
      get;
      set;
    }

    [Column("STN 21- 1: Bad Parts Plunger Retained")]
    public int? STN211BadPartsPlungerRetained
    {
      get;
      set;
    }

    [Column("STN 22- 1: Bad Parts Pin Cap")]
    public int? STN221BadPartsPinCap
    {
      get;
      set;
    }

    [Column("STN 23- 1: Bad Parts Plunger")]
    public int? STN231BadPartsPlunger
    {
      get;
      set;
    }

    [Column("STN 13 : CF1 13_1aB10 Firing Button Present")]
    public int? STN13CF113_1aB10FiringButtonPresent
    {
      get;
      set;
    }

    [Column("STN 13 : CF2 13_1aB11 Firing Button Height")]
    public int? STN13CF213_1aB11FiringButtonHeight
    {
      get;
      set;
    }

    [Column("STN 13 : CF3 13_1bB10 Firing Pin Present")]
    public int? STN13CF313_1bB10FiringPinPresent
    {
      get;
      set;
    }

    [Column("STN 13 : CF4 13_1bB11 Firing Pin Straight")]
    public int? STN13CF413_1bB11FiringPinStraight
    {
      get;
      set;
    }

    [Column("STN 13 : CF5 13_1cB10 Spring Present")]
    public int? STN13CF513_1cB10SpringPresent
    {
      get;
      set;
    }

    [Column("STN 15 : CF6 15_1aB10 Firing Body Present")]
    public int? STN15CF615_1aB10FiringBodyPresent
    {
      get;
      set;
    }

    [Column("STN 15 : CF7 15_1aB11 Firing Body Height")]
    public int? STN15CF715_1aB11FiringBodyHeight
    {
      get;
      set;
    }

    [Column("STN 17 : CF8 17_1aB12 Print Present")]
    public int? STN17CF817_1aB12PrintPresent
    {
      get;
      set;
    }

    [Column("STN 18 : CF14 18_1bA10 Firing Button/Pin")]
    public int? STN18CF1418_1bA10FiringButtonPin
    {
      get;
      set;
    }

    [Column("STN 19 : CF9 19_1bB10 Spring Present")]
    public int? STN19CF919_1bB10SpringPresent
    {
      get;
      set;
    }

    [Column("STN 21 : CF10 Plunger Insertion Complete")]
    public int? STN21CF10PlungerInsertionComplete
    {
      get;
      set;
    }

    [Column("STN 21 : CF12 21_1bA70g Plunger Retained")]
    public int? STN21CF1221_1bA70gPlungerRetained
    {
      get;
      set;
    }

    [Column("STN 22 : CF11 22_1bA70 Pin Cap Seated")]
    public int? STN22CF1122_1bA70PinCapSeated
    {
      get;
      set;
    }

    [Column("STN 22 : CF15 22_1bB10&#34; Plunger Present")]
    public int? STN22CF1522_1bB10PlungerPresent
    {
      get;
      set;
    }

    [Column("STN 23 : CF13 23_1bB10 Plunger Present")]
    public int? STN23CF1323_1bB10PlungerPresent
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
  }
}
