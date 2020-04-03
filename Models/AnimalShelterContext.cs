using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId=1, Name="Cornelious", Type="turtle", Personality="stoic", PowerStatus=75, Age=123, Gender="male", LookingForSlave=true},
            new Animal {AnimalId=2, Name="Jasper", Type="cat", Personality="mischevious", PowerStatus=38, Age=8, Gender="male", LookingForSlave=true},
            new Animal {AnimalId=3, Name="Shiba", Type="hamster", Personality="insightful", PowerStatus=40, Age=2, Gender="female", LookingForSlave=false}
          );
      }
  }
}