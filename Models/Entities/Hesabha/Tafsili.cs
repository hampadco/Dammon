using System.ComponentModel.DataAnnotations;

public class Tafsili
{
    [Key]
    public int Id { get; set; }
    public int CodeKol { get; set; }
    public string CodeMoin { get; set; }
    public string CodeHesab { get; set; }
    public string Titile { get; set; }
    public string  Descreption { get; set; }
    public string Mahyat { get; set; }
    
}