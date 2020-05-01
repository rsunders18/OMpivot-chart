export interface AppDailyProductionShift {
  Date: string;
  DayName: string;
  ShiftName: string;
  DayShift: string;
  DayOfWeekUK: string;
  BatchID: string;
  Machine: string;
  MachineID: number;
  Shift: string;
  WeekRange: string;
  Rejects: number;
  GoodDevices: number;
  ActualYield: number;
  PcsPerHour: number;
  TargetAt70Percent10080: number;
  DownTime: string;
  MachineAutoStop: string;
  StopTime: string;
  CleaningTime: string;
  LunchTime: string;
  BreakTime: string;
  ChangeOverTime: string;
  MaintenanceTime: string;
  MissingMaterialTime: string;
  WeekDay: string;
}

export interface BatchHourReport {
  RowID: number;
  CreatedOn: string;
  Machine: string;
  MachineID: number;
  BatchID: string;
  RecordedOnDate: string;
  RecordedOnHour: number;
  DateHour: string;
  PlannedRunTime: number;
  ActualRunTime: number;
  BatchETA: string;
  BatchCompletedPercent: number;
  BatchTotal: number;
  BatchTotalBad: number;
  BatchTotalGood: number;
  BatchGoodPercent: number;
  RejectRate: number;
  BatchBadPercent: number;
  TotalCycles: number;
  Availability: number;
  Performance: number;
  Quality: number;
  OEE: number;
  BatchEfficiencyPercent: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  TotalStopTime: number;
  StopTime: number;
  AlarmTime: number;
  CleaningTime: number;
  LunchTime: number;
  BreakTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  MissingMaterialTime: number;
  RestartTime: number;
  BatchPercentCompletedH: number;
  PlannedRunTimeH: number;
  ActualRunTimeH: number;
  BatchTotalH: number;
  BatchTotalBadH: number;
  BatchTotalGoodH: number;
  TotalAlarmsH: number;
  GuardDoorOpenedH: number;
  TotalStopTimeH: number;
  StopTimeH: number;
  AlarmTimeH: number;
  CleaningTimeH: number;
  LunchTimeH: number;
  BreakTimeH: number;
  ChangeOverTimeH: number;
  MaintenanceTimeH: number;
  MissingMaterialTimeH: number;
  RestartTimeH: number;
}

export interface BatchHourReportFm1Assembly5201 {

}

export interface BatchHourReportFm1PickAndPlace5219 {

}

export interface BatchHourReportFm2Assembly5306 {

}

export interface BatchHourReportFm2PickAndPlace5305 {

}

export interface BatchHourReportSh1Assembly5202 {

}

export interface BatchHourReportSh1PickAndPlace5220 {

}

export interface BatchHourReportSh2Assembly5308 {

}

export interface BatchHourReportSh2PickAndPlace5307 {

}

export interface BatchReportDashTimer {
  MachineID: number;
  BatchID: string;
  Shift: string;
  DateHour: string;
  RecordedOn: number;
  TagType: string;
  TagName: string;
  Value: number;
  ValueChar: string;
  ValueH: number;
  ValueHChar: string;
  Indicator: string;
}

export interface BatchReportDashTimersGrouped {
  MachineID: number;
  BatchID: string;
  TagName: string;
  Value: number;
  ValueChar: string;
}

export interface ChartDatum {
  _BATCHID: string;
  DateHour: string;
  Machine: string;
  MachineID: number;
  TagGroup: string;
  TagType: string;
  TagName: string;
  TagID: number;
  TagDescription: string;
  Value: number;
  ValueCurrentHour: number;
}

export interface DailyProductionShift {
  Machine: string;
  MachineID: number;
  Shift: string;
  Shiftc: string;
  Rejects: number;
  GoodDevices: number;
  ActualYield: number;
  PcsPerHour: number;
  TargetAt70Percent10080: number;
  DownTime: string;
  MachineAutoStop: string;
  StopTime: string;
  CleaningTime: string;
  LunchTime: string;
  BreakTime: string;
  ChangeOverTime: string;
  MaintenanceTime: string;
  MissingMaterialTime: string;
}

export interface DashDatum {
  MachineID: number;
  RowID: number;
  CreatedOn: string;
  Machine: string;
  BatchID: string;
  RecordedOnDate: string;
  RecordedOnHour: number;
  DateHour: string;
  PlannedRunTime: number;
  ActualRunTime: number;
  BatchETA: string;
  BatchCompletedPercent: number;
  BatchTotal: number;
  BatchTotalBad: number;
  BatchTotalGood: number;
  BatchGoodPercent: number;
  RejectRate: number;
  BatchBadPercent: number;
  TotalCycles: number;
  Availability: number;
  Performance: number;
  Quality: number;
  OEE: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  TotalStopTime: number;
  StopTime: number;
  AlarmTime: number;
  CleaningTime: number;
  LunchTime: number;
  BreakTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  MissingMaterialTime: number;
  RestartTime: number;
  BatchPercentCompletedH: number;
  PlannedRunTimeH: number;
  ActualRunTimeH: number;
  BatchTotalH: number;
  BatchTotalBadH: number;
  BatchTotalGoodH: number;
  TotalAlarmsH: number;
  GuardDoorOpenedH: number;
  TotalStopTimeH: number;
  StopTimeH: number;
  AlarmTimeH: number;
  CleaningTimeH: number;
  LunchTimeH: number;
  BreakTimeH: number;
  ChangeOverTimeH: number;
  MaintenanceTimeH: number;
  MissingMaterialTimeH: number;
  RestartTimeH: number;
}

export interface Date {
  DateKey: number;
  Date1: string;
  FullDateUK: string;
  FullDateUSA: string;
  DayOfMonth: string;
  DaySuffix: string;
  DayName: string;
  DayOfWeekUSA: string;
  DayOfWeekUK: string;
  DayOfWeekInMonth: string;
  DayOfWeekInYear: string;
  DayOfQuarter: string;
  DayOfYear: string;
  WeekOfMonth: string;
  WeekOfQuarter: string;
  WeekOfYear: string;
  Month: string;
  MonthName: string;
  MonthOfQuarter: string;
  Quarter: string;
  QuarterName: string;
  Year: string;
  YearName: string;
  MonthYear: string;
  MMYYYY: string;
  FirstDayOfMonth: string;
  LastDayOfMonth: string;
  FirstDayOfQuarter: string;
  LastDayOfQuarter: string;
  FirstDayOfYear: string;
  LastDayOfYear: string;
  IsHolidayUSA: boolean;
  IsWeekday: boolean;
  HolidayUSA: string;
  IsHolidayUK: boolean;
  HolidayUK: string;
}

