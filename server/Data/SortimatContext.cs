using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using DataAnalysis.Models.Sortimat;

namespace DataAnalysis.Data
{
    public partial class SortimatContext : Microsoft.EntityFrameworkCore.DbContext
    {
        private readonly IHttpContextAccessor httpAccessor;

        public SortimatContext(IHttpContextAccessor httpAccessor, DbContextOptions<SortimatContext> options):base(options)
        {
            this.httpAccessor = httpAccessor;
        }

        public SortimatContext(IHttpContextAccessor httpAccessor)
        {
            this.httpAccessor = httpAccessor;
        }

        partial void OnModelBuilding(ModelBuilder builder);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<DataAnalysis.Models.Sortimat.DashDatum>().HasKey(table => new {
              table.MachineID, table.RowID
            });

            builder.Entity<DataAnalysis.Models.Sortimat.BatchHourReport>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1Assembly5201Batch>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1Assembly5201PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1Assembly5201PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1Assembly5201Shift>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1AssemblyReportHourShift>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219Batch>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219ReportHourShift>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219Shift>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2Assembly5306Batch>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2Assembly5306PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2Assembly5306PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2Assembly5306Shift>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305Batch>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305Shift>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.HourValue>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Machine>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1Assembly5202Batch>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1Assembly5202PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1Assembly5202PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1Assembly5202Shift>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220Batch>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220Shift>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2Assembly5308Batch>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2Assembly5308PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2Assembly5308PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2Assembly5308Shift>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307Batch>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307Shift>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");

            builder.Entity<DataAnalysis.Models.Sortimat.ShiftHourReport>()
                  .Property(p => p.CreatedOn)
                  .HasDefaultValueSql("(getdate())");


