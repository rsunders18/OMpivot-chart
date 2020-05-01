using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("FM1_Assembly_5201_Batch", Schema = "Abbvie")]
  public partial class Fm1Assembly5201Batch
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
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime? BatchETA
    {
      get;
      set;
    }
    public double? BatchTime
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
    public Int64? BatchTotalGood
    {
      get;
      set;
    }
    public Int64? BatchTotalBad
    {
      get;
      set;
    }
    public Int64? BatchPresetGoodParts
    {
      get;
      set;
    }
    public Int64? BatchGoodPartsAssembled
    {
      get;
      set;
    }
    public Int64? BatchPartsToAssemble
    {
      get;
      set;
    }
    public string StartBatchDate
    {
      get;
      set;
    }
    public string EndBatchDate
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

    [Column("BatchGood%")]
    public double? BatchGood
    {
      get;
      set;
    }

    [Column("BatchBad%")]
    public double? BatchBad
    {
      get;
      set;
    }

    [Column("BatchEfficiency%")]
    public double? BatchEfficiency
    {
      get;
      set;
    }
    public Int64? BatchTotalGood2
    {
      get;
      set;
    }
    public Int64? BatchTotalBad2
    {
      get;
      set;
    }
    public Int64? BatchTotal
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

    [Column("STN 16- 1: Bad Parts Print")]
    public int? STN161BadPartsPrint
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

    [Column("STN 21- 1: Bad Parts Plunger Load")]
    public int? STN211BadPartsPlungerLoad
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

    [Column("STN 16 : CF8 16_1aB12 Print Present")]
    public int? STN16CF816_1aB12PrintPresent
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

    [Column("STN 21 : CF10 21A70_bG Plunger Load")]
    public int? STN21CF1021A70_bGPlungerLoad
    {
      get;
      set;
    }

    [Column("STN 21 : CF12 21_1bB12 Ld Cell Dn")]
    public int? STN21CF1221_1bB12LdCellDn
    {
      get;
      set;
    }

    [Column("STN 22 : CF11 22_1bB12 Pin Cap Height")]
    public int? STN22CF1122_1bB12PinCapHeight
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

    [Column("STN 18- 1: Bad Parts Firing Button/Firing Pin")]
    public int? STN181BadPartsFiringButtonFiringPin
    {
      get;
      set;
    }

    [Column("STN 24- 1: Bad Parts Assembly Wrong Type")]
    public int? STN241BadPartsAssemblyWrongType
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

    [Column("STN 24 : CF18 24_1A70 LPC Type")]
    public int? STN24CF1824_1A70LPCType
    {
      get;
      set;
    }

    [Column("STN 24 : CF20 24_1A70 Proper Assembly")]
    public int? STN24CF2024_1A70ProperAssembly
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
    public decimal? BatchPercentComplete
    {
      get;
      set;
    }
  }
}
