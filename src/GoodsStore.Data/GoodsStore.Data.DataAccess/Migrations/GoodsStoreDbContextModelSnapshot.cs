﻿// <auto-generated />
using GoodsStore.Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoodsStore.Data.DataAccess.Migrations
{
    [DbContext(typeof(GoodsStoreDbContext))]
    partial class GoodsStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoodsStore.Core.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "Samsung"
                        },
                        new
                        {
                            Id = 2,
                            BrandName = "Simens"
                        },
                        new
                        {
                            Id = 3,
                            BrandName = "Xiaomi"
                        },
                        new
                        {
                            Id = 4,
                            BrandName = "LG"
                        },
                        new
                        {
                            Id = 5,
                            BrandName = "ATLANT"
                        },
                        new
                        {
                            Id = 6,
                            BrandName = "Bosch"
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Entities.CatalogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<string>("Description");

                    b.Property<int>("ItemTypeId");

                    b.Property<string>("Name");

                    b.Property<string>("PictureUri");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ItemTypeId");

                    b.ToTable("CatalogItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 5,
                            Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                            ItemTypeId = 1,
                            Name = "XM 4208-000",
                            Price = 12.25m
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 5,
                            Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                            ItemTypeId = 1,
                            Name = "XM 4215-000",
                            Price = 89.25m
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 5,
                            Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                            ItemTypeId = 1,
                            Name = "XM 4307-001",
                            Price = 124.145m
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 4,
                            Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                            ItemTypeId = 1,
                            Name = "GA-B429SMQZ",
                            Price = 142.125m
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 4,
                            Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                            ItemTypeId = 1,
                            Name = "GW-B499SMFZ",
                            Price = 1110.25m
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 4,
                            Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                            ItemTypeId = 1,
                            Name = "GA-B499YMQZ",
                            Price = 1210.2m
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 4,
                            Description = "Li Europan lingues es membres del sam familie. Lor separat existentie es un myth.",
                            ItemTypeId = 3,
                            Name = "V30S+ ThinQ Gray",
                            Price = 12.25m
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 4,
                            Description = "Por scientie, musica, sport etc, litot Europa usa li sam vocabular.",
                            ItemTypeId = 3,
                            Name = "G360",
                            Price = 782.25m
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 4,
                            Description = " Li lingues differe solmen in li grammatica, li pronunciation e li plu commun vocabules.",
                            ItemTypeId = 3,
                            Name = "V40 ThinQ 64Gb Black",
                            Price = 152.25m
                        },
                        new
                        {
                            Id = 10,
                            BrandId = 1,
                            Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                            ItemTypeId = 1,
                            Name = "RB33J3200SA",
                            Price = 142m
                        },
                        new
                        {
                            Id = 11,
                            BrandId = 1,
                            Description = "So perhaps, you've generated some fancy text, and you're content that you can now copy and paste",
                            ItemTypeId = 1,
                            Name = "RS55K50A02C",
                            Price = 578m
                        },
                        new
                        {
                            Id = 12,
                            BrandId = 1,
                            Description = "Is it some sort of hack? Are you copying and pasting an actual font?",
                            ItemTypeId = 1,
                            Name = "RT22HAR4DSA",
                            Price = 74.25m
                        },
                        new
                        {
                            Id = 13,
                            BrandId = 1,
                            Description = "Sudden she seeing garret far regard. By hardly it direct if pretty up regret.",
                            ItemTypeId = 1,
                            Name = "RB34N5061B1/WT",
                            Price = 125.12m
                        },
                        new
                        {
                            Id = 14,
                            BrandId = 1,
                            Description = "Ability thought enquire settled prudent you sir.",
                            ItemTypeId = 1,
                            Name = "RB37J5441SA",
                            Price = 111.1m
                        },
                        new
                        {
                            Id = 15,
                            BrandId = 1,
                            Description = "Or easy knew sold on well come year. Something consulted age extremely end procuring.",
                            ItemTypeId = 1,
                            Name = "RS54N3003WW/WT",
                            Price = 794.2m
                        },
                        new
                        {
                            Id = 16,
                            BrandId = 1,
                            Description = "Collecting preference he inquietude projection me in by.",
                            ItemTypeId = 1,
                            Name = "RB37J5000SA",
                            Price = 541.1m
                        },
                        new
                        {
                            Id = 17,
                            BrandId = 1,
                            Description = "So do of sufficient projecting an thoroughly uncommonly prosperous conviction.",
                            ItemTypeId = 1,
                            Name = "RB37J5240SS",
                            Price = 999.99m
                        },
                        new
                        {
                            Id = 18,
                            BrandId = 6,
                            Description = "Betrayed cheerful declared end and.",
                            ItemTypeId = 1,
                            Name = "KGN39XL2AR",
                            Price = 231.1m
                        },
                        new
                        {
                            Id = 19,
                            BrandId = 6,
                            Description = "Questions we additions is extremely incommode. Next half add call them eat face.",
                            ItemTypeId = 1,
                            Name = "KGN39XW2AR",
                            Price = 452.1m
                        },
                        new
                        {
                            Id = 20,
                            BrandId = 6,
                            Description = "Age lived smile six defer bed their few. Had admitting concluded too behaviour him she.",
                            ItemTypeId = 1,
                            Name = "KGN39AI31R",
                            Price = 123.1m
                        },
                        new
                        {
                            Id = 21,
                            BrandId = 6,
                            Description = "Blind would equal while oh mr do style. Lain led and fact none. One preferred sportsmen resolving the happiness continued.",
                            ItemTypeId = 1,
                            Name = "KGN39XW33R",
                            Price = 542.4m
                        },
                        new
                        {
                            Id = 22,
                            BrandId = 6,
                            Description = "High at of in loud rich true. Oh conveying do immediate acuteness in he. Equally welcome her set nothing has gravity whether parties.",
                            ItemTypeId = 1,
                            Name = "KGN39AI2AR",
                            Price = 98.5m
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Household equipment"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Telephony"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Chancellery"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Сhildren's world"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Computers"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Health and beauty"
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Furniture and interior"
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Sport and tourism"
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Entities.Goods.HouseholdEquipment.Refrigerator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatalogItemId");

                    b.Property<double>("FreezerCameraVolume");

                    b.Property<double>("Height");

                    b.Property<double>("RefrigeratorCameraVolume");

                    b.Property<double>("Width");

                    b.HasKey("Id");

                    b.HasIndex("CatalogItemId");

                    b.ToTable("Refrigerators");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CatalogItemId = 1,
                            FreezerCameraVolume = 25.0,
                            Height = 10.0,
                            RefrigeratorCameraVolume = 20.0,
                            Width = 5.0
                        },
                        new
                        {
                            Id = 2,
                            CatalogItemId = 2,
                            FreezerCameraVolume = 12.0,
                            Height = 10.0,
                            RefrigeratorCameraVolume = 25.0,
                            Width = 6.0
                        },
                        new
                        {
                            Id = 3,
                            CatalogItemId = 3,
                            FreezerCameraVolume = 20.0,
                            Height = 12.0,
                            RefrigeratorCameraVolume = 22.0,
                            Width = 7.0
                        },
                        new
                        {
                            Id = 4,
                            CatalogItemId = 4,
                            FreezerCameraVolume = 30.0,
                            Height = 15.0,
                            RefrigeratorCameraVolume = 29.0,
                            Width = 4.0
                        },
                        new
                        {
                            Id = 5,
                            CatalogItemId = 5,
                            FreezerCameraVolume = 25.0,
                            Height = 8.0,
                            RefrigeratorCameraVolume = 20.0,
                            Width = 8.0
                        },
                        new
                        {
                            Id = 6,
                            CatalogItemId = 6,
                            FreezerCameraVolume = 25.0,
                            Height = 15.0,
                            RefrigeratorCameraVolume = 33.0,
                            Width = 5.0
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Entities.Goods.Telephony.MobilePhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatalogItemId");

                    b.HasKey("Id");

                    b.HasIndex("CatalogItemId");

                    b.ToTable("MobilePhones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CatalogItemId = 7
                        },
                        new
                        {
                            Id = 2,
                            CatalogItemId = 7
                        },
                        new
                        {
                            Id = 3,
                            CatalogItemId = 7
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Entities.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            TypeName = "Large appliances for kitchen"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            TypeName = "Home appliances"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            TypeName = "Mobile phone"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            TypeName = "Accessories"
                        });
                });

            modelBuilder.Entity("GoodsStore.Core.Entities.CatalogItem", b =>
                {
                    b.HasOne("GoodsStore.Core.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GoodsStore.Core.Entities.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GoodsStore.Core.Entities.Goods.HouseholdEquipment.Refrigerator", b =>
                {
                    b.HasOne("GoodsStore.Core.Entities.CatalogItem", "CatalogItem")
                        .WithMany()
                        .HasForeignKey("CatalogItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GoodsStore.Core.Entities.Goods.Telephony.MobilePhone", b =>
                {
                    b.HasOne("GoodsStore.Core.Entities.CatalogItem", "CatalogItem")
                        .WithMany()
                        .HasForeignKey("CatalogItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GoodsStore.Core.Entities.ItemType", b =>
                {
                    b.HasOne("GoodsStore.Core.Entities.Category", "Category")
                        .WithMany("ItemTypes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
