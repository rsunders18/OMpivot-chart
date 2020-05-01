using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("SH2_Assembly_5308_PerBatch_PerCycle", Schema = "dbo")]
  public partial class Sh2Assembly5308PerBatchPerCycle
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
    public Int64? BatchTotal
    {
      get;
      set;
    }

    [Column("STN 13- 1: Bad Parts Carrier/Housing/Shroud")]
    public int? STN131BadPartsCarrierHousingShroud
    {
      get;
      set;
    }

    [Column("STN 14- 1: Bad Parts Gripper Insertion")]
    public int? STN141BadPartsGripperInsertion
    {
      get;
      set;
    }

    [Column("STN 15- 1: Bad Parts Syringe Housing")]
    public int? STN151BadPartsSyringeHousing
    {
      get;
      set;
    }

    [Column("STN 17- 1: Bad Parts Insertiong")]
    public int? STN171BadPartsInsertiong
    {
      get;
      set;
    }

    [Column("STN 18- 1: Bad Parts Keyhole/Spring/Shroud")]
    public int? STN181BadPartsKeyholeSpringShroud
    {
      get;
      set;
    }

    [Column("STN 20- 1: Bad Parts Boot Remover")]
    public int? STN201BadPartsBootRemover
    {
      get;
      set;
    }

    [Column("STN 21- 1: Bad Parts Boot Remover")]
    public int? STN211BadPartsBootRemover
    {
      get;
      set;
    }

    [Column("STN 22- 1: Bad Parts Print")]
    public int? STN221BadPartsPrint
    {
      get;
      set;
    }

    [Column("STN 24- 1: Bad Parts SC Damper")]
    public int? STN241BadPartsSCDamper
    {
      get;
      set;
    }

    [Column("STN 13 : CF1 13_1aB10 Syringe Carrier Presence")]
    public int? STN13CF113_1aB10SyringeCarrierPresence
    {
      get;
      set;
    }

    [Column("STN 13 : CF5 13_1bB10 Syringe Housing Presenc")]
    public int? STN13CF513_1bB10SyringeHousingPresenc
    {
      get;
      set;
    }

    [Column("STN 13 : CF6 13_1bB11 Syringe Housing Height")]
    public int? STN13CF613_1bB11SyringeHousingHeight
    {
      get;
      set;
    }

    [Column("STN 13: CF7 13_1cB10 Shroud Presence")]
    public int? STN13CF713_1cB10ShroudPresence
    {
      get;
      set;
    }

    [Column("STN 14 : CF18 14_1B21 Gripper Insertion")]
    public int? STN14CF1814_1B21GripperInsertion
    {
      get;
      set;
    }

    [Column("STN 15 : CF9 15_1aB10 Syringe Housing Presenc")]
    public int? STN15CF915_1aB10SyringeHousingPresenc
    {
      get;
      set;
    }

    [Column("STN 15 : CF10 15_1aB11 Syringe Housing Height")]
    public int? STN15CF1015_1aB11SyringeHousingHeight
    {
      get;
      set;
    }

    [Column("STN 17: CF11 17_1aA70 Insertion Force")]
    public int? STN17CF1117_1aA70InsertionForce
    {
      get;
      set;
    }

    [Column("STN 17: CF12 Insertion Complete")]
    public int? STN17CF12InsertionComplete
    {
      get;
      set;
    }

    [Column("STN 18: CF13 18_1bA70 Keyhole Open")]
    public int? STN18CF1318_1bA70KeyholeOpen
    {
      get;
      set;
    }

    [Column("STN 18 : CF14 18_1aB12 Spring/Shroud Presence")]
    public int? STN18CF1418_1aB12SpringShroudPresence
    {
      get;
      set;
    }

    [Column("STN 18 : CF21 18_1aB13 Spring/Shroud Height")]
    public int? STN18CF2118_1aB13SpringShroudHeight
    {
      get;
      set;
    }

    [Column("STN 18: CF23 18_1aB12 Spring Presence")]
    public int? STN18CF2318_1aB12SpringPresence
    {
      get;
      set;
    }

    [Column("STN 20: CF24 20_1B12 Boot Remover Type")]
    public int? STN20CF2420_1B12BootRemoverType
    {
      get;
      set;
    }

    [Column("STN 20: CF25 20_1aB13 Boot Remover Print")]
    public int? STN20CF2520_1aB13BootRemoverPrint
    {
      get;
      set;
    }

    [Column("STN 21 : CF15 21_1aB10 Boot Remover Presence")]
    public int? STN21CF1521_1aB10BootRemoverPresence
    {
      get;
      set;
    }

    [Column("STN 21 : CF16 21_1aB11 Boot Remover Height")]
    public int? STN21CF1621_1aB11BootRemoverHeight
    {
      get;
      set;
    }

    [Column("STN 24: CF22 24_1A70 SC Damper")]
    public int? STN24CF2224_1A70SCDamper
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
    public double? BatchPercentComplete
    {
      get;
      set;
    }
  }
}
