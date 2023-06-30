using Microsoft.EntityFrameworkCore;

public class Context:DbContext
{

    public DbSet<Group> Groups { get; set; }
    //kol
    public DbSet<Kol> Kols { get; set; }
    //moin
    public DbSet<Moin> Moins { get; set; }
    //tafsili
    public DbSet<Tafsili> Tafsilis { get; set; }

    //anbar
    public DbSet<anbar> Anbars { get; set; }
    //abzar
    public DbSet<abzar> Abzars { get; set; }
    //boresh
    public DbSet<boresh> Boreshs { get; set; }
    //degree
    public DbSet<degree> Degrees { get; set; }
    //dessage
    public DbSet<dessang> Dessages { get; set; }
    //groh
    public DbSet<groh> Grohs { get; set; }
    //mablagh
    public DbSet<mablagh> Mablaghs { get; set; }
    //quality
    public DbSet<quality> Qualities { get; set; }
    //radif
    public DbSet<radif> Radifs { get; set; }
    //sangabzar
    public DbSet<sangabzar> Sangabzars { get; set; }

    //Account
    public DbSet<Account> Accounts { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=damon;Integrated Security=True;TrustServerCertificate=True");
    }
    
}