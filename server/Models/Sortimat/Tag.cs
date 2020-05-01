using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnalysis.Models.Sortimat
{
  [Table("Tag", Schema = "Dim")]
  public partial class Tag
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TagID
    {
      get;
      set;
    }

    [Column("Tag")]
    public string Tag1
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
  }
}
