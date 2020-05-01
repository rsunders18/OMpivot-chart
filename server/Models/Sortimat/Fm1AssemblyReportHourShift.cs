using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("FM1_Assembly_ReportHour_Shift", Schema = "App")]
  public partial class Fm1AssemblyReportHourShift
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
    public Int64? ShifPresetGoodParts
    {
      get;
      set;
    }
    public Int64? ShifGoodPartsAssembled
    {
      get;
      set;
    }
    public Int64? ShifPartsToAssemble
    {
      get;
      set;
    }
    public string StartShifDate
    {
      get;
      set;
    }
    public string EndShifDate
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

    [Column("ShifGood%")]
    public double? ShifGood
    {
      get;
      set;
    }

    [Column("ShifBad%")]
    public double? ShifBad
    {
      get;
      set;
    }

    [Column("ShifEfficiency%")]
    public double? ShifEfficiency
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

    [Column("STN 13- 1: Bad Parts Button / Pin / SpringH")]
    public int STN131BadPartsButtonPinSpringH
    {
      get;
      set;
    }

    [Column("STN 15- 1: Bad Parts Firing BodyH")]
    public int STN151BadPartsFiringBodyH
    {
      get;
      set;
    }

    [Column("STN 16- 1: Bad Parts PrinH")]
    public int STN161BadPartsPrinH
    {
      get;
      set;
    }

    [Column("STN 19- 1: Bad Parts SpringH")]
    public int STN191BadPartsSpringH
    {
      get;
      set;
    }

    [Column("STN 21- 1: Bad Parts Plunger LoadH")]
    public int STN211BadPartsPlungerLoadH
    {
      get;
      set;
    }

    [Column("STN 22- 1: Bad Parts Pin CapH")]
    public int STN221BadPartsPinCapH
    {
      get;
      set;
    }

    [Column("STN 23- 1: Bad Parts PlungerH")]
    public int STN231BadPartsPlungerH
    {
      get;
      set;
    }

    [Column("STN 13 : CF1 13_1aB10 Firing Button PresentH")]
    public int STN13CF113_1aB10FiringButtonPresentH
    {
      get;
      set;
    }

    [Column("STN 13 : CF2 13_1aB11 Firing Button HeightH")]
    public int STN13CF213_1aB11FiringButtonHeightH
    {
      get;
      set;
    }

    [Column("STN 13 : CF3 13_1bB10 Firing Pin PresentH")]
    public int STN13CF313_1bB10FiringPinPresentH
    {
      get;
      set;
    }

    [Column("STN 13 : CF4 13_1bB11 Firing Pin StraightH")]
    public int STN13CF413_1bB11FiringPinStraightH
    {
      get;
      set;
    }

    [Column("STN 13 : CF5 13_1cB10 Spring PresentH")]
    public int STN13CF513_1cB10SpringPresentH
    {
      get;
      set;
    }

    [Column("STN 15 : CF6 15_1aB10 Firing Body PresentH")]
    public int STN15CF615_1aB10FiringBodyPresentH
    {
      get;
      set;
    }

    [Column("STN 15 : CF7 15_1aB11 Firing Body HeightH")]
    public int STN15CF715_1aB11FiringBodyHeightH
    {
      get;
      set;
    }

    [Column("STN 16 : CF8 16_1aB12 Print PresentH")]
    public int STN16CF816_1aB12PrintPresentH
    {
      get;
      set;
    }

    [Column("STN 19 : CF9 19_1bB10 Spring PresentH")]
    public int STN19CF919_1bB10SpringPresentH
    {
      get;
      set;
    }

    [Column("STN 21 : CF10 21A70_bG Plunger LoadH")]
    public int STN21CF1021A70_bGPlungerLoadH
    {
      get;
      set;
    }

    [Column("STN 21 : CF12 21_1bB12 Ld Cell DnH")]
    public int STN21CF1221_1bB12LdCellDnH
    {
      get;
      set;
    }

    [Column("STN 22 : CF11 22_1bB12 Pin Cap HeightH")]
    public int STN22CF1122_1bB12PinCapHeightH
    {
      get;
      set;
    }

    [Column("STN 23 : CF13 23_1bB10 Plunger PresentH")]
    public int STN23CF1323_1bB10PlungerPresentH
    {
      get;
      set;
    }

    [Column("STN 18- 1: Bad Parts Firing Button/Firing PinH")]
    public int STN181BadPartsFiringButtonFiringPinH
    {
      get;
      set;
    }

    [Column("STN 24- 1: Bad Parts Assembly Wrong TypeH")]
    public int STN241BadPartsAssemblyWrongTypeH
    {
      get;
      set;
    }

    [Column("STN 18 : CF14 18_1bA10 Firing Button/PinH")]
    public int STN18CF1418_1bA10FiringButtonPinH
    {
      get;
      set;
    }

    [Column("STN 24 : CF18 24_1A70 LPC TypeH")]
    public int STN24CF1824_1A70LPCTypeH
    {
      get;
      set;
    }

    [Column("STN 24 : CF20 24_1A70 Proper AssemblyH")]
    public int STN24CF2024_1A70ProperAssemblyH
    {
      get;
      set;
    }
  }
}