export interface Fm1Assembly5201Batch {
  RowID: number;
  CreatedOn: string;
  ActualProduct: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  MachineID: string;
  BatchETA: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotalGood2: number;
  BatchTotalBad2: number;
  BatchTotal: number;
  STN131BadPartsButtonPinSpring: number;
  STN151BadPartsFiringBody: number;
  STN161BadPartsPrint: number;
  STN191BadPartsSpring: number;
  STN211BadPartsPlungerLoad: number;
  STN221BadPartsPinCap: number;
  STN231BadPartsPlunger: number;
  STN13CF113_1aB10FiringButtonPresent: number;
  STN13CF213_1aB11FiringButtonHeight: number;
  STN13CF313_1bB10FiringPinPresent: number;
  STN13CF413_1bB11FiringPinStraight: number;
  STN13CF513_1cB10SpringPresent: number;
  STN15CF615_1aB10FiringBodyPresent: number;
  STN15CF715_1aB11FiringBodyHeight: number;
  STN16CF816_1aB12PrintPresent: number;
  STN19CF919_1bB10SpringPresent: number;
  STN21CF1021A70_bGPlungerLoad: number;
  STN21CF1221_1bB12LdCellDn: number;
  STN22CF1122_1bB12PinCapHeight: number;
  STN23CF1323_1bB10PlungerPresent: number;
  STN181BadPartsFiringButtonFiringPin: number;
  STN241BadPartsAssemblyWrongType: number;
  STN18CF1418_1bA10FiringButtonPin: number;
  STN24CF1824_1A70LPCType: number;
  STN24CF2024_1A70ProperAssembly: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Fm1Assembly5201Datum {
  id: number;
  _NAME: string;
  _VALUE: number;
  _TIMESTAMP: string;
  _BATCHID: string;
}

export interface Fm1Assembly5201PerBatchPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotal: number;
  STN131BadPartsButtonPinSpring: number;
  STN151BadPartsFiringBody: number;
  STN161BadPartsPrint: number;
  STN191BadPartsSpring: number;
  STN211BadPartsPlungerLoad: number;
  STN221BadPartsPinCap: number;
  STN231BadPartsPlunger: number;
  STN13CF113_1aB10FiringButtonPresent: number;
  STN13CF213_1aB11FiringButtonHeight: number;
  STN13CF313_1bB10FiringPinPresent: number;
  STN13CF413_1bB11FiringPinStraight: number;
  STN13CF513_1cB10SpringPresent: number;
  STN15CF615_1aB10FiringBodyPresent: number;
  STN15CF715_1aB11FiringBodyHeight: number;
  STN16CF816_1aB12PrintPresent: number;
  STN19CF919_1bB10SpringPresent: number;
  STN21CF1021A70_bGPlungerLoad: number;
  STN21CF1221_1bB12LdCellDn: number;
  STN22CF1122_1bB12PinCapHeight: number;
  STN23CF1323_1bB10PlungerPresent: number;
  STN181BadPartsFiringButtonFiringPin: number;
  STN241BadPartsAssemblyWrongType: number;
  STN18CF1418_1bA10FiringButtonPin: number;
  STN24CF1824_1A70LPCType: number;
  STN24CF2024_1A70ProperAssembly: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Fm1Assembly5201PerShiftPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  Shift: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotal: number;
  STN131BadPartsButtonPinSpring: number;
  STN151BadPartsFiringBody: number;
  STN161BadPartsPrint: number;
  STN191BadPartsSpring: number;
  STN211BadPartsPlungerLoad: number;
  STN221BadPartsPinCap: number;
  STN231BadPartsPlunger: number;
  STN13CF113_1aB10FiringButtonPresent: number;
  STN13CF213_1aB11FiringButtonHeight: number;
  STN13CF313_1bB10FiringPinPresent: number;
  STN13CF413_1bB11FiringPinStraight: number;
  STN13CF513_1cB10SpringPresent: number;
  STN15CF615_1aB10FiringBodyPresent: number;
  STN15CF715_1aB11FiringBodyHeight: number;
  STN16CF816_1aB12PrintPresent: number;
  STN19CF919_1bB10SpringPresent: number;
  STN21CF1021A70_bGPlungerLoad: number;
  STN21CF1221_1bB12LdCellDn: number;
  STN22CF1122_1bB12PinCapHeight: number;
  STN23CF1323_1bB10PlungerPresent: number;
  STN181BadPartsFiringButtonFiringPin: number;
  STN241BadPartsAssemblyWrongType: number;
  STN18CF1418_1bA10FiringButtonPin: number;
  STN24CF1824_1A70LPCType: number;
  STN24CF2024_1A70ProperAssembly: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Fm1Assembly5201Shift {
  RowID: number;
  CreatedOn: string;
  ActualProduct: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  MachineID: string;
  Shift: string;
  ShiftTime: number;
  ShiftETA: string;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssemble: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotalGood2: number;
  ShiftTotalBad2: number;
  ShiftTotal: number;
  STN131BadPartsButtonPinSpring: number;
  STN151BadPartsFiringBody: number;
  STN161BadPartsPrint: number;
  STN191BadPartsSpring: number;
  STN211BadPartsPlungerLoad: number;
  STN221BadPartsPinCap: number;
  STN231BadPartsPlunger: number;
  STN13CF113_1aB10FiringButtonPresent: number;
  STN13CF213_1aB11FiringButtonHeight: number;
  STN13CF313_1bB10FiringPinPresent: number;
  STN13CF413_1bB11FiringPinStraight: number;
  STN13CF513_1cB10SpringPresent: number;
  STN15CF615_1aB10FiringBodyPresent: number;
  STN15CF715_1aB11FiringBodyHeight: number;
  STN16CF816_1aB12PrintPresent: number;
  STN19CF919_1bB10SpringPresent: number;
  STN21CF1021A70_bGPlungerLoad: number;
  STN21CF1221_1bB12LdCellDn: number;
  STN22CF1122_1bB12PinCapHeight: number;
  STN23CF1323_1bB10PlungerPresent: number;
  STN181BadPartsFiringButtonFiringPin: number;
  STN241BadPartsAssemblyWrongType: number;
  STN18CF1418_1bA10FiringButtonPin: number;
  STN24CF1824_1A70LPCType: number;
  STN24CF2024_1A70ProperAssembly: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Fm1AssemblyReportHourShift {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  DateHour: string;
  ActualProduct: string;
  MachineID: string;
  Shift: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShifPresetGoodParts: number;
  ShifGoodPartsAssembled: number;
  ShifPartsToAssemble: number;
  StartShifDate: string;
  EndShifDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShifGood: number;
  ShifBad: number;
  ShifEfficiency: number;
  ShiftTotal: number;
  STN131BadPartsButtonPinSpring: number;
  STN151BadPartsFiringBody: number;
  STN161BadPartsPrint: number;
  STN191BadPartsSpring: number;
  STN211BadPartsPlungerLoad: number;
  STN221BadPartsPinCap: number;
  STN231BadPartsPlunger: number;
  STN13CF113_1aB10FiringButtonPresent: number;
  STN13CF213_1aB11FiringButtonHeight: number;
  STN13CF313_1bB10FiringPinPresent: number;
  STN13CF413_1bB11FiringPinStraight: number;
  STN13CF513_1cB10SpringPresent: number;
  STN15CF615_1aB10FiringBodyPresent: number;
  STN15CF715_1aB11FiringBodyHeight: number;
  STN16CF816_1aB12PrintPresent: number;
  STN19CF919_1bB10SpringPresent: number;
  STN21CF1021A70_bGPlungerLoad: number;
  STN21CF1221_1bB12LdCellDn: number;
  STN22CF1122_1bB12PinCapHeight: number;
  STN23CF1323_1bB10PlungerPresent: number;
  STN181BadPartsFiringButtonFiringPin: number;
  STN241BadPartsAssemblyWrongType: number;
  STN18CF1418_1bA10FiringButtonPin: number;
  STN24CF1824_1A70LPCType: number;
  STN24CF2024_1A70ProperAssembly: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
  AutomaticTimeH: number;
  AlarmTimeH: number;
  StopTimeH: number;
  RestartTimeH: number;
  TotalCyclesH: number;
  TotalAlarmsH: number;
  GuardDoorOpenedH: number;
  AutomaticStartsH: number;
  LunchTimeH: number;
  BreakTimeH: number;
  CleaningTimeH: number;
  MissingMaterialTimeH: number;
  ChangeOverTimeH: number;
  MaintenanceTimeH: number;
  ShiftTotalGoodH: number;
  ShiftTotalBadH: number;
  ShiftGoodH: number;
  ShiftBadH: number;
  ShiftEfficiencyH: number;
  ShiftTotalH: number;
  STN131BadPartsButtonPinSpringH: number;
  STN151BadPartsFiringBodyH: number;
  STN161BadPartsPrinH: number;
  STN191BadPartsSpringH: number;
  STN211BadPartsPlungerLoadH: number;
  STN221BadPartsPinCapH: number;
  STN231BadPartsPlungerH: number;
  STN13CF113_1aB10FiringButtonPresentH: number;
  STN13CF213_1aB11FiringButtonHeightH: number;
  STN13CF313_1bB10FiringPinPresentH: number;
  STN13CF413_1bB11FiringPinStraightH: number;
  STN13CF513_1cB10SpringPresentH: number;
  STN15CF615_1aB10FiringBodyPresentH: number;
  STN15CF715_1aB11FiringBodyHeightH: number;
  STN16CF816_1aB12PrintPresentH: number;
  STN19CF919_1bB10SpringPresentH: number;
  STN21CF1021A70_bGPlungerLoadH: number;
  STN21CF1221_1bB12LdCellDnH: number;
  STN22CF1122_1bB12PinCapHeightH: number;
  STN23CF1323_1bB10PlungerPresentH: number;
  STN181BadPartsFiringButtonFiringPinH: number;
  STN241BadPartsAssemblyWrongTypeH: number;
  STN18CF1418_1bA10FiringButtonPinH: number;
  STN24CF1824_1A70LPCTypeH: number;
  STN24CF2024_1A70ProperAssemblyH: number;
}

export interface Fm1PickAndPlace5219Batch {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotalGood2: number;
  BatchTotalBad2: number;
  BatchTotal: number;
  STN3BadPartLockingPinCap: number;
  STN5BadPartSpring: number;
  STN11BadPartFiringButton: number;
  STN3CF13_1bB10LockingPinCapPresent: number;
  STN6CF26_1cB10SpringPresent: number;
  STN11CF311_1aB10FiringButtonPresent: number;
  STN11CF511_1aB11FiringButtonType: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Fm1PickAndPlace5219Datum {
  id: number;
  _NAME: string;
  _VALUE: number;
  _TIMESTAMP: string;
  _BATCHID: string;
}

export interface Fm1PickAndPlace5219PerBatchPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotal: number;
  STN3BadPartLockingPinCap: number;
  STN5BadPartSpring: number;
  STN11BadPartFiringButton: number;
  STN3CF13_1bB10LockingPinCapPresent: number;
  STN6CF26_1cB10SpringPresent: number;
  STN11CF311_1aB10FiringButtonPresent: number;
  STN11CF511_1aB11FiringButtonType: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Fm1PickAndPlace5219PerShiftPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  ShiftTime: number;
  Shift: string;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotal: number;
  STN3BadPartLockingPinCap: number;
  STN5BadPartSpring: number;
  STN11BadPartFiringButton: number;
  STN3CF13_1bB10LockingPinCapPresent: number;
  STN6CF26_1cB10SpringPresent: number;
  STN11CF311_1aB10FiringButtonPresent: number;
  STN11CF511_1aB11FiringButtonType: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Fm1PickAndPlace5219ReportHourShift {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  DateHour: string;
  ActualProduct: string;
  MachineID: string;
  Shift: string;
  ShiftTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotal: number;
  STN3BadPartLockingPinCap: number;
  STN5BadPartSpring: number;
  STN11BadPartFiringButton: number;
  STN3CF13_1bB10LockingPinCapPresent: number;
  STN6CF26_1cB10SpringPresent: number;
  STN11CF311_1aB10FiringButtonPresent: number;
  STN11CF511_1aB11FiringButtonType: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
  AutomaticTimeH: number;
  AlarmTimeH: number;
  StopTimeH: number;
  RestartTimeH: number;
  TotalCyclesH: number;
  TotalAlarmsH: number;
  GuardDoorOpenedH: number;
  AutomaticStartsH: number;
  LunchTimeH: number;
  BreakTimeH: number;
  CleaningTimeH: number;
  MissingMaterialTimeH: number;
  ChangeOverTimeH: number;
  MaintenanceTimeH: number;
  ShiftTotalGoodH: number;
  ShiftTotalBadH: number;
  ShiftGoodH: number;
  ShiftBadH: number;
  ShiftEfficiencyH: number;
  ShiftTotalH: number;
  STN3BadPartLockingPinCapH: number;
  STN5BadPartSpringH: number;
  STN11BadPartFiringButtonH: number;
  STN3CF13_1bB10LockingPinCapPresentH: number;
  STN6CF26_1cB10SpringPresentH: number;
  STN11CF311_1aB10FiringButtonPresentH: number;
  STN11CF511_1aB11FiringButtonTypeH: number;
}

export interface Fm1PickAndPlace5219Shift {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  Shift: string;
  ShiftTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotal: number;
  STN3BadPartLockingPinCap: number;
  STN5BadPartSpring: number;
  STN11BadPartFiringButton: number;
  STN3CF13_1bB10LockingPinCapPresent: number;
  STN6CF26_1cB10SpringPresent: number;
  STN11CF311_1aB10FiringButtonPresent: number;
  STN11CF511_1aB11FiringButtonType: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Fm2Assembly5306Batch {
  RowID: number;
  CreatedOn: string;
  ActualProduct: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotalGood2: number;
  BatchTotalBad2: number;
  BatchTotal: number;
  STN131BadPartsButtonPinSpring: number;
  STN151BadPartsFiringBody: number;
  STN171BadPartsPrint: number;
  STN181BadPartsFiringButtonPin: number;
  STN191BadPartsSpring: number;
  STN211BadPartsPlungerRetained: number;
  STN221BadPartsPinCap: number;
  STN231BadPartsPlunger: number;
  STN13CF113_1aB10FiringButtonPresent: number;
  STN13CF213_1aB11FiringButtonHeight: number;
  STN13CF313_1bB10FiringPinPresent: number;
  STN13CF413_1bB11FiringPinStraight: number;
  STN13CF513_1cB10SpringPresent: number;
  STN15CF615_1aB10FiringBodyPresent: number;
  STN15CF715_1aB11FiringBodyHeight: number;
  STN17CF817_1aB12PrintPresent: number;
  STN18CF1418_1bA10FiringButtonPin: number;
  STN19CF919_1bB10SpringPresent: number;
  STN21CF10PlungerInsertionComplete: number;
  STN21CF1221_1bA70gPlungerRetained: number;
  STN22CF1122_1bA70PinCapSeated: number;
  STN22CF1522_1bB10PlungerPresent: number;
  STN23CF1323_1bB10PlungerPresent: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Fm2Assembly5306Datum {
  id: number;
  _NAME: string;
  _VALUE: number;
  _TIMESTAMP: string;
  _BATCHID: string;
}

export interface Fm2Assembly5306PerBatchPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotal: number;
  STN131BadPartsButtonPinSpring: number;
  STN151BadPartsFiringBody: number;
  STN171BadPartsPrint: number;
  STN181BadPartsFiringButtonPin: number;
  STN191BadPartsSpring: number;
  STN211BadPartsPlungerRetained: number;
  STN221BadPartsPinCap: number;
  STN231BadPartsPlunger: number;
  STN13CF113_1aB10FiringButtonPresent: number;
  STN13CF213_1aB11FiringButtonHeight: number;
  STN13CF313_1bB10FiringPinPresent: number;
  STN13CF413_1bB11FiringPinStraight: number;
  STN13CF513_1cB10SpringPresent: number;
  STN15CF615_1aB10FiringBodyPresent: number;
  STN15CF715_1aB11FiringBodyHeight: number;
  STN17CF817_1aB12PrintPresent: number;
  STN18CF1418_1bA10FiringButtonPin: number;
  STN19CF919_1bB10SpringPresent: number;
  STN21CF10PlungerInsertionComplete: number;
  STN21CF1221_1bA70gPlungerRetained: number;
  STN22CF1122_1bA70PinCapSeated: number;
  STN22CF1522_1bB10PlungerPresent: number;
  STN23CF1323_1bB10PlungerPresent: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Fm2Assembly5306PerShiftPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  Shift: string;
  ShiftTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotal: number;
  STN131BadPartsButtonPinSpring: number;
  STN151BadPartsFiringBody: number;
  STN171BadPartsPrint: number;
  STN181BadPartsFiringButtonPin: number;
  STN191BadPartsSpring: number;
  STN211BadPartsPlungerRetained: number;
  STN221BadPartsPinCap: number;
  STN231BadPartsPlunger: number;
  STN13CF113_1aB10FiringButtonPresent: number;
  STN13CF213_1aB11FiringButtonHeight: number;
  STN13CF313_1bB10FiringPinPresent: number;
  STN13CF413_1bB11FiringPinStraight: number;
  STN13CF513_1cB10SpringPresent: number;
  STN15CF615_1aB10FiringBodyPresent: number;
  STN15CF715_1aB11FiringBodyHeight: number;
  STN17CF817_1aB12PrintPresent: number;
  STN18CF1418_1bA10FiringButtonPin: number;
  STN19CF919_1bB10SpringPresent: number;
  STN21CF10PlungerInsertionComplete: number;
  STN21CF1221_1bA70gPlungerRetained: number;
  STN22CF1122_1bA70PinCapSeated: number;
  STN22CF1522_1bB10PlungerPresent: number;
  STN23CF1323_1bB10PlungerPresent: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Fm2Assembly5306Shift {
  RowID: number;
  CreatedOn: string;
  ActualProduct: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  MachineID: string;
  Shift: string;
  ShiftTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssemble: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotalGood2: number;
  ShiftTotalBad2: number;
  ShiftTotal: number;
  STN131BadPartsButtonPinSpring: number;
  STN151BadPartsFiringBody: number;
  STN171BadPartsPrint: number;
  STN181BadPartsFiringButtonPin: number;
  STN191BadPartsSpring: number;
  STN211BadPartsPlungerRetained: number;
  STN221BadPartsPinCap: number;
  STN231BadPartsPlunger: number;
  STN13CF113_1aB10FiringButtonPresent: number;
  STN13CF213_1aB11FiringButtonHeight: number;
  STN13CF313_1bB10FiringPinPresent: number;
  STN13CF413_1bB11FiringPinStraight: number;
  STN13CF513_1cB10SpringPresent: number;
  STN15CF615_1aB10FiringBodyPresent: number;
  STN15CF715_1aB11FiringBodyHeight: number;
  STN17CF817_1aB12PrintPresent: number;
  STN18CF1418_1bA10FiringButtonPin: number;
  STN19CF919_1bB10SpringPresent: number;
  STN21CF10PlungerInsertionComplete: number;
  STN21CF1221_1bA70gPlungerRetained: number;
  STN22CF1122_1bA70PinCapSeated: number;
  STN22CF1522_1bB10PlungerPresent: number;
  STN23CF1323_1bB10PlungerPresent: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Fm2PickAndPlace5305Batch {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotalGood2: number;
  BatchTotalBad2: number;
  BatchTotal: number;
  STN3BadPartLockingPinCap: number;
  STN5BadPartSpring: number;
  STN11BadPartFiringButton: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Fm2PickAndPlace5305Datum {
  id: number;
  _NAME: string;
  _VALUE: number;
  _TIMESTAMP: string;
  _BATCHID: string;
}

export interface Fm2PickAndPlace5305PerBatchPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotal: number;
  STN3BadPartLockingPinCap: number;
  STN5BadPartSpring: number;
  STN11BadPartFiringButton: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Fm2PickAndPlace5305PerShiftPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  ShiftTime: number;
  Shift: string;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotal: number;
  STN3BadPartLockingPinCap: number;
  STN5BadPartSpring: number;
  STN11BadPartFiringButton: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Fm2PickAndPlace5305Shift {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  Shift: string;
  ShiftTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotalGood2: number;
  ShiftTotalBad2: number;
  ShiftTotal: number;
  STN3BadPartLockingPinCap: number;
  STN5BadPartSpring: number;
  STN11BadPartFiringButton: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface HourValue {
  RowID: number;
  CreatedOn: string;
  BatchID: string;
  Shift: string;
  DateHour: string;
  Machine: string;
  MachineID: number;
  TagID: number;
  TagGroup: string;
  TagType: string;
  TagName: string;
  TagDescription: string;
  Value: number;
  ValueH: number;
}

export interface Machine {
  MachineID: number;
  CycleSpeed: number;
  PartsPerMinute: number;
  ShiftTarget70Percent: number;
  ShiftTarget100Percent: number;
  BatchTarget70Percent: number;
  BatchTarget100Percent: number;
  Machine1: string;
  Description: string;
  CreatedOn: string;
}

export interface OmPadBrPerShiftPerCycle {
  id: number;
  PAD_BR_OSI_PI_Current_Shift_Alarming_Time_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Alarming_Time_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Alarming_Time_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Alarming_Time_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Reject_Percentage_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Reject_Percentage_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Reject_Percentage_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Reject_Percentage_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Run_Time_Efficiency_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Run_Time_Efficiency_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Run_Time_Efficiency_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Run_Time_Efficiency_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Running_Time_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Running_Time_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Running_Time_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Running_Time_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Day_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Day_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Day_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Day_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Month_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Month_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Month_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Month_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Year_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Year_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Year_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_Date_Year_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Hour_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Hour_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Hour_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Hour_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Min_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Min_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Min_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Min_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Sec_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Sec_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Sec_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Sec_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Hour_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Hour_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Hour_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Hour_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Efficiency_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Efficiency_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Efficiency_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Efficiency_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Min_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Min_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Min_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Min_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Sec_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Sec_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Sec_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Sec_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Stopped_Time_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Stopped_Time_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Stopped_Time_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Stopped_Time_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Total_Alarms_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Total_Alarms_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Total_Alarms_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Total_Alarms_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Total_Good_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Total_Good_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Total_Good_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Total_Good_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Total_Reject_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Total_Reject_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Total_Reject_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Total_Reject_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Total_Shift_Time_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Total_Shift_Time_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Total_Shift_Time_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Total_Shift_Time_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Good_Percentage_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Good_Percentage_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Good_Percentage_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Good_Percentage_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Miscel_Reject_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Miscel_Reject_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Miscel_Reject_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Miscel_Reject_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_OEE_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_OEE_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_OEE_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_OEE_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Print_reject_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Print_reject_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Print_reject_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Print_reject_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Rated_Speed_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Rated_Speed_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Rated_Speed_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Rated_Speed_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Recipe_Name_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Recipe_Name_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Recipe_Name_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Recipe_Name_QUALITY: number;
  PAD_BR_OSI_PI_Current_Shift_Register_Reject_NUMERICID: number;
  PAD_BR_OSI_PI_Current_Shift_Register_Reject_VALUE: string;
  PAD_BR_OSI_PI_Current_Shift_Register_Reject_TIMESTAMP: string;
  PAD_BR_OSI_PI_Current_Shift_Register_Reject_QUALITY: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
}

export interface OmPadLpcPerShiftPerCycle {
  id: number;
  PAD_LPC_OSI_PI_Current_Shift_Alarming_Time_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Alarming_Time_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Alarming_Time_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Alarming_Time_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Reject_Percentage_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Reject_Percentage_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Reject_Percentage_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Reject_Percentage_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Run_Time_Efficiency_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Run_Time_Efficiency_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Run_Time_Efficiency_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Run_Time_Efficiency_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Running_Time_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Running_Time_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Running_Time_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Running_Time_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Day_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Day_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Day_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Day_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Month_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Month_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Month_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Month_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Year_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Year_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Year_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Year_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Hour_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Hour_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Hour_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Hour_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Min_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Min_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Min_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Min_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Sec_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Sec_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Sec_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Sec_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Hour_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Hour_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Hour_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Hour_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Efficiency_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Efficiency_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Efficiency_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Efficiency_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Min_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Min_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Min_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Min_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Sec_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Sec_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Sec_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Sec_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Stopped_Time_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Stopped_Time_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Stopped_Time_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Stopped_Time_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Total_Alarms_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Total_Alarms_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Total_Alarms_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Total_Alarms_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Total_Good_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Total_Good_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Total_Good_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Total_Good_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Total_Reject_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Total_Reject_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Total_Reject_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Total_Reject_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Total_Shift_Time_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Total_Shift_Time_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Total_Shift_Time_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Total_Shift_Time_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Good_Percentage_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Good_Percentage_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Good_Percentage_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Good_Percentage_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Miscel_Reject_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Miscel_Reject_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Miscel_Reject_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Miscel_Reject_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_OEE_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_OEE_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_OEE_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_OEE_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Print_reject_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Print_reject_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Print_reject_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Print_reject_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Rated_Speed_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Rated_Speed_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Rated_Speed_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Rated_Speed_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Recipe_Name_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Recipe_Name_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Recipe_Name_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Recipe_Name_QUALITY: number;
  PAD_LPC_OSI_PI_Current_Shift_Register_Reject_NUMERICID: number;
  PAD_LPC_OSI_PI_Current_Shift_Register_Reject_VALUE: string;
  PAD_LPC_OSI_PI_Current_Shift_Register_Reject_TIMESTAMP: string;
  PAD_LPC_OSI_PI_Current_Shift_Register_Reject_QUALITY: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
}

export interface OmPadShPerShiftPerCycle {
  id: number;
  PAD_SH_OSI_PI_Current_Shift_Alarming_Time_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Alarming_Time_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Alarming_Time_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Alarming_Time_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Reject_Percentage_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Reject_Percentage_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Reject_Percentage_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Reject_Percentage_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Run_Time_Efficiency_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Run_Time_Efficiency_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Run_Time_Efficiency_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Run_Time_Efficiency_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Running_Time_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Running_Time_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Running_Time_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Running_Time_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Day_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Day_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Day_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Day_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Month_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Month_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Month_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Month_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Year_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Year_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Year_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_Date_Year_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Hour_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Hour_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Hour_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Hour_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Min_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Min_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Min_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Min_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Sec_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Sec_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Sec_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Sec_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Hour_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Hour_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Hour_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Hour_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Efficiency_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Efficiency_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Efficiency_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Efficiency_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Min_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Min_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Min_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Min_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Sec_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Sec_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Sec_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Sec_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Stopped_Time_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Stopped_Time_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Stopped_Time_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Stopped_Time_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Total_Alarms_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Total_Alarms_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Total_Alarms_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Total_Alarms_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Total_Good_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Total_Good_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Total_Good_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Total_Good_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Total_Reject_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Total_Reject_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Total_Reject_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Total_Reject_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Total_Shift_Time_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Total_Shift_Time_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Total_Shift_Time_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Total_Shift_Time_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Good_Percentage_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Good_Percentage_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Good_Percentage_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Good_Percentage_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Miscel_Reject_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Miscel_Reject_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Miscel_Reject_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Miscel_Reject_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_OEE_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_OEE_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_OEE_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_OEE_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Print_reject_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Print_reject_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Print_reject_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Print_reject_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Rated_Speed_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Rated_Speed_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Rated_Speed_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Rated_Speed_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Recipe_Name_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Recipe_Name_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Recipe_Name_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Recipe_Name_QUALITY: number;
  PAD_SH_OSI_PI_Current_Shift_Register_Reject_NUMERICID: number;
  PAD_SH_OSI_PI_Current_Shift_Register_Reject_VALUE: string;
  PAD_SH_OSI_PI_Current_Shift_Register_Reject_TIMESTAMP: string;
  PAD_SH_OSI_PI_Current_Shift_Register_Reject_QUALITY: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
}

export interface PopulateAbbvieFm1Assembly5201Batch {

}

export interface PopulateAbbvieFm1Assembly5201Shift {

}

export interface PopulateAbbvieFm1PickAndPlace5219Batch {

}

export interface PopulateAbbvieFm1PickAndPlace5219Shift {

}

export interface PopulateAbbvieFm2Assembly5306Shift {

}

export interface PopulateAbbvieFm2PickAndPlace5305Shift {

}

export interface PopulateAbbvieSh1Assembly5202Shift {

}

export interface PopulateAbbvieSh1PickAndPlace5220Shift {

}

export interface PopulateAbbvieSh2Assembly5308Shift {

}

export interface PopulateAbbvieSh2PickAndPlace5307Shift {

}

export interface PopulateFm1AssemblyReportHourShift {

}

export interface PopulateFm1PickAndPlace5219ReportHourShift {

}

export interface PopulateFm2Assembly5306Batch {

}

export interface PopulateFm2PickAndPlace5305Batch {

}

export interface PopulateSh1Assembly5202Batch {

}

export interface PopulateSh1Assembly5202Shift {

}

export interface PopulateSh1PickAndPlace5220Batch {

}

export interface PopulateSh2Assembly5308Batch {

}

export interface PopulateSh2PickAndPlace5307Batch {

}

export interface Sh1Assembly5202Batch {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotalGood2: number;
  BatchTotalBad2: number;
  BatchTotal: number;
  STN131BadPartsCarrierHousingShroud: number;
  STN141BadPartsGripperInsertion: number;
  STN151BadPartsSyringeHousing: number;
  STN171BadPartsInsertiong: number;
  STN181BadPartsKeyholeSpringShroud: number;
  STN201BadPartsBootRemover: number;
  STN211BadPartsBootRemover: number;
  STN221BadPartsPrint: number;
  STN241BadPartsSCDamper: number;
  STN13CF113_1aB10SyringeCarrierPresence: number;
  STN13CF513_1bB10SyringeHousingPresenc: number;
  STN13CF613_1bB11SyringeHousingHeight: number;
  STN13CF713_1cB10ShroudPresence: number;
  STN14CF1814_1B21GripperInsertion: number;
  STN15CF915_1aB10SyringeHousingPresenc: number;
  STN15CF1015_1aB11SyringeHousingHeight: number;
  STN17CF1117_1aA70InsertionForce: number;
  STN17CF12InsertionComplete: number;
  STN18CF1318_1bA70KeyholeOpen: number;
  STN18CF1418_1aB12SpringShroudPresence: number;
  STN18CF2118_1aB13SpringShroudHeight: number;
  STN18CF2318_1aB12SpringPresence: number;
  STN20CF2420_1B12BootRemoverType: number;
  STN20CF2620_1B23BootRemoverInsertion: number;
  STN20CF2520_1aB13BootRemoverPrint: number;
  STN21CF1521_1aB10BootRemoverPresence: number;
  STN21CF1621_1aB11BootRemoverHeight: number;
  STN22CF1722_1aB12PrintPresent: number;
  STN24CF2224_1A70SCDamper: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Sh1Assembly5202Datum {
  id: number;
  _NAME: string;
  _VALUE: number;
  _TIMESTAMP: string;
  _BATCHID: string;
}

export interface Sh1Assembly5202PerBatchPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotal: number;
  STN131BadPartsCarrierHousingShroud: number;
  STN141BadPartsGripperInsertion: number;
  STN151BadPartsSyringeHousing: number;
  STN171BadPartsInsertiong: number;
  STN181BadPartsKeyholeSpringShroud: number;
  STN201BadPartsBootRemover: number;
  STN211BadPartsBootRemover: number;
  STN221BadPartsPrint: number;
  STN241BadPartsSCDamper: number;
  STN13CF113_1aB10SyringeCarrierPresence: number;
  STN13CF513_1bB10SyringeHousingPresenc: number;
  STN13CF613_1bB11SyringeHousingHeight: number;
  STN13CF713_1cB10ShroudPresence: number;
  STN14CF1814_1B21GripperInsertion: number;
  STN15CF915_1aB10SyringeHousingPresenc: number;
  STN15CF1015_1aB11SyringeHousingHeight: number;
  STN17CF1117_1aA70InsertionForce: number;
  STN17CF12InsertionComplete: number;
  STN18CF1318_1bA70KeyholeOpen: number;
  STN18CF1418_1aB12SpringShroudPresence: number;
  STN18CF2118_1aB13SpringShroudHeight: number;
  STN18CF2318_1aB12SpringPresence: number;
  STN20CF2420_1B12BootRemoverType: number;
  STN20CF2620_1B23BootRemoverInsertion: number;
  STN20CF2520_1aB13BootRemoverPrint: number;
  STN21CF1521_1aB10BootRemoverPresence: number;
  STN21CF1621_1aB11BootRemoverHeight: number;
  STN22CF1722_1aB12PrintPresent: number;
  STN24CF2224_1A70SCDamper: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Sh1Assembly5202PerShiftPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  ShiftTime: number;
  Shift: string;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotal: number;
  STN131BadPartsCarrierHousingShroud: number;
  STN141BadPartsGripperInsertion: number;
  STN151BadPartsSyringeHousing: number;
  STN171BadPartsInsertiong: number;
  STN181BadPartsKeyholeSpringShroud: number;
  STN201BadPartsBootRemover: number;
  STN211BadPartsBootRemover: number;
  STN221BadPartsPrint: number;
  STN241BadPartsSCDamper: number;
  STN13CF113_1aB10SyringeCarrierPresence: number;
  STN13CF513_1bB10SyringeHousingPresenc: number;
  STN13CF613_1bB11SyringeHousingHeight: number;
  STN13CF713_1cB10ShroudPresence: number;
  STN14CF1814_1B21GripperInsertion: number;
  STN15CF915_1aB10SyringeHousingPresenc: number;
  STN15CF1015_1aB11SyringeHousingHeight: number;
  STN17CF1117_1aA70InsertionForce: number;
  STN17CF12InsertionComplete: number;
  STN18CF1318_1bA70KeyholeOpen: number;
  STN18CF1418_1aB12SpringShroudPresence: number;
  STN18CF2118_1aB13SpringShroudHeight: number;
  STN18CF2318_1aB12SpringPresence: number;
  STN20CF2420_1B12BootRemoverType: number;
  STN20CF2620_1B23BootRemoverInsertion: number;
  STN20CF2520_1aB13BootRemoverPrint: number;
  STN21CF1521_1aB10BootRemoverPresence: number;
  STN21CF1621_1aB11BootRemoverHeight: number;
  STN22CF1722_1aB12PrintPresent: number;
  STN24CF2224_1A70SCDamper: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Sh1Assembly5202Shift {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  ShiftTime: number;
  Shift: string;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotalGood2: number;
  ShiftTotalBad2: number;
  ShiftTotal: number;
  STN131BadPartsCarrierHousingShroud: number;
  STN141BadPartsGripperInsertion: number;
  STN151BadPartsSyringeHousing: number;
  STN171BadPartsInsertiong: number;
  STN181BadPartsKeyholeSpringShroud: number;
  STN201BadPartsBootRemover: number;
  STN211BadPartsBootRemover: number;
  STN221BadPartsPrint: number;
  STN241BadPartsSCDamper: number;
  STN13CF113_1aB10SyringeCarrierPresence: number;
  STN13CF513_1bB10SyringeHousingPresenc: number;
  STN13CF613_1bB11SyringeHousingHeight: number;
  STN13CF713_1cB10ShroudPresence: number;
  STN14CF1814_1B21GripperInsertion: number;
  STN15CF915_1aB10SyringeHousingPresenc: number;
  STN15CF1015_1aB11SyringeHousingHeight: number;
  STN17CF1117_1aA70InsertionForce: number;
  STN17CF12InsertionComplete: number;
  STN18CF1318_1bA70KeyholeOpen: number;
  STN18CF1418_1aB12SpringShroudPresence: number;
  STN18CF2118_1aB13SpringShroudHeight: number;
  STN18CF2318_1aB12SpringPresence: number;
  STN20CF2420_1B12BootRemoverType: number;
  STN20CF2620_1B23BootRemoverInsertion: number;
  STN20CF2520_1aB13BootRemoverPrint: number;
  STN21CF1521_1aB10BootRemoverPresence: number;
  STN21CF1621_1aB11BootRemoverHeight: number;
  STN22CF1722_1aB12PrintPresent: number;
  STN24CF2224_1A70SCDamper: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Sh1PickAndPlace5220Batch {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotalGood2: number;
  BatchTotalBad2: number;
  BatchTotal: number;
  STN3BadPartLockingSCGasket3_1aB10: number;
  STN4BadPartSyringeCarrier4_1aB10: number;
  STN6BadPartSpring6_1cB10: number;
  STN9BadPartSyringeHousing9_1bB10: number;
  STN5BadpartSpringType: number;
  STN11BadpartLockoutShroudType: number;
  STN12BadPartShroud12_1cB10: number;
  STN3CF13_1A70SCDamperGaskett: number;
  STN4CF24_1aA70SCTabsOK: number;
  STN4CF114_1aA70SCType: number;
  STN5CF125_1cA70SpringType: number;
  STN5CF135_1cA70SpringPresence: number;
  STN6CF36_1cB10SpringPresence: number;
  STN7CF97_1A70SyringeHousingRoundness: number;
  STN9CF49_1bB10SyringeHousingPresence: number;
  STN9CF59_1bB1011SHOrientation: number;
  STN9CF69_1bB12SyringeHousingType: number;
  STN11CF1011_1B7LockoutShroudType: number;
  STN12CF712_1cB10ShroudPresence: number;
  STN12CF812_1aA70LSLegs: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Sh1PickAndPlace5220Datum {
  id: number;
  _NAME: string;
  _VALUE: number;
  _TIMESTAMP: string;
  _BATCHID: string;
}

export interface Sh1PickAndPlace5220PerBatchPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotal: number;
  STN3BadPartLockingSCGasket3_1aB10: number;
  STN4BadPartSyringeCarrier4_1aB10: number;
  STN6BadPartSpring6_1cB10: number;
  STN9BadPartSyringeHousing9_1bB10: number;
  STN5BadpartSpringType: number;
  STN11BadpartLockoutShroudType: number;
  STN12BadPartShroud12_1cB10: number;
  STN3CF13_1A70SCDamperGaskett: number;
  STN4CF24_1aA70SCTabsOK: number;
  STN4CF114_1aA70SCType: number;
  STN5CF125_1cA70SpringType: number;
  STN5CF135_1cA70SpringPresence: number;
  STN6CF36_1cB10SpringPresence: number;
  STN7CF97_1A70SyringeHousingRoundness: number;
  STN9CF49_1bB10SyringeHousingPresence: number;
  STN9CF59_1bB1011SHOrientation: number;
  STN9CF69_1bB12SyringeHousingType: number;
  STN11CF1011_1B7LockoutShroudType: number;
  STN12CF712_1cB10ShroudPresence: number;
  STN12CF812_1aA70LSLegs: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Sh1PickAndPlace5220PerShiftPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  ShiftTime: number;
  Shift: string;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotal: number;
  STN3BadPartLockingSCGasket3_1aB10: number;
  STN4BadPartSyringeCarrier4_1aB10: number;
  STN6BadPartSpring6_1cB10: number;
  STN9BadPartSyringeHousing9_1bB10: number;
  STN5BadpartSpringType: number;
  STN11BadpartLockoutShroudType: number;
  STN12BadPartShroud12_1cB10: number;
  STN3CF13_1A70SCDamperGaskett: number;
  STN4CF24_1aA70SCTabsOK: number;
  STN4CF114_1aA70SCType: number;
  STN5CF125_1cA70SpringType: number;
  STN5CF135_1cA70SpringPresence: number;
  STN6CF36_1cB10SpringPresence: number;
  STN7CF97_1A70SyringeHousingRoundness: number;
  STN9CF49_1bB10SyringeHousingPresence: number;
  STN9CF59_1bB1011SHOrientation: number;
  STN9CF69_1bB12SyringeHousingType: number;
  STN11CF1011_1B7LockoutShroudType: number;
  STN12CF712_1cB10ShroudPresence: number;
  STN12CF812_1aA70LSLegs: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Sh1PickAndPlace5220Shift {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  ShiftTime: number;
  Shift: string;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotalGood2: number;
  ShiftTotalBad2: number;
  ShiftTotal: number;
  STN3BadPartLockingSCGasket3_1aB10: number;
  STN4BadPartSyringeCarrier4_1aB10: number;
  STN6BadPartSpring6_1cB10: number;
  STN9BadPartSyringeHousing9_1bB10: number;
  STN5BadpartSpringType: number;
  STN11BadpartLockoutShroudType: number;
  STN12BadPartShroud12_1cB10: number;
  STN3CF13_1A70SCDamperGaskett: number;
  STN4CF24_1aA70SCTabsOK: number;
  STN4CF114_1aA70SCType: number;
  STN5CF125_1cA70SpringType: number;
  STN5CF135_1cA70SpringPresence: number;
  STN6CF36_1cB10SpringPresence: number;
  STN7CF97_1A70SyringeHousingRoundness: number;
  STN9CF49_1bB10SyringeHousingPresence: number;
  STN9CF59_1bB1011SHOrientation: number;
  STN9CF69_1bB12SyringeHousingType: number;
  STN11CF1011_1B7LockoutShroudType: number;
  STN12CF712_1cB10ShroudPresence: number;
  STN12CF812_1aA70LSLegs: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Sh2Assembly5308Batch {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotalGood2: number;
  BatchTotalBad2: number;
  BatchTotal: number;
  STN131BadPartsCarrierHousingShroud: number;
  STN141BadPartsGripperInsertion: number;
  STN151BadPartsSyringeHousing: number;
  STN171BadPartsInsertiong: number;
  STN181BadPartsKeyholeSpringShroud: number;
  STN201BadPartsBootRemover: number;
  STN211BadPartsBootRemover: number;
  STN221BadPartsPrint: number;
  STN241BadPartsSCDamper: number;
  STN13CF113_1aB10SyringeCarrierPresence: number;
  STN13CF513_1bB10SyringeHousingPresenc: number;
  STN13CF613_1bB11SyringeHousingHeight: number;
  STN13CF713_1cB10ShroudPresence: number;
  STN14CF1814_1B21GripperInsertion: number;
  STN15CF915_1aB10SyringeHousingPresenc: number;
  STN15CF1015_1aB11SyringeHousingHeight: number;
  STN17CF1117_1aA70InsertionForce: number;
  STN17CF12InsertionComplete: number;
  STN18CF1318_1bA70KeyholeOpen: number;
  STN18CF1418_1aB12SpringShroudPresence: number;
  STN18CF2118_1aB13SpringShroudHeight: number;
  STN18CF2318_1aB12SpringPresence: number;
  STN20CF2420_1B12BootRemoverType: number;
  STN20CF2520_1aB13BootRemoverPrint: number;
  STN21CF1521_1aB10BootRemoverPresence: number;
  STN21CF1621_1aB11BootRemoverHeight: number;
  STN24CF2224_1A70SCDamper: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Sh2Assembly5308Datum {
  id: number;
  _NAME: string;
  _VALUE: number;
  _TIMESTAMP: string;
  _BATCHID: string;
}

export interface Sh2Assembly5308PerBatchPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotal: number;
  STN131BadPartsCarrierHousingShroud: number;
  STN141BadPartsGripperInsertion: number;
  STN151BadPartsSyringeHousing: number;
  STN171BadPartsInsertiong: number;
  STN181BadPartsKeyholeSpringShroud: number;
  STN201BadPartsBootRemover: number;
  STN211BadPartsBootRemover: number;
  STN221BadPartsPrint: number;
  STN241BadPartsSCDamper: number;
  STN13CF113_1aB10SyringeCarrierPresence: number;
  STN13CF513_1bB10SyringeHousingPresenc: number;
  STN13CF613_1bB11SyringeHousingHeight: number;
  STN13CF713_1cB10ShroudPresence: number;
  STN14CF1814_1B21GripperInsertion: number;
  STN15CF915_1aB10SyringeHousingPresenc: number;
  STN15CF1015_1aB11SyringeHousingHeight: number;
  STN17CF1117_1aA70InsertionForce: number;
  STN17CF12InsertionComplete: number;
  STN18CF1318_1bA70KeyholeOpen: number;
  STN18CF1418_1aB12SpringShroudPresence: number;
  STN18CF2118_1aB13SpringShroudHeight: number;
  STN18CF2318_1aB12SpringPresence: number;
  STN20CF2420_1B12BootRemoverType: number;
  STN20CF2520_1aB13BootRemoverPrint: number;
  STN21CF1521_1aB10BootRemoverPresence: number;
  STN21CF1621_1aB11BootRemoverHeight: number;
  STN24CF2224_1A70SCDamper: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Sh2Assembly5308PerShiftPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  ShiftTime: number;
  Shift: string;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotal: number;
  STN131BadPartsCarrierHousingShroud: number;
  STN141BadPartsGripperInsertion: number;
  STN151BadPartsSyringeHousing: number;
  STN171BadPartsInsertiong: number;
  STN181BadPartsKeyholeSpringShroud: number;
  STN201BadPartsBootRemover: number;
  STN211BadPartsBootRemover: number;
  STN221BadPartsPrint: number;
  STN241BadPartsSCDamper: number;
  STN13CF113_1aB10SyringeCarrierPresence: number;
  STN13CF513_1bB10SyringeHousingPresenc: number;
  STN13CF613_1bB11SyringeHousingHeight: number;
  STN13CF713_1cB10ShroudPresence: number;
  STN14CF1814_1B21GripperInsertion: number;
  STN15CF915_1aB10SyringeHousingPresenc: number;
  STN15CF1015_1aB11SyringeHousingHeight: number;
  STN17CF1117_1aA70InsertionForce: number;
  STN17CF12InsertionComplete: number;
  STN18CF1318_1bA70KeyholeOpen: number;
  STN18CF1418_1aB12SpringShroudPresence: number;
  STN18CF2118_1aB13SpringShroudHeight: number;
  STN18CF2318_1aB12SpringPresence: number;
  STN20CF2420_1B12BootRemoverType: number;
  STN20CF2520_1aB13BootRemoverPrint: number;
  STN21CF1521_1aB10BootRemoverPresence: number;
  STN21CF1621_1aB11BootRemoverHeight: number;
  STN24CF2224_1A70SCDamper: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Sh2Assembly5308Shift {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  ShiftTime: number;
  Shift: string;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotalGood2: number;
  ShiftTotalBad2: number;
  ShiftTotal: number;
  STN131BadPartsCarrierHousingShroud: number;
  STN141BadPartsGripperInsertion: number;
  STN151BadPartsSyringeHousing: number;
  STN171BadPartsInsertiong: number;
  STN181BadPartsKeyholeSpringShroud: number;
  STN201BadPartsBootRemover: number;
  STN211BadPartsBootRemover: number;
  STN221BadPartsPrint: number;
  STN241BadPartsSCDamper: number;
  STN13CF113_1aB10SyringeCarrierPresence: number;
  STN13CF513_1bB10SyringeHousingPresenc: number;
  STN13CF613_1bB11SyringeHousingHeight: number;
  STN13CF713_1cB10ShroudPresence: number;
  STN14CF1814_1B21GripperInsertion: number;
  STN15CF915_1aB10SyringeHousingPresenc: number;
  STN15CF1015_1aB11SyringeHousingHeight: number;
  STN17CF1117_1aA70InsertionForce: number;
  STN17CF12InsertionComplete: number;
  STN18CF1318_1bA70KeyholeOpen: number;
  STN18CF1418_1aB12SpringShroudPresence: number;
  STN18CF2118_1aB13SpringShroudHeight: number;
  STN18CF2318_1aB12SpringPresence: number;
  STN20CF2420_1B12BootRemoverType: number;
  STN20CF2520_1aB13BootRemoverPrint: number;
  STN21CF1521_1aB10BootRemoverPresence: number;
  STN21CF1621_1aB11BootRemoverHeight: number;
  STN24CF2224_1A70SCDamper: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Sh2PickAndPlace5307Batch {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotalGood2: number;
  BatchTotalBad2: number;
  BatchTotal: number;
  STN3BadPartSCDamper: number;
  STN4BadPartSCTabsType: number;
  STN6BadPartSpring: number;
  STN9BadPartSyringeHousing: number;
  STN5BadpartSpringType: number;
  STN11BadpartLockoutShroudType: number;
  STN12BadPartLockoutShroud: number;
  STN3CF13_1A70SCDamperGasket: number;
  STN4CF24_1aA70SCTabsOK: number;
  STN4CF114_1aA70SCType: number;
  STN5CF125_1cA70SpringType: number;
  STN5CF135_1cA70SpringPresence: number;
  STN6CF36_1cB10SpringPresence: number;
  STN7CF97_1A70SyringeHousingRoundness: number;
  STN9CF49_1bB10SyringeHousingPresence: number;
  STN9CF59_1bB1011SHOrientation: number;
  STN9CF69_1bB12SyringeHousingType: number;
  STN11CF1011_1B7LockoutShroudType: number;
  STN12CF712_1cB10ShroudPresence: number;
  STN12CF812_1aA70LSLegs: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Sh2PickAndPlace5307Datum {
  id: number;
  _NAME: string;
  _VALUE: number;
  _TIMESTAMP: string;
  _BATCHID: string;
}

export interface Sh2PickAndPlace5307PerBatchPerCycle {
  RowID: number;
  CreatedOn: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  ActualProduct: string;
  MachineID: string;
  BatchTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  BatchTotalGood: number;
  BatchTotalBad: number;
  BatchPresetGoodParts: number;
  BatchGoodPartsAssembled: number;
  BatchPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  BatchGood: number;
  BatchBad: number;
  BatchEfficiency: number;
  BatchTotal: number;
  STN3BadPartSCDamper: number;
  STN4BadPartSCTabsType: number;
  STN6BadPartSpring: number;
  STN9BadPartSyringeHousing: number;
  STN5BadpartSpringType: number;
  STN11BadpartLockoutShroudType: number;
  STN12BadPartLockoutShroud: number;
  STN3CF13_1A70SCDamperGasket: number;
  STN4CF24_1aA70SCTabsOK: number;
  STN4CF114_1aA70SCType: number;
  STN5CF125_1cA70SpringType: number;
  STN5CF135_1cA70SpringPresence: number;
  STN6CF36_1cB10SpringPresence: number;
  STN7CF97_1A70SyringeHousingRoundness: number;
  STN9CF49_1bB10SyringeHousingPresence: number;
  STN9CF59_1bB1011SHOrientation: number;
  STN9CF69_1bB12SyringeHousingType: number;
  STN11CF1011_1B7LockoutShroudType: number;
  STN12CF712_1cB10ShroudPresence: number;
  STN12CF812_1aA70LSLegs: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  BatchPercentComplete: number;
}

export interface Sh2PickAndPlace5307PerShiftPerCycle {
  RowID: number;
  CreatedOn: string;
  ActualProduct: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  MachineID: string;
  Shift: string;
  ShiftTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssemble: number;
  ShiftPartsToAssemble: number;
  StartBatchDate: string;
  EndBatchDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotal: number;
  STN3BadPartSCDamper: number;
  STN4BadPartSCTabsType: number;
  STN6BadPartSpring: number;
  STN9BadPartSyringeHousing: number;
  STN5BadpartSpringType: number;
  STN11BadpartLockoutShroudType: number;
  STN12BadPartLockoutShroud: number;
  STN3CF13_1A70SCDamperGasket: number;
  STN4CF24_1aA70SCTabsOK: number;
  STN4CF114_1aA70SCType: number;
  STN5CF125_1cA70SpringType: number;
  STN5CF135_1cA70SpringPresence: number;
  STN6CF36_1cB10SpringPresence: number;
  STN7CF97_1A70SyringeHousingRoundness: number;
  STN9CF49_1bB10SyringeHousingPresence: number;
  STN9CF59_1bB1011SHOrientation: number;
  STN9CF69_1bB12SyringeHousingType: number;
  STN11CF1011_1B7LockoutShroudType: number;
  STN12CF712_1cB10ShroudPresence: number;
  STN12CF812_1aA70LSLegs: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Sh2PickAndPlace5307Shift {
  RowID: number;
  CreatedOn: string;
  ActualProduct: string;
  ExportDateStamp: string;
  ExportTimeStamp: string;
  MachineID: string;
  Shift: string;
  ShiftTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssemble: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotalGood2: number;
  ShiftTotalBad2: number;
  ShiftTotal: number;
  STN3BadPartSCDamper: number;
  STN4BadPartSCTabsType: number;
  STN6BadPartSpring: number;
  STN9BadPartSyringeHousing: number;
  STN5BadpartSpringType: number;
  STN11BadpartLockoutShroudType: number;
  STN12BadPartLockoutShroud: number;
  STN3CF13_1A70SCDamperGasket: number;
  STN4CF24_1aA70SCTabsOK: number;
  STN4CF114_1aA70SCType: number;
  STN5CF125_1cA70SpringType: number;
  STN5CF135_1cA70SpringPresence: number;
  STN6CF36_1cB10SpringPresence: number;
  STN7CF97_1A70SyringeHousingRoundness: number;
  STN9CF49_1bB10SyringeHousingPresence: number;
  STN9CF59_1bB1011SHOrientation: number;
  STN9CF69_1bB12SyringeHousingType: number;
  STN11CF1011_1B7LockoutShroudType: number;
  STN12CF712_1cB10ShroudPresence: number;
  STN12CF812_1aA70LSLegs: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface Shift {
  ShiftID: number;
  ShiftName: string;
  ShiftStartTime: string;
  ShiftEndTime: string;
}

export interface ShiftHourReport {
  RowID: number;
  CreatedOn: string;
  Machine: string;
  MachineID: number;
  BatchID: string;
  RecordedOnDate: string;
  RecordedOnHour: number;
  DateHour: string;
  PlannedRunTime: number;
  ActualRunTime: number;
  ShiftETA: string;
  Shift: string;
  ShiftCompletedPercent: number;
  ShiftTotal: number;
  ShiftTotalBad: number;
  ShiftTotalGood: number;
  ShiftGoodPercent: number;
  RejectRate: number;
  ShiftBadPercent: number;
  TotalCycles: number;
  Availability: number;
  Performance: number;
  Quality: number;
  OEE: number;
  ShiftEfficiencyPercent: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  TotalStopTime: number;
  StopTime: number;
  AlarmTime: number;
  CleaningTime: number;
  LunchTime: number;
  BreakTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  MissingMaterialTime: number;
  RestartTime: number;
  ShiftPercentCompletedH: number;
  PlannedRunTimeH: number;
  ActualRunTimeH: number;
  ShiftTotalH: number;
  ShiftTotalBadH: number;
  ShiftTotalGoodH: number;
  TotalAlarmsH: number;
  GuardDoorOpenedH: number;
  TotalStopTimeH: number;
  StopTimeH: number;
  AlarmTimeH: number;
  CleaningTimeH: number;
  LunchTimeH: number;
  BreakTimeH: number;
  ChangeOverTimeH: number;
  MaintenanceTimeH: number;
  MissingMaterialTimeH: number;
  RestartTimeH: number;
}

export interface ShiftHourReport1 {
  LastRowID: number;
  Machine: string;
  MachineID: number;
  Shift: string;
  BatchID: string;
  WeekDay: string;
  WeekRange: string;
  Date: string;
  Shiftc: string;
  Rejects: number;
  GoodDevices: number;
  ActualYield: number;
  PcsPerHour: number;
  TargetAt70Percent10080: number;
  DownTime: string;
  MachineAutoStop: string;
  StopTime: string;
  CleaningTime: string;
  LunchTime: string;
  BreakTime: string;
  ChangeOverTime: string;
  MaintenanceTime: string;
  MissingMaterialTime: string;
}

export interface ShiftHourReportFm1Assembly5201 {

}

export interface ShiftHourReportFm1PickAndPlace5219 {

}

export interface ShiftHourReportFm2Assembly5306 {

}

export interface ShiftHourReportFm2PickAndPlace5305 {

}

export interface ShiftHourReportLastRowId {
  LastRowID: number;
  Machine: string;
  MachineID: number;
  Shift: string;
  BatchID: string;
  WeekDay: string;
  WeekRange: string;
  Date: string;
  Shiftc: string;
  Rejects: number;
  GoodDevices: number;
  ActualYield: number;
  PcsPerHour: number;
  TargetAt70Percent10080: number;
  DownTime: string;
  MachineAutoStop: string;
  StopTime: string;
  CleaningTime: string;
  LunchTime: string;
  BreakTime: string;
  ChangeOverTime: string;
  MaintenanceTime: string;
  MissingMaterialTime: string;
}

export interface ShiftHourReportSh1Assembly5202 {

}

export interface ShiftHourReportSh1PickAndPlace5220 {

}

export interface ShiftHourReportSh2Assembly5308 {

}

export interface ShiftHourReportSh2PickAndPlace5307 {

}

export interface ShiftReportDashTimer {
  MachineID: number;
  BatchID: string;
  Shift: string;
  DateHour: string;
  RecordedOn: number;
  TagType: string;
  TagName: string;
  Value: number;
  ValueChar: string;
  ValueH: number;
  ValueHChar: string;
  Indicator: string;
}

export interface ShiftReportDashTimersGrouped {
  MachineID: number;
  BatchID: string;
  Shift: string;
  TagName: string;
  Value: number;
  ValueChar: string;
}

export interface ShiftReportDashTotalGodBad {
  MachineID: number;
  BatchID: string;
  Shift: string;
  DateHour: string;
  RecordedOn: number;
  TagType: string;
  TagName: string;
  Value: number;
  ValueH: number;
  Indicator: string;
}

export interface SpBacthReportDash {
  RowID: number;
  CreatedOn: string;
  Machine: string;
  MachineID: number;
  Shift: string;
  BatchID: string;
  RecordedOnDate: string;
  RecordedOnHour: number;
  DateHour: string;
  PlannedRunTime: number;
  ActualRunTime: number;
  BatchETA: string;
  BatchETAs: string;
  BatchCompletedPercent: number;
  BatchTotal: number;
  BatchTotalBad: number;
  BatchTotalGood: number;
  BatchGoodPercent: number;
  RejectRate: number;
  BatchBadPercent: number;
  TotalCycles: number;
  Availability: number;
  Performance: number;
  Quality: number;
  OEE: number;
  BatchEfficiencyPercent: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  TotalStopTime: number;
  StopTime: number;
  AlarmTime: number;
  CleaningTime: number;
  LunchTime: number;
  BreakTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  MissingMaterialTime: number;
  RestartTime: number;
  BatchPercentCompletedH: number;
  PlannedRunTimeH: number;
  ActualRunTimeH: number;
  BatchTotalH: number;
  BatchTotalBadH: number;
  BatchTotalGoodH: number;
  TotalAlarmsH: number;
  GuardDoorOpenedH: number;
  TotalStopTimeH: number;
  StopTimeH: number;
  AlarmTimeH: number;
  CleaningTimeH: number;
  LunchTimeH: number;
  BreakTimeH: number;
  ChangeOverTimeH: number;
  MaintenanceTimeH: number;
  MissingMaterialTimeH: number;
  RestartTimeH: number;
}

export interface SpBacthReportHeader {
  RowID: number;
  CreatedOn: string;
  BatchStartDate: string;
  BatchEndDate: string;
  Machine: string;
  MachineID: number;
  BatchID: string;
  RecordedOnDate: string;
  RecordedOnDateChar: string;
  RecordedOnHour: number;
  DateHour: string;
  PlannedRunTime: number;
  ActualRunTime: number;
  BatchETA: string;
  BatchETAs: string;
  BatchCompletedPercent: number;
  BatchTotal: number;
  BatchTotalBad: number;
  BatchTotalGood: number;
  BatchGoodPercent: number;
  RejectRate: number;
  BatchBadPercent: number;
  TotalCycles: number;
  ActualYield: number;
  ActualYieldh: number;
  PcsPerHour: number;
  PcsPerHourPercent: number;
  Availability: number;
  Performance: number;
  Quality: number;
  OEE: number;
  BatchEfficiencyPercent: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  TotalStopTime: number;
  StopTime: number;
  AlarmTime: number;
  CleaningTime: number;
  LunchTime: number;
  BreakTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  MissingMaterialTime: number;
  RestartTime: number;
  BatchPercentCompletedH: number;
  PlannedRunTimeH: number;
  ActualRunTimeH: number;
  BatchTotalH: number;
  BatchTotalBadH: number;
  BatchTotalGoodH: number;
  TotalAlarmsH: number;
  GuardDoorOpenedH: number;
  TotalStopTimeH: number;
  StopTimeH: number;
  AlarmTimeH: number;
  CleaningTimeH: number;
  LunchTimeH: number;
  BreakTimeH: number;
  ChangeOverTimeH: number;
  MaintenanceTimeH: number;
  MissingMaterialTimeH: number;
  RestartTimeH: number;
}

export interface SpBacthReportHeaderRow {
  RowID: number;
  CreatedOn: string;
  BatchStartDate: string;
  BatchEndDate: string;
  Machine: string;
  MachineID: number;
  BatchID: string;
  RecordedOnDate: string;
  RecordedOnHour: number;
  DateHour: string;
  PlannedRunTime: number;
  ActualRunTime: number;
  BatchETA: string;
  BatchETAs: string;
  BatchCompletedPercent: number;
  BatchTotal: number;
  BatchTotalBad: number;
  BatchTotalGood: number;
  BatchGoodPercent: number;
  RejectRate: number;
  BatchBadPercent: number;
  TotalCycles: number;
  Availability: number;
  Performance: number;
  Quality: number;
  OEE: number;
  BatchEfficiencyPercent: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  TotalStopTime: number;
  StopTime: number;
  AlarmTime: number;
  CleaningTime: number;
  LunchTime: number;
  BreakTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  MissingMaterialTime: number;
  RestartTime: number;
  BatchPercentCompletedH: number;
  PlannedRunTimeH: number;
  ActualRunTimeH: number;
  BatchTotalH: number;
  BatchTotalBadH: number;
  BatchTotalGoodH: number;
  TotalAlarmsH: number;
  GuardDoorOpenedH: number;
  TotalStopTimeH: number;
  StopTimeH: number;
  AlarmTimeH: number;
  CleaningTimeH: number;
  LunchTimeH: number;
  BreakTimeH: number;
  ChangeOverTimeH: number;
  MaintenanceTimeH: number;
  MissingMaterialTimeH: number;
  RestartTimeH: number;
}

export interface SpBatchHourValuesGrid {
  BatchID: string;
  Machine: string;
  MachineID: number;
  TagName: string;
  TagDescription: string;
  Value: number;
  ValueH: number;
}

export interface SpBatchList {
  BatchID: string;
  MachineID: number;
  BatchStartDate: string;
  BatchEndDate: string;
  LastRowID: number;
  BatchCompletedPercent: number;
  BatchTotalGood: number;
}

export interface SpClearDataTable {

}

export interface SpHourValue {
  CreatedOn: string;
  BatchID: string;
  Shift: string;
  DateHour: string;
  Machine: string;
  MachineID: number;
  TagID: number;
  TagGroup: string;
  TagType: string;
  TagName: string;
  TagDescription: string;
  Value: number;
  ValueH: number;
}

export interface SpHourValuesGrid {
  BatchID: string;
  Shift: string;
  Machine: string;
  MachineID: number;
  TagID: number;
  TagGroup: string;
  TagType: string;
  TagName: string;
  TagDescription: string;
  Value: number;
  ValueH: number;
}

export interface SpHourValuesShift {
  CreatedOn: string;
  BatchID: string;
  Shift: string;
  DateHour: string;
  Machine: string;
  MachineID: number;
  TagID: number;
  TagGroup: string;
  TagType: string;
  TagName: string;
  TagDescription: string;
  Value: number;
  ValueH: number;
}

export interface SpPopulateHourValue {

}

export interface SpShiftHourValuesGrid {
  BatchID: string;
  Shift: string;
  TagName: string;
  TagDescription: string;
  Value: number;
  ValueH: number;
}

export interface SpShiftReportDash {
  MachineID: number;
  Machine: string;
  BatchID: string;
  Shift: string;
  RecordedOnDate: string;
  RecordedOnHour: number;
  DateHour: string;
  PlannedRunTime: number;
  ActualRunTime: number;
  ShiftETA: string;
  ShiftCompletedPercent: number;
  ShiftTotal: number;
  ShiftTotalBad: number;
  ShiftTotalGood: number;
  ShiftGoodPercent: number;
  RejectRate: number;
  ShiftBadPercent: number;
  TotalCycles: number;
  Availability: number;
  Performance: number;
  Quality: number;
  OEE: number;
  ShiftEfficiencyPercent: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  TotalStopTime: number;
  StopTime: number;
  AlarmTime: number;
  CleaningTime: number;
  LunchTime: number;
  BreakTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  MissingMaterialTime: number;
  RestartTime: number;
  ShiftPercentCompletedH: number;
  PlannedRunTimeH: number;
  ActualRunTimeH: number;
  ShiftTotalH: number;
  ShiftTotalBadH: number;
  ShiftTotalGoodH: number;
  TotalAlarmsH: number;
  GuardDoorOpenedH: number;
  TotalStopTimeH: number;
  StopTimeH: number;
  AlarmTimeH: number;
  CleaningTimeH: number;
  LunchTimeH: number;
  BreakTimeH: number;
  ChangeOverTimeH: number;
  MaintenanceTimeH: number;
  MissingMaterialTimeH: number;
  RestartTimeH: number;
}

export interface SpShiftReportHeader {
  RowID: number;
  BatchID: string;
  CreatedOn: string;
  Machine: string;
  MachineID: number;
  RecordedOnDate: string;
  RecordedOnHour: number;
  DateHour: string;
  Shift: string;
  PlannedRunTime: number;
  ActualRunTime: number;
  ShiftETA: string;
  ShiftETAs: string;
  ShiftCompletedPercent: number;
  ShiftTotal: number;
  ShiftTotalBad: number;
  ShiftTotalGood: number;
  ShiftGoodPercent: number;
  RejectRate: number;
  ShiftBadPercent: number;
  TotalCycles: number;
  ActualYield: number;
  ActualYieldh: number;
  PcsPerHour: number;
  PcsPerHourPercent: number;
  Availability: number;
  Performance: number;
  Quality: number;
  OEE: number;
  ShiftEfficiencyPercent: number;
  TotalStopTime: number;
  TotalStopTimeChar: string;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  StopTime: number;
  AlarmTime: number;
  CleaningTime: number;
  LunchTime: number;
  BreakTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  MissingMaterialTime: number;
  RestartTime: number;
  ShiftPercentCompletedH: number;
  PlannedRunTimeH: number;
  ActualRunTimeH: number;
  ShiftTotalH: number;
  ShiftTotalBadH: number;
  ShiftTotalGoodH: number;
  TotalAlarmsH: number;
  GuardDoorOpenedH: number;
  TotalStopTimeH: number;
  TotalStopTimeHChar: string;
  StopTimeH: number;
  AlarmTimeH: number;
  CleaningTimeH: number;
  LunchTimeH: number;
  BreakTimeH: number;
  ChangeOverTimeH: number;
  MaintenanceTimeH: number;
  MissingMaterialTimeH: number;
  RestartTimeH: number;
}

export interface SpStopTimeChartSource {
  BatchID: string;
  MachineID: number;
  TagName: string;
  Value: number;
  TotalStopTime: number;
  PercentageStopTime: number;
}

export interface Tag {
  TagID: number;
  Tag1: string;
  Machine: string;
  MachineID: number;
  TagGroup: string;
  TagType: string;
  TagName: string;
  TagDescription: string;
}

export interface TestSh1PickAndPlace5220ShiftPerHour {
  RecordedOnDate: string;
  RecordedOnHour: number;
  DateHour: string;
  ActualProduct: string;
  MachineID: string;
  Shift: string;
  ShiftTime: number;
  AutomaticTime: number;
  AlarmTime: number;
  StopTime: number;
  RestartTime: number;
  TotalCycles: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  LunchTime: number;
  BreakTime: number;
  CleaningTime: number;
  MissingMaterialTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  ShiftTotalGood: number;
  ShiftTotalBad: number;
  ShiftPresetGoodParts: number;
  ShiftGoodPartsAssembled: number;
  ShiftPartsToAssemble: number;
  StartShiftDate: string;
  EndShiftDate: string;
  GoodPartsTrack1: number;
  BadPartsTrack1: number;
  ShiftGood: number;
  ShiftBad: number;
  ShiftEfficiency: number;
  ShiftTotalGood2: number;
  ShiftTotalBad2: number;
  ShiftTotal: number;
  STN3BadPartLockingSCGasket3_1aB10: number;
  STN4BadPartSyringeCarrier4_1aB10: number;
  STN6BadPartSpring6_1cB10: number;
  STN9BadPartSyringeHousing9_1bB10: number;
  STN5BadpartSpringType: number;
  STN11BadpartLockoutShroudType: number;
  STN12BadPartShroud12_1cB10: number;
  STN3CF13_1A70SCDamperGaskett: number;
  STN4CF24_1aA70SCTabsOK: number;
  STN4CF114_1aA70SCType: number;
  STN5CF125_1cA70SpringType: number;
  STN5CF135_1cA70SpringPresence: number;
  STN6CF36_1cB10SpringPresence: number;
  STN7CF97_1A70SyringeHousingRoundness: number;
  STN9CF49_1bB10SyringeHousingPresence: number;
  STN9CF59_1bB1011SHOrientation: number;
  STN9CF69_1bB12SyringeHousingType: number;
  STN11CF1011_1B7LockoutShroudType: number;
  STN12CF712_1cB10ShroudPresence: number;
  STN12CF812_1aA70LSLegs: number;
  OEE_Availability: number;
  OEE_Performance: number;
  OEE_Quality: number;
  OEE_OEE: number;
  ShiftPercentComplete: number;
}

export interface VBacthReportHeaderRow {
  RowID: number;
  CreatedOn: string;
  Machine: string;
  MachineID: number;
  BatchID: string;
  RecordedOnDate: string;
  RecordedOnHour: number;
  DateHour: string;
  PlannedRunTime: number;
  ActualRunTime: number;
  BatchETA: string;
  BatchCompletedPercent: number;
  BatchTotal: number;
  BatchTotalBad: number;
  BatchTotalGood: number;
  BatchGoodPercent: number;
  RejectRate: number;
  BatchBadPercent: number;
  TotalCycles: number;
  Availability: number;
  Performance: number;
  Quality: number;
  OEE: number;
  BatchEfficiencyPercent: number;
  TotalAlarms: number;
  GuardDoorOpened: number;
  AutomaticStarts: number;
  TotalStopTime: number;
  StopTime: number;
  AlarmTime: number;
  CleaningTime: number;
  LunchTime: number;
  BreakTime: number;
  ChangeOverTime: number;
  MaintenanceTime: number;
  MissingMaterialTime: number;
  RestartTime: number;
  BatchPercentCompletedH: number;
  PlannedRunTimeH: number;
  ActualRunTimeH: number;
  BatchTotalH: number;
  BatchTotalBadH: number;
  BatchTotalGoodH: number;
  TotalAlarmsH: number;
  GuardDoorOpenedH: number;
  TotalStopTimeH: number;
  StopTimeH: number;
  AlarmTimeH: number;
  CleaningTimeH: number;
  LunchTimeH: number;
  BreakTimeH: number;
  ChangeOverTimeH: number;
  MaintenanceTimeH: number;
  MissingMaterialTimeH: number;
  RestartTimeH: number;
}

export interface VChartDatum {
  RowID: number;
  TagID: number;
  CreatedOn: string;
  BatchID: string;
  Shift: string;
  DateHour: string;
  Machine: string;
  MachineID: number;
  TagGroup: string;
  TagType: string;
  TagName: string;
  TagDescription: string;
  Value: number;
  ValueH: number;
}
