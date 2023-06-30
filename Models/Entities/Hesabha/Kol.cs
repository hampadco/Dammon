using System.ComponentModel.DataAnnotations;

public class Kol
{
    [Key]
    public int Id { get; set; }

    public int IdGroup { get; set; }
    public int CodeHesab { get; set; }
    public string Titile { get; set; }
    public string TypeHesab { get; set; }
    public string Descreption { get; set; }
    public string Mahyat { get; set; }
    
}