﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InteractiveMapProject.Data.Db.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Audience",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("1d0244f0-e182-49f6-b37e-79c561aadb6c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professionnels" },
                    { new Guid("9f097270-dcbd-4d04-b980-bef3382c50ac"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3-6 ans" },
                    { new Guid("ae6bd3c0-9271-4ab5-8e1b-973059d5e236"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12-18 ans" },
                    { new Guid("d9481828-5a78-4201-8eae-00dbc857103f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parents" },
                    { new Guid("db0891bd-3704-438e-b001-65b84d47d32f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0-3 ans" },
                    { new Guid("dc9b764f-4a27-4a8d-953e-04880d3801de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6-12 ans" }
                });

            migrationBuilder.InsertData(
                table: "Mission",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("13309a40-ae58-48bc-a222-162327fba84c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de nuit" },
                    { new Guid("1c1d9cc9-8acd-4a46-8e7b-619b535f0177"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement administratif" },
                    { new Guid("40d689cc-0f1d-4054-bc52-2aae8bead67a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Répit" },
                    { new Guid("4ed1e1b9-8f18-4a98-a681-13f55d7de995"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petite enfance" },
                    { new Guid("505a06e3-164a-4cfe-9432-2e49415a0813"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prestataire" },
                    { new Guid("534b656d-bf94-4d5d-aa9e-d41f878df2f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group de parole/Ateliers" },
                    { new Guid("6fd4ae72-a20d-4a18-9843-853c3dae85b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orientation" },
                    { new Guid("7c9be443-b28d-4a04-8af1-b69433c70116"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de loisirs" },
                    { new Guid("9914a004-9cfc-4f71-90aa-bf35a9fc0a5a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scolarité" },
                    { new Guid("9de2ae02-5652-4755-b59a-c4aa28ff95ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accompagnement à la parentalité" },
                    { new Guid("b6e3adc4-d625-46f9-959e-eec65da4c3b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soins/santé/réeducation" },
                    { new Guid("bafcbe8f-666f-4fe4-9f7a-0f7b8e07d085"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Référent santé accueil inclusif (RSAI)" },
                    { new Guid("eba3a34d-79bd-491b-9455-8483c9af1637"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ressource documentaire" },
                    { new Guid("fa9d27ca-1831-4bb6-8053-ed03df0a4c20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil de jour" },
                    { new Guid("fbc107e1-e883-496c-bd6d-703424bf7d1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accueil occasionnel" }
                });

            migrationBuilder.InsertData(
                table: "PlaceOfIntervention",
                columns: new[] { "Id", "CreationDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("19309602-02cb-4cb1-972f-c498e5ea31a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAJE" },
                    { new Guid("52b075ff-0538-4478-9ac2-bd5e0cd87db7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cabinet" },
                    { new Guid("53121cc1-1d0d-422e-8b21-3cb6ce59f9c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Domicile" },
                    { new Guid("ac036202-4fde-4ad2-adc2-dc6889388ab6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "École" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("1d0244f0-e182-49f6-b37e-79c561aadb6c"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("9f097270-dcbd-4d04-b980-bef3382c50ac"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("ae6bd3c0-9271-4ab5-8e1b-973059d5e236"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("d9481828-5a78-4201-8eae-00dbc857103f"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("db0891bd-3704-438e-b001-65b84d47d32f"));

            migrationBuilder.DeleteData(
                table: "Audience",
                keyColumn: "Id",
                keyValue: new Guid("dc9b764f-4a27-4a8d-953e-04880d3801de"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("13309a40-ae58-48bc-a222-162327fba84c"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("1c1d9cc9-8acd-4a46-8e7b-619b535f0177"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("40d689cc-0f1d-4054-bc52-2aae8bead67a"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("4ed1e1b9-8f18-4a98-a681-13f55d7de995"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("505a06e3-164a-4cfe-9432-2e49415a0813"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("534b656d-bf94-4d5d-aa9e-d41f878df2f3"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("6fd4ae72-a20d-4a18-9843-853c3dae85b1"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("7c9be443-b28d-4a04-8af1-b69433c70116"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("9914a004-9cfc-4f71-90aa-bf35a9fc0a5a"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("9de2ae02-5652-4755-b59a-c4aa28ff95ab"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("b6e3adc4-d625-46f9-959e-eec65da4c3b5"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("bafcbe8f-666f-4fe4-9f7a-0f7b8e07d085"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("eba3a34d-79bd-491b-9455-8483c9af1637"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("fa9d27ca-1831-4bb6-8053-ed03df0a4c20"));

            migrationBuilder.DeleteData(
                table: "Mission",
                keyColumn: "Id",
                keyValue: new Guid("fbc107e1-e883-496c-bd6d-703424bf7d1b"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("19309602-02cb-4cb1-972f-c498e5ea31a1"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("52b075ff-0538-4478-9ac2-bd5e0cd87db7"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("53121cc1-1d0d-422e-8b21-3cb6ce59f9c5"));

            migrationBuilder.DeleteData(
                table: "PlaceOfIntervention",
                keyColumn: "Id",
                keyValue: new Guid("ac036202-4fde-4ad2-adc2-dc6889388ab6"));
        }
    }
}