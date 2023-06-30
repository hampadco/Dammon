using System.ComponentModel.DataAnnotations;

public class Moin
{
    [Key]
    public int Id { get; set; }
    public int CodeKol { get; set; }
    public string CodeHesab { get; set; }
    public string Titile { get; set; }
    public string TypeHesab { get; set; }
    public string Mahyat { get; set; }
    
}