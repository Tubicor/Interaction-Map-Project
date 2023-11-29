﻿// <auto-generated />
using System;
using InteractiveMapProject.Data.Db.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InteractiveMapProject.Data.Db.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231129144347_ProfessionalEntityChanges")]
    partial class ProfessionalEntityChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Audience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Audience");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7ab1874c-166d-449b-b0fd-60bf99fbb50e"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "0-3 ans"
                        },
                        new
                        {
                            Id = new Guid("1fb3dd4c-c8a1-452f-b59a-da5e8df4cd43"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "3-6 ans"
                        },
                        new
                        {
                            Id = new Guid("11853a91-e22f-4098-80ad-3268d02780a3"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "6-12 ans"
                        },
                        new
                        {
                            Id = new Guid("bae704f3-7211-4201-8e06-f402e328f4bf"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "12-18 ans"
                        },
                        new
                        {
                            Id = new Guid("5847cb74-d640-490d-a203-89e4d567ae12"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Parents"
                        },
                        new
                        {
                            Id = new Guid("4709c7e2-7770-460e-ba24-8ccf883bfb92"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Professionnels"
                        });
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Mission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mission");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d5b7fd7c-1c16-4677-935e-59e43f5fcd82"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accueil de loisirs"
                        },
                        new
                        {
                            Id = new Guid("d01b121e-e358-443a-9c6d-224abbe5a2d2"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Petite enfance"
                        },
                        new
                        {
                            Id = new Guid("8a27c1a3-694f-4385-a2fc-8bcddc633c84"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Répit"
                        },
                        new
                        {
                            Id = new Guid("43781777-161e-4585-a282-525a6d124c29"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accueil occasionnel"
                        },
                        new
                        {
                            Id = new Guid("43840c49-f350-49cb-bb21-354bdc272ad2"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Scolarité"
                        },
                        new
                        {
                            Id = new Guid("414a8f84-00ce-47dd-b3cb-c955d93676c3"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Référent santé accueil inclusif (RSAI)"
                        },
                        new
                        {
                            Id = new Guid("e9703ca5-5fa6-4ab5-8c2d-f0a36e721a2e"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accueil de jour"
                        },
                        new
                        {
                            Id = new Guid("3945002e-72ae-4f62-8672-512b6c719ae6"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accueil de nuit"
                        },
                        new
                        {
                            Id = new Guid("97ba9f81-2460-4afe-b440-02fbe78860a5"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Soins/santé/réeducation"
                        },
                        new
                        {
                            Id = new Guid("818156bf-8c5e-4909-98ba-f94009942818"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accompagnement à la parentalité"
                        },
                        new
                        {
                            Id = new Guid("73dd467f-8346-4535-8249-241259af10e3"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Accompagnement administratif"
                        },
                        new
                        {
                            Id = new Guid("bcf709a9-ecbb-47f2-b7eb-8bd30e75f361"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ressource documentaire"
                        },
                        new
                        {
                            Id = new Guid("a31b2880-a347-4a18-b8e3-e59db7222681"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Group de parole/Ateliers"
                        },
                        new
                        {
                            Id = new Guid("5d01312a-7a2f-4c91-952c-7553f51189b9"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Orientation"
                        },
                        new
                        {
                            Id = new Guid("3d1ba809-27b8-4711-9b08-64e88f9b5f53"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Prestataire"
                        });
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.PlaceOfIntervention", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlaceOfIntervention");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c82b7e97-216a-4295-b848-541e6e977b8c"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Domicile"
                        },
                        new
                        {
                            Id = new Guid("901fc4ec-e995-4c6b-80d4-594bfe985401"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "EAJE"
                        },
                        new
                        {
                            Id = new Guid("f9224979-b4b8-4b72-ac52-45e1200fe18d"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "École"
                        },
                        new
                        {
                            Id = new Guid("098690ae-6cc1-4b09-af13-57c7c982621c"),
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cabinet"
                        });
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalAudience", b =>
                {
                    b.Property<Guid>("ProfessionalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AudienceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProfessionalId", "AudienceId");

                    b.HasIndex("AudienceId");

                    b.ToTable("ProfessionalAudience");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalMission", b =>
                {
                    b.Property<Guid>("ProfessionalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MissionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProfessionalId", "MissionId");

                    b.HasIndex("MissionId");

                    b.ToTable("ProfessionalMission");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalPlaceOfIntervention", b =>
                {
                    b.Property<Guid>("ProfessionalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlaceOfInterventionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProfessionalId", "PlaceOfInterventionId");

                    b.HasIndex("PlaceOfInterventionId");

                    b.ToTable("ProfessionalPlaceOfIntervention");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.Professional", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Professionals");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalAudience", b =>
                {
                    b.HasOne("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Audience", "Audience")
                        .WithMany("Professionals")
                        .HasForeignKey("AudienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InteractiveMapProject.Contracts.Entities.Professional", "Professional")
                        .WithMany("Audiences")
                        .HasForeignKey("ProfessionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Audience");

                    b.Navigation("Professional");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalMission", b =>
                {
                    b.HasOne("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Mission", "Mission")
                        .WithMany("Professionals")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InteractiveMapProject.Contracts.Entities.Professional", "Professional")
                        .WithMany("Missions")
                        .HasForeignKey("ProfessionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mission");

                    b.Navigation("Professional");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.ProfessionalPlaceOfIntervention", b =>
                {
                    b.HasOne("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.PlaceOfIntervention", "PlaceOfIntervention")
                        .WithMany("Professionals")
                        .HasForeignKey("PlaceOfInterventionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InteractiveMapProject.Contracts.Entities.Professional", "Professional")
                        .WithMany("PlacesOfIntervention")
                        .HasForeignKey("ProfessionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlaceOfIntervention");

                    b.Navigation("Professional");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.Professional", b =>
                {
                    b.OwnsOne("InteractiveMapProject.Contracts.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("ProfessionalId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ProfessionalId");

                            b1.ToTable("Professionals");

                            b1.WithOwner()
                                .HasForeignKey("ProfessionalId");
                        });

                    b.OwnsOne("InteractiveMapProject.Contracts.Entities.ContactPerson", "ContactPerson", b1 =>
                        {
                            b1.Property<Guid>("ProfessionalId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Function")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("PhoneNumber")
                                .HasColumnType("int");

                            b1.HasKey("ProfessionalId");

                            b1.ToTable("Professionals");

                            b1.WithOwner()
                                .HasForeignKey("ProfessionalId");
                        });

                    b.OwnsOne("InteractiveMapProject.Contracts.Entities.Geolocation", "Geolocation", b1 =>
                        {
                            b1.Property<Guid>("ProfessionalId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("Latitude")
                                .HasColumnType("float");

                            b1.Property<double>("Longitude")
                                .HasColumnType("float");

                            b1.HasKey("ProfessionalId");

                            b1.ToTable("Professionals");

                            b1.WithOwner()
                                .HasForeignKey("ProfessionalId");
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("ContactPerson")
                        .IsRequired();

                    b.Navigation("Geolocation")
                        .IsRequired();
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Audience", b =>
                {
                    b.Navigation("Professionals");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.Mission", b =>
                {
                    b.Navigation("Professionals");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.FieldOfIntervention.PlaceOfIntervention", b =>
                {
                    b.Navigation("Professionals");
                });

            modelBuilder.Entity("InteractiveMapProject.Contracts.Entities.Professional", b =>
                {
                    b.Navigation("Audiences");

                    b.Navigation("Missions");

                    b.Navigation("PlacesOfIntervention");
                });
#pragma warning restore 612, 618
        }
    }
}