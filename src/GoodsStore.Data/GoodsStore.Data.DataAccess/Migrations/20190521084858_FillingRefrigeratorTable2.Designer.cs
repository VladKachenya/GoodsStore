﻿// <auto-generated />
using GoodsStore.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoodsStore.Data.DataAccess.Migrations
{
    [DbContext(typeof(GoodsStoreDbContext))]
    [Migration("20190521084858_FillingRefrigeratorTable2")]
    partial class FillingRefrigeratorTable2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoodsStore.Core.Domain.Entities.Base.CatalogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<string>("Description");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("ItemTypeId");

                    b.Property<string>("Name");

                    b.Property<string>("PictureUri");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ItemTypeId");

                    b.ToTable("CatalogItems");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CatalogItem");
                });

            modelBuilder.Entity("GoodsStore.Core.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Simens"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Xiaomi"
                        },
                        new
                        {
                            Id = 4,
                            Name = "LG"
                        },
                        new
                        {
                            Id = 5,
                            Name = "ATLANT"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Bosch"
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Household equipment"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Telephony"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chancellery"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Сhildren's world"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Computers"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Health and beauty"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Furniture and interior"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Sport and tourism"
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Domain.Entities.Helpers.BrandItemType", b =>
                {
                    b.Property<int>("BrandId");

                    b.Property<int>("ItemTypeId");

                    b.HasKey("BrandId", "ItemTypeId");

                    b.HasIndex("ItemTypeId");

                    b.ToTable("BrandItemTypes");

                    b.HasData(
                        new
                        {
                            BrandId = 5,
                            ItemTypeId = 1
                        },
                        new
                        {
                            BrandId = 4,
                            ItemTypeId = 1
                        },
                        new
                        {
                            BrandId = 1,
                            ItemTypeId = 1
                        },
                        new
                        {
                            BrandId = 6,
                            ItemTypeId = 1
                        },
                        new
                        {
                            BrandId = 4,
                            ItemTypeId = 3
                        },
                        new
                        {
                            BrandId = 2,
                            ItemTypeId = 3
                        },
                        new
                        {
                            BrandId = 1,
                            ItemTypeId = 3
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Domain.Entities.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("UnitName");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Refrigerators",
                            UnitName = "Refrigerator"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "TVs",
                            UnitName = "TV"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Name = "Mobile phones",
                            UnitName = "Mobile phone"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Name = "Phone cases",
                            UnitName = "Case"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Name = "Blenders",
                            UnitName = "Blender"
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Domain.Entities.Goods.HouseholdEquipment.Refrigerator", b =>
                {
                    b.HasBaseType("GoodsStore.Core.Domain.Entities.Base.CatalogItem");

                    b.Property<double>("FreezerCameraVolume");

                    b.Property<double>("Height");

                    b.Property<double>("RefrigeratorCameraVolume");

                    b.Property<double>("Width");

                    b.ToTable("CatalogItems");

                    b.HasDiscriminator().HasValue("Refrigerator");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 5,
                            Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                            ItemTypeId = 1,
                            Name = "XM 4208-000",
                            Price = 12.25m,
                            FreezerCameraVolume = 25.0,
                            Height = 10.0,
                            RefrigeratorCameraVolume = 20.0,
                            Width = 5.0
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 5,
                            Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                            ItemTypeId = 1,
                            Name = "XM 4215-000",
                            Price = 89.25m,
                            FreezerCameraVolume = 12.0,
                            Height = 10.0,
                            RefrigeratorCameraVolume = 25.0,
                            Width = 6.0
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 5,
                            Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                            ItemTypeId = 1,
                            Name = "XM 4307-001",
                            Price = 124.145m,
                            FreezerCameraVolume = 20.0,
                            Height = 12.0,
                            RefrigeratorCameraVolume = 22.0,
                            Width = 7.0
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 4,
                            Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                            ItemTypeId = 1,
                            Name = "GA-B429SMQZ",
                            Price = 142.125m,
                            FreezerCameraVolume = 30.0,
                            Height = 15.0,
                            RefrigeratorCameraVolume = 29.0,
                            Width = 4.0
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 4,
                            Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                            ItemTypeId = 1,
                            Name = "GW-B499SMFZ",
                            Price = 1110.25m,
                            FreezerCameraVolume = 25.0,
                            Height = 8.0,
                            RefrigeratorCameraVolume = 20.0,
                            Width = 8.0
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 4,
                            Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                            ItemTypeId = 1,
                            Name = "GA-B499YMQZ",
                            Price = 1210.2m,
                            FreezerCameraVolume = 25.0,
                            Height = 16.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 1.0
                        },
                        new
                        {
                            Id = 10,
                            BrandId = 1,
                            Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                            ItemTypeId = 1,
                            Name = "RB33J3200SA",
                            Price = 142m,
                            FreezerCameraVolume = 25.0,
                            Height = 20.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 2.0
                        },
                        new
                        {
                            Id = 11,
                            BrandId = 1,
                            Description = "So perhaps, you've generated some fancy text, and you're content that you can now copy and paste",
                            ItemTypeId = 1,
                            Name = "RS55K50A02C",
                            Price = 578m,
                            FreezerCameraVolume = 25.0,
                            Height = 15.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 3.0
                        },
                        new
                        {
                            Id = 12,
                            BrandId = 1,
                            Description = "Is it some sort of hack? Are you copying and pasting an actual font?",
                            ItemTypeId = 1,
                            Name = "RT22HAR4DSA",
                            Price = 74.25m,
                            FreezerCameraVolume = 13.0,
                            Height = 5.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 4.0
                        },
                        new
                        {
                            Id = 13,
                            BrandId = 1,
                            Description = "Sudden she seeing garret far regard. By hardly it direct if pretty up regret.",
                            ItemTypeId = 1,
                            Name = "RB34N5061B1/WT",
                            Price = 125.12m,
                            FreezerCameraVolume = 12.0,
                            Height = 4.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 5.0
                        },
                        new
                        {
                            Id = 14,
                            BrandId = 1,
                            Description = "Ability thought enquire settled prudent you sir.",
                            ItemTypeId = 1,
                            Name = "RB37J5441SA",
                            Price = 111.1m,
                            FreezerCameraVolume = 12.0,
                            Height = 15.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 5.0999999999999996
                        },
                        new
                        {
                            Id = 15,
                            BrandId = 1,
                            Description = "Or easy knew sold on well come year. Something consulted age extremely end procuring.",
                            ItemTypeId = 1,
                            Name = "RS54N3003WW/WT",
                            Price = 794.2m,
                            FreezerCameraVolume = 11.0,
                            Height = 15.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 5.2000000000000002
                        },
                        new
                        {
                            Id = 16,
                            BrandId = 1,
                            Description = "Collecting preference he inquietude projection me in by.",
                            ItemTypeId = 1,
                            Name = "RB37J5000SA",
                            Price = 541.1m,
                            FreezerCameraVolume = 10.0,
                            Height = 6.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 5.2999999999999998
                        },
                        new
                        {
                            Id = 17,
                            BrandId = 1,
                            Description = "So do of sufficient projecting an thoroughly uncommonly prosperous conviction.",
                            ItemTypeId = 1,
                            Name = "RB37J5240SS",
                            Price = 999.99m,
                            FreezerCameraVolume = 9.0,
                            Height = 11.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 5.4000000000000004
                        },
                        new
                        {
                            Id = 18,
                            BrandId = 6,
                            Description = "Betrayed cheerful declared end and.",
                            ItemTypeId = 1,
                            Name = "KGN39XL2AR",
                            Price = 231.1m,
                            FreezerCameraVolume = 8.0,
                            Height = 41.409999999999997,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 5.5
                        },
                        new
                        {
                            Id = 19,
                            BrandId = 6,
                            Description = "Questions we additions is extremely incommode. Next half add call them eat face.",
                            ItemTypeId = 1,
                            Name = "KGN39XW2AR",
                            Price = 452.1m,
                            FreezerCameraVolume = 7.0,
                            Height = 3.4500000000000002,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 5.5999999999999996
                        },
                        new
                        {
                            Id = 20,
                            BrandId = 6,
                            Description = "Age lived smile six defer bed their few. Had admitting concluded too behaviour him she.",
                            ItemTypeId = 1,
                            Name = "KGN39AI31R",
                            Price = 123.1m,
                            FreezerCameraVolume = 6.0,
                            Height = 4.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 5.7000000000000002
                        },
                        new
                        {
                            Id = 21,
                            BrandId = 6,
                            Description = "Blind would equal while oh mr do style. Lain led and fact none. One preferred sportsmen resolving the happiness continued.",
                            ItemTypeId = 1,
                            Name = "KGN39XW33R",
                            Price = 542.4m,
                            FreezerCameraVolume = 5.0,
                            Height = 13.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 5.7999999999999998
                        },
                        new
                        {
                            Id = 22,
                            BrandId = 3,
                            Description = "High at of in loud rich true. Oh conveying do immediate acuteness in he. Equally welcome her set nothing has gravity whether parties.",
                            ItemTypeId = 1,
                            Name = "KGN39AI2AR",
                            Price = 98.5m,
                            FreezerCameraVolume = 4.0,
                            Height = 9.5199999999999996,
                            RefrigeratorCameraVolume = 21.0,
                            Width = 5.9000000000000004
                        },
                        new
                        {
                            Id = 23,
                            BrandId = 3,
                            Description = "Age lived smile six defer bed their few. Had admitting concluded too behaviour him she.",
                            ItemTypeId = 1,
                            Name = "XY135468",
                            Price = 9432.1m,
                            FreezerCameraVolume = 3.0,
                            Height = 4.25,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 5.0
                        },
                        new
                        {
                            Id = 24,
                            BrandId = 3,
                            Description = "Blind would equal while oh mr do style. Lain led and fact none. One preferred sportsmen resolving the happiness continued.",
                            ItemTypeId = 1,
                            Name = "XR498731",
                            Price = 10.11m,
                            FreezerCameraVolume = 2.0,
                            Height = 24.100000000000001,
                            RefrigeratorCameraVolume = 23.0,
                            Width = 5.0
                        },
                        new
                        {
                            Id = 25,
                            BrandId = 3,
                            Description = "High at of in loud rich true. Oh conveying do immediate acuteness in he. Equally welcome her set nothing has gravity whether parties.",
                            ItemTypeId = 1,
                            Name = "XF46568",
                            Price = 98.5m,
                            FreezerCameraVolume = 1.8899999999999999,
                            Height = 4.0,
                            RefrigeratorCameraVolume = 13.0,
                            Width = 5.0
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Domain.Entities.Goods.Telephony.MobilePhone", b =>
                {
                    b.HasBaseType("GoodsStore.Core.Domain.Entities.Base.CatalogItem");

                    b.Property<double>("ScreenDiagonal");

                    b.ToTable("CatalogItems");

                    b.HasDiscriminator().HasValue("MobilePhone");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            BrandId = 4,
                            Description = "Li Europan lingues es membres del sam familie. Lor separat existentie es un myth.",
                            ItemTypeId = 3,
                            Name = "V30S+ ThinQ Gray",
                            Price = 12.25m,
                            ScreenDiagonal = 0.0
                        },
                        new
                        {
                            Id = 1002,
                            BrandId = 4,
                            Description = "Por scientie, musica, sport etc, litot Europa usa li sam vocabular.",
                            ItemTypeId = 3,
                            Name = "G360",
                            Price = 782.25m,
                            ScreenDiagonal = 0.0
                        },
                        new
                        {
                            Id = 1003,
                            BrandId = 4,
                            Description = " Li lingues differe solmen in li grammatica, li pronunciation e li plu commun vocabules.",
                            ItemTypeId = 3,
                            Name = "V40 ThinQ 64Gb Black",
                            Price = 152.25m,
                            ScreenDiagonal = 0.0
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Domain.Entities.Base.CatalogItem", b =>
                {
                    b.HasOne("GoodsStore.Core.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GoodsStore.Core.Domain.Entities.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GoodsStore.Core.Domain.Entities.Helpers.BrandItemType", b =>
                {
                    b.HasOne("GoodsStore.Core.Domain.Entities.Brand", "Brand")
                        .WithMany("BrandItemTypes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GoodsStore.Core.Domain.Entities.ItemType", "ItemType")
                        .WithMany("BrandItemTypes")
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GoodsStore.Core.Domain.Entities.ItemType", b =>
                {
                    b.HasOne("GoodsStore.Core.Domain.Entities.Category", "Category")
                        .WithMany("ItemTypes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
