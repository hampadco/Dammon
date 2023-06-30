using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Account
{
    [Key]
    public int Id { get; set; }
    
    [Column(TypeName = "float")]
    public float CodeGroup { get; set; }
    
    [Column(TypeName = "nvarchar(255)")]
    public string TitleGroup { get; set; }
    
    [Column(TypeName = "float")]
    public float CodeTotal { get; set; }
    
    [Column(TypeName = "nvarchar(255)")]
    public string TitleTotal { get; set; }
    
    [Column(TypeName = "float")]
    public float CodeMoin { get; set; }
    
    [Column(TypeName = "nvarchar(255)")]
    public string TitleMoin { get; set; }
    
    [Column(TypeName = "nvarchar(255)")]
    public string Nature { get; set; }
    
    [Column(TypeName = "nvarchar(255)")]
    public string Account_type { get; set; }
}
