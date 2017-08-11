using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MyFantaManager.Models;

namespace MyFantaManager.Migrations
{
    [DbContext(typeof(FantaDbContext))]
    partial class FantaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("MyFantaManager.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cognome");

                    b.Property<string>("Nome");

                    b.Property<string>("Nominativo");

                    b.Property<int?>("PlayerContainerPlayersDataId");

                    b.Property<string>("Ruolo");

                    b.Property<string>("Squadra");

                    b.HasKey("PlayerId");

                    b.HasIndex("PlayerContainerPlayersDataId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("MyFantaManager.Models.PlayerContainer", b =>
                {
                    b.Property<int>("PlayersDataId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("PlayersDataId");

                    b.ToTable("PlayersContainers");
                });

            modelBuilder.Entity("MyFantaManager.Models.Player", b =>
                {
                    b.HasOne("MyFantaManager.Models.PlayerContainer")
                        .WithMany("Data")
                        .HasForeignKey("PlayerContainerPlayersDataId");
                });
        }
    }
}
