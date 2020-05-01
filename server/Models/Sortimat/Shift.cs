using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("Shift", Schema = "Dim")]
  public partial class Shift
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ShiftID
    {
      get;
      set;
    }
    public string ShiftName
    {
      get;
      set;
    }
    public DateTime? ShiftStartTime
    {
      get;
      set;
    }
    public DateTime? ShiftEndTime
    {
      get;
      set;
    }
  }
}
