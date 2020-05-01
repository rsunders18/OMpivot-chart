using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("SH2_PickAndPlace_5307_Data", Schema = "dbo")]
  public partial class Sh2PickAndPlace5307Datum
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id
    {
      get;
      set;
    }
    public string _NAME
    {
      get;
      set;
    }
    public double? _VALUE
    {
      get;
      set;
    }
    public DateTime? _TIMESTAMP
    {
      get;
      set;
    }
    public string _BATCHID
    {
      get;
      set;
    }
  }
}
