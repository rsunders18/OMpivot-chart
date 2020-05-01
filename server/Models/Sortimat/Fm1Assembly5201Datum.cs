using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("FM1_Assembly_5201_Data", Schema = "dbo")]
  public partial class Fm1Assembly5201Datum
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
