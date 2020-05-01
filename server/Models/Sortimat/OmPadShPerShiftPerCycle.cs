using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("OM_PAD_SH_PerShift_PerCycle", Schema = "dbo")]
  public partial class OmPadShPerShiftPerCycle
  {
    [Key]
    public int id
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Alarming_Time_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Alarming_Time_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Alarming_Time_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Alarming_Time_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Reject_Percentage_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Reject_Percentage_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Reject_Percentage_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Reject_Percentage_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Run_Time_Efficiency_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Run_Time_Efficiency_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Run_Time_Efficiency_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Run_Time_Efficiency_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Running_Time_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Running_Time_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Running_Time_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Running_Time_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Shift_Date_Day_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Shift_Date_Day_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Shift_Date_Day_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Shift_Date_Day_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Shift_Date_Month_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Shift_Date_Month_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Shift_Date_Month_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Shift_Date_Month_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Shift_Date_Year_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Shift_Date_Year_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Shift_Date_Year_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Shift_Date_Year_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Hour_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Hour_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Hour_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Hour_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Min_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Min_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Min_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Min_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Sec_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Sec_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Sec_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Shift_StartTime_Sec_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Hour_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Hour_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Hour_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Hour_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Efficiency_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Efficiency_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Efficiency_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Efficiency_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Min_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Min_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Min_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Min_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Sec_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Sec_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Sec_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Shift_StopTime_Sec_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Stopped_Time_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Stopped_Time_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Stopped_Time_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Stopped_Time_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Total_Alarms_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Total_Alarms_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Total_Alarms_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Total_Alarms_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Total_Good_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Total_Good_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Total_Good_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Total_Good_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Total_Reject_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Total_Reject_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Total_Reject_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Total_Reject_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Total_Shift_Time_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Total_Shift_Time_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Total_Shift_Time_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Total_Shift_Time_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Good_Percentage_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Good_Percentage_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Good_Percentage_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Good_Percentage_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Miscel_Reject_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Miscel_Reject_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Miscel_Reject_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Miscel_Reject_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_OEE_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_OEE_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_OEE_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_OEE_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Print_reject_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Print_reject_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Print_reject_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Print_reject_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Rated_Speed_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Rated_Speed_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Rated_Speed_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Rated_Speed_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Recipe_Name_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Recipe_Name_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Recipe_Name_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Recipe_Name_QUALITY
    {
      get;
      set;
    }
    public int? PAD_SH_OSI_PI_Current_Shift_Register_Reject_NUMERICID
    {
      get;
      set;
    }
    public string PAD_SH_OSI_PI_Current_Shift_Register_Reject_VALUE
    {
      get;
      set;
    }
    public DateTime? PAD_SH_OSI_PI_Current_Shift_Register_Reject_TIMESTAMP
    {
      get;
      set;
    }
    public Int16? PAD_SH_OSI_PI_Current_Shift_Register_Reject_QUALITY
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
  }
}
