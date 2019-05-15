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

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ItemTypeId");

                    b.ToTable("CatalogItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                            ItemTypeId = 1,
                            Name = "XM 4208-000",
                            Price = 12.25m
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 1,
                            Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                            ItemTypeId = 1,
                            Name = "XM 4215-000",
                            Price = 89.25m
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 1,
                            Description = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                            ItemTypeId = 1,
                            Name = "XM 4307-001",
                            Price = 124.145m
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 2,
                            Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                            ItemTypeId = 1,
                            Name = "GA-B429SMQZ",
                            Price = 142.125m
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 2,
                            Description = "But I must explain to you how all this mistaken idea of denouncing pleasure and praising",
                            ItemTypeId = 1,
                            Name = "GW-B499SMFZ",
                            Price = 1110.25m
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 2,
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
