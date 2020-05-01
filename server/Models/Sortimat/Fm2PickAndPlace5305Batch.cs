using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("FM2_PickAndPlace_5305_Batch", Schema = "Abbvie")]
  public partial class Fm2PickAndPlace5305Batch
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