            builder.Entity<DataAnalysis.Models.Sortimat.AppDailyProductionShift>()
                  .Property(p => p.Date)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.BatchHourReport>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.BatchHourReport>()
                  .Property(p => p.RecordedOnDate)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.BatchHourReport>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.BatchHourReport>()
                  .Property(p => p.BatchETA)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.BatchReportDashTimer>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.ChartDatum>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.DashDatum>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.DashDatum>()
                  .Property(p => p.RecordedOnDate)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.DashDatum>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.DashDatum>()
                  .Property(p => p.BatchETA)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Date>()
                  .Property(p => p.Date1)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Date>()
                  .Property(p => p.FirstDayOfMonth)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.Date>()
                  .Property(p => p.LastDayOfMonth)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.Date>()
                  .Property(p => p.FirstDayOfQuarter)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.Date>()
                  .Property(p => p.LastDayOfQuarter)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.Date>()
                  .Property(p => p.FirstDayOfYear)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.Date>()
                  .Property(p => p.LastDayOfYear)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1Assembly5201Batch>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1Assembly5201Batch>()
                  .Property(p => p.BatchETA)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1Assembly5201Datum>()
                  .Property(p => p._TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1Assembly5201PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1Assembly5201PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1Assembly5201Shift>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1Assembly5201Shift>()
                  .Property(p => p.ShiftETA)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1AssemblyReportHourShift>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1AssemblyReportHourShift>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219Batch>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219Datum>()
                  .Property(p => p._TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219ReportHourShift>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219ReportHourShift>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219Shift>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2Assembly5306Batch>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2Assembly5306Datum>()
                  .Property(p => p._TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2Assembly5306PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2Assembly5306PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2Assembly5306Shift>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305Batch>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305Datum>()
                  .Property(p => p._TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305Shift>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.HourValue>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.HourValue>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Machine>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Alarming_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Reject_Percentage_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Run_Time_Efficiency_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Running_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Shift_Date_Day_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Shift_Date_Month_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Shift_Date_Year_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Hour_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Min_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Shift_StartTime_Sec_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Hour_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Efficiency_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Min_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Shift_StopTime_Sec_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Stopped_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Total_Alarms_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Total_Good_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Total_Reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Total_Shift_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Good_Percentage_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Miscel_Reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_OEE_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Print_reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Rated_Speed_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Recipe_Name_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle>()
                  .Property(p => p.PAD_BR_OSI_PI_Current_Shift_Register_Reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Alarming_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Reject_Percentage_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Run_Time_Efficiency_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Running_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Day_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Month_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Shift_Date_Year_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Hour_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Min_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Shift_StartTime_Sec_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Hour_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Efficiency_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Min_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Shift_StopTime_Sec_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Stopped_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Total_Alarms_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Total_Good_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Total_Reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Total_Shift_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Good_Percentage_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Miscel_Reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_OEE_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Print_reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Rated_Speed_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Recipe_Name_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle>()
                  .Property(p => p.PAD_LPC_OSI_PI_Current_Shift_Register_Reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Alarming_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Reject_Percentage_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Run_Time_Efficiency_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Running_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Shift_Date_Day_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Shift_Date_Month_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Shift_Date_Year_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Hour_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Min_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Sec_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Hour_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Efficiency_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Min_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Sec_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Stopped_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Total_Alarms_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Total_Good_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Total_Reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Total_Shift_Time_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Good_Percentage_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Miscel_Reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_OEE_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Print_reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Rated_Speed_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Recipe_Name_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle>()
                  .Property(p => p.PAD_SH_OSI_PI_Current_Shift_Register_Reject_TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1Assembly5202Batch>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1Assembly5202Datum>()
                  .Property(p => p._TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1Assembly5202PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1Assembly5202PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1Assembly5202Shift>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220Batch>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220Datum>()
                  .Property(p => p._TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220Shift>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2Assembly5308Batch>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2Assembly5308Datum>()
                  .Property(p => p._TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2Assembly5308PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2Assembly5308PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2Assembly5308Shift>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307Batch>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307Datum>()
                  .Property(p => p._TIMESTAMP)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307PerBatchPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307PerShiftPerCycle>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307Shift>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Shift>()
                  .Property(p => p.ShiftStartTime)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.Shift>()
                  .Property(p => p.ShiftEndTime)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.ShiftHourReport>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.ShiftHourReport>()
                  .Property(p => p.RecordedOnDate)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.ShiftHourReport>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.ShiftHourReport>()
                  .Property(p => p.ShiftETA)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.ShiftHourReport1>()
                  .Property(p => p.Date)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.ShiftHourReportLastRowId>()
                  .Property(p => p.Date)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.ShiftReportDashTimer>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.ShiftReportDashTotalGodBad>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportDash>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportDash>()
                  .Property(p => p.RecordedOnDate)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportDash>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportDash>()
                  .Property(p => p.BatchETA)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeader>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeader>()
                  .Property(p => p.BatchStartDate)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeader>()
                  .Property(p => p.BatchEndDate)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeader>()
                  .Property(p => p.RecordedOnDate)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeader>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeader>()
                  .Property(p => p.BatchETA)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeaderRow>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeaderRow>()
                  .Property(p => p.BatchStartDate)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeaderRow>()
                  .Property(p => p.BatchEndDate)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeaderRow>()
                  .Property(p => p.RecordedOnDate)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeaderRow>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBacthReportHeaderRow>()
                  .Property(p => p.BatchETA)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBatchList>()
                  .Property(p => p.BatchStartDate)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpBatchList>()
                  .Property(p => p.BatchEndDate)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpHourValue>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpHourValue>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpHourValuesShift>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpHourValuesShift>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpShiftReportDash>()
                  .Property(p => p.RecordedOnDate)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.SpShiftReportDash>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpShiftReportDash>()
                  .Property(p => p.ShiftETA)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpShiftReportHeader>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpShiftReportHeader>()
                  .Property(p => p.RecordedOnDate)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.SpShiftReportHeader>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.SpShiftReportHeader>()
                  .Property(p => p.ShiftETA)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.TestSh1PickAndPlace5220ShiftPerHour>()
                  .Property(p => p.RecordedOnDate)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.TestSh1PickAndPlace5220ShiftPerHour>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.VBacthReportHeaderRow>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.VBacthReportHeaderRow>()
                  .Property(p => p.RecordedOnDate)
                  .HasColumnType("date");

            builder.Entity<DataAnalysis.Models.Sortimat.VBacthReportHeaderRow>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.VBacthReportHeaderRow>()
                  .Property(p => p.BatchETA)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.VChartDatum>()
                  .Property(p => p.CreatedOn)
                  .HasColumnType("datetime");

            builder.Entity<DataAnalysis.Models.Sortimat.VChartDatum>()
                  .Property(p => p.DateHour)
                  .HasColumnType("datetime");

            this.OnModelBuilding(builder);
        }


        public DbSet<DataAnalysis.Models.Sortimat.AppDailyProductionShift> AppDailyProductionShifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.BatchHourReport> BatchHourReports
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.BatchReportDashTimer> BatchReportDashTimers
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.BatchReportDashTimersGrouped> BatchReportDashTimersGroupeds
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.ChartDatum> ChartData
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.DailyProductionShift> DailyProductionShifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.DashDatum> DashData
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Date> Dates
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1Assembly5201Batch> Fm1Assembly5201Batches
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1Assembly5201Datum> Fm1Assembly5201Data
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1Assembly5201PerBatchPerCycle> Fm1Assembly5201PerBatchPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1Assembly5201PerShiftPerCycle> Fm1Assembly5201PerShiftPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1Assembly5201Shift> Fm1Assembly5201Shifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1AssemblyReportHourShift> Fm1AssemblyReportHourShifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219Batch> Fm1PickAndPlace5219Batches
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219Datum> Fm1PickAndPlace5219Data
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219PerBatchPerCycle> Fm1PickAndPlace5219PerBatchPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219PerShiftPerCycle> Fm1PickAndPlace5219PerShiftPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219ReportHourShift> Fm1PickAndPlace5219ReportHourShifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm1PickAndPlace5219Shift> Fm1PickAndPlace5219Shifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm2Assembly5306Batch> Fm2Assembly5306Batches
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm2Assembly5306Datum> Fm2Assembly5306Data
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm2Assembly5306PerBatchPerCycle> Fm2Assembly5306PerBatchPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm2Assembly5306PerShiftPerCycle> Fm2Assembly5306PerShiftPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm2Assembly5306Shift> Fm2Assembly5306Shifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305Batch> Fm2PickAndPlace5305Batches
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305Datum> Fm2PickAndPlace5305Data
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305PerBatchPerCycle> Fm2PickAndPlace5305PerBatchPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305PerShiftPerCycle> Fm2PickAndPlace5305PerShiftPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Fm2PickAndPlace5305Shift> Fm2PickAndPlace5305Shifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.HourValue> HourValues
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Machine> Machines
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.OmPadBrPerShiftPerCycle> OmPadBrPerShiftPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.OmPadLpcPerShiftPerCycle> OmPadLpcPerShiftPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.OmPadShPerShiftPerCycle> OmPadShPerShiftPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh1Assembly5202Batch> Sh1Assembly5202Batches
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh1Assembly5202Datum> Sh1Assembly5202Data
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh1Assembly5202PerBatchPerCycle> Sh1Assembly5202PerBatchPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh1Assembly5202PerShiftPerCycle> Sh1Assembly5202PerShiftPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh1Assembly5202Shift> Sh1Assembly5202Shifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220Batch> Sh1PickAndPlace5220Batches
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220Datum> Sh1PickAndPlace5220Data
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220PerBatchPerCycle> Sh1PickAndPlace5220PerBatchPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220PerShiftPerCycle> Sh1PickAndPlace5220PerShiftPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh1PickAndPlace5220Shift> Sh1PickAndPlace5220Shifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh2Assembly5308Batch> Sh2Assembly5308Batches
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh2Assembly5308Datum> Sh2Assembly5308Data
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh2Assembly5308PerBatchPerCycle> Sh2Assembly5308PerBatchPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh2Assembly5308PerShiftPerCycle> Sh2Assembly5308PerShiftPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh2Assembly5308Shift> Sh2Assembly5308Shifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307Batch> Sh2PickAndPlace5307Batches
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307Datum> Sh2PickAndPlace5307Data
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307PerBatchPerCycle> Sh2PickAndPlace5307PerBatchPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307PerShiftPerCycle> Sh2PickAndPlace5307PerShiftPerCycles
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Sh2PickAndPlace5307Shift> Sh2PickAndPlace5307Shifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Shift> Shifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.ShiftHourReport> ShiftHourReports
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.ShiftHourReport1> ShiftHourReport1s
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.ShiftHourReportLastRowId> ShiftHourReportLastRowIds
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.ShiftReportDashTimer> ShiftReportDashTimers
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.ShiftReportDashTimersGrouped> ShiftReportDashTimersGroupeds
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.ShiftReportDashTotalGodBad> ShiftReportDashTotalGodBads
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpBacthReportDash> SpBacthReportDashes
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpBacthReportHeader> SpBacthReportHeaders
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpBacthReportHeaderRow> SpBacthReportHeaderRows
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpBatchHourValuesGrid> SpBatchHourValuesGrids
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpBatchList> SpBatchLists
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpHourValue> SpHourValues
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpHourValuesGrid> SpHourValuesGrids
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpHourValuesShift> SpHourValuesShifts
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpShiftHourValuesGrid> SpShiftHourValuesGrids
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpShiftReportDash> SpShiftReportDashes
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpShiftReportHeader> SpShiftReportHeaders
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.SpStopTimeChartSource> SpStopTimeChartSources
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.Tag> Tags
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.TestSh1PickAndPlace5220ShiftPerHour> TestSh1PickAndPlace5220ShiftPerHours
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.VBacthReportHeaderRow> VBacthReportHeaderRows
        {
          get;
          set;
        }

        public DbSet<DataAnalysis.Models.Sortimat.VChartDatum> VChartData
        {
          get;
          set;
        }
    }
}
