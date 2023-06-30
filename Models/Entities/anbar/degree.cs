using System.ComponentModel.DataAnnotations;

public class degree
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public string type { get; set; }
} 