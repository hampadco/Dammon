using System.ComponentModel.DataAnnotations;

public class Group
{
    [Key]
    public int Id { get; set; }
    public int CodeGroup { get; set; }
    public string Titile { get; set; }
    public string Description { get; set; }
    public string Mahyat { get; set; }
}