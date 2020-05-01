using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("sp_BatchHourValuesGrid", Schema = "App")]
  public partial class SpBatchHourValuesGrid
  {
    [Key]
    public string BatchID
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
