﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using p22.Models;

namespace p22.Migrations
{
    [DbContext(typeof(secondContext))]
    [Migration("20180919083210_in1itr")]
    partial class in1itr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview2-35157")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("p22.Models.police", b =>
                {
                    b.Property<int>("policeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("identitycardnumber");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("policenumber")
                        .IsRequired();

                    b.HasKey("policeId");

                    b.ToTable("police");
                });

            modelBuilder.Entity("p22.Models.pp", b =>
                {
                    b.Property<int>("ppId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("identitycardnumber");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("policenumber")
                        .IsRequired();

                    b.HasKey("ppId");

                    b.ToTable("dapp");
                });

            modelBuilder.Entity("p22.Models.qq", b =>
                {
                    b.Property<int>("qqId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("identitycardnumber");

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<string>("policenumber")
                        .IsRequired();

                    b.HasKey("qqId");

                    b.ToTable("xiao");
                });
#pragma warning restore 612, 618
        }
    }
}
