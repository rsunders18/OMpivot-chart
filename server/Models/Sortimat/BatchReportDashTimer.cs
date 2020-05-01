using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("BatchReportDashTimers", Schema = "App")]
  public partial class BatchReportDashTimer
  {
    [Key]
    public int? MachineID
    {
      get;
      set;
    }
    public string BatchID
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
    public DateTime? DateHour
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public int? RecordedOn
    {
      get;
      set;
    }
    public string TagType
    {
      get;
      set;
    }
    public string TagName
    {
      get;
      set;
    }
    public double? Value
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string ValueChar
    {
      get;
      set;
    }
    public double? ValueH
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string ValueHChar
    {
      get;
      set;
    }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public string Indicator
    {
      get;
      set;
    }
  }
}
