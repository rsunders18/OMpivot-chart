using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("HourValues", Schema = "App")]
  public partial class HourValue
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
    public string Machine
    {
      get;
      set;
    }
    public int? MachineID
    {
      get;
      set;
    }
    public int? TagID
    {
      get;
      set;
    }
    public string TagGroup
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
    public string TagDescription
    {
      get;
      set;
    }
    public double? Value
    {
      get;
      set;
    }
    public double? ValueH
    {
      get;
      set;
    }
  }
}
