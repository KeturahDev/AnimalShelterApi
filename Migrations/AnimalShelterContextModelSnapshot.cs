﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalBuisnessApi.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<bool>("LookingForSlave");

                    b.Property<string>("Name");

                    b.Property<string>("Personality");

                    b.Property<int>("PowerStatus");

                    b.Property<string>("Type");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 123,
                            Gender = "male",
                            LookingForSlave = true,
                            Name = "Cornelious",
                            Personality = "stoic",
                            PowerStatus = 75,
                            Type = "turtle"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 8,
                            Gender = "male",
                            LookingForSlave = true,
                            Name = "Jasper",
                            Personality = "mischevious",
                            PowerStatus = 38,
                            Type = "cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Gender = "female",
                            LookingForSlave = false,
                            Name = "Shiba",
                            Personality = "insightful",
                            PowerStatus = 40,
                            Type = "hamster"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
