using System.ComponentModel.DataAnnotations;

public class quality
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }

    public string type { get; set; }
} 