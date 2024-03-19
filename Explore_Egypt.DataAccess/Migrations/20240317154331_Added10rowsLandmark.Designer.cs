﻿// <auto-generated />
using System;
using Explore_Egypt.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Explore_Egypt.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240317154331_Added10rowsLandmark")]
    partial class Added10rowsLandmark
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Explore_Egypt.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User", "security");
                });

            modelBuilder.Entity("Explore_Egypt.Models.Favour", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("LandmarkID")
                        .HasColumnType("int");

                    b.HasKey("UserId", "LandmarkID");

                    b.HasIndex("LandmarkID");

                    b.ToTable("Favours");
                });

            modelBuilder.Entity("Explore_Egypt.Models.Landmark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeOnly?>("CloseTime")
                        .IsRequired()
                        .HasColumnType("time");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("EgyptianStudentTicketPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("EgyptianTicketPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("ForeignStudentTicketPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("ForeignTicketPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeOnly?>("OpenTime")
                        .IsRequired()
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Landmarks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CloseTime = new TimeOnly(15, 0, 0),
                            Description = "Abdeen Palace is a historic palace in Cairo, Egypt. Built in the late 19th century, it served as the main residence for Egypt's royal family until 1952. The palace features a blend of Turkish, Moorish, and European architectural styles. Today, it is a museum showcasing opulent interiors, royal artifacts, and beautifully landscaped gardens. Abdeen Palace is a popular tourist attraction, offering a glimpse into Egypt's rich history and royal heritage.",
                            EgyptianStudentTicketPrice = 10.0m,
                            EgyptianTicketPrice = 20.0m,
                            ForeignStudentTicketPrice = 50.0m,
                            ForeignTicketPrice = 100.0m,
                            Latitude = 30.041980595759298,
                            Longitude = 31.2467661930229,
                            Name = "Abdeen Palace",
                            OpenTime = new TimeOnly(9, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            CloseTime = new TimeOnly(9, 0, 0),
                            Description = "Abu Simbel is an archaeological site in southern Egypt known for its rock-cut temples. The main attraction is the Great Temple of Ramses II, featuring colossal statues and intricate wall carvings. The smaller Temple of Hathor is dedicated to the goddess of love. The site was relocated in the 1960s to save it from flooding. Today, Abu Simbel is a UNESCO World Heritage site and a popular tourist destination",
                            EgyptianStudentTicketPrice = 10.0m,
                            EgyptianTicketPrice = 30.0m,
                            ForeignStudentTicketPrice = 300.0m,
                            ForeignTicketPrice = 600.0m,
                            Latitude = 29.9810966592981,
                            Longitude = 31.143216715340699,
                            Name = "Abu Simbel",
                            OpenTime = new TimeOnly(9, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            CloseTime = new TimeOnly(16, 30, 0),
                            Description = "The Alexandria National Museum is a prominent museum located in Alexandria, Egypt. It was established in 2003 and is housed in a renovated Italian-style palace dating back to the early 20th century. The museum showcases a diverse collection of artifacts, spanning various historical periods and civilizations, including ancient Egyptian, Greek, Roman, and Islamic artifacts. Visitors can explore exhibits that highlight Alexandria's rich cultural heritage, including sculptures, jewelry, coins, and mummies. The museum also provides insight into the city's history, including its role as a center of trade and scholarship in the ancient world.",
                            EgyptianStudentTicketPrice = 5.0m,
                            EgyptianTicketPrice = 20.0m,
                            ForeignStudentTicketPrice = 90.0m,
                            ForeignTicketPrice = 180.0m,
                            Latitude = 31.200814890268202,
                            Longitude = 29.913219162632899,
                            Name = "Alexandria National Museum",
                            OpenTime = new TimeOnly(9, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            CloseTime = new TimeOnly(17, 0, 0),
                            Description = "Amir Taz Palace, also known as Beit El-Sennari, is a historic palace located in the heart of Cairo, Egypt. It was constructed during the 19th century under the reign of Khedive Ismail Pasha. The palace exhibits an exquisite blend of Ottoman and Islamic architectural styles, featuring intricate carvings, beautiful stained glass windows, and ornate decorations. Today, the palace serves as a cultural center and a venue for various art exhibitions, concerts, and cultural events. It stands as a testament to Egypt's rich architectural heritage and offers visitors a glimpse into the opulent lifestyle of the past.",
                            EgyptianStudentTicketPrice = 0.0m,
                            EgyptianTicketPrice = 0.0m,
                            ForeignStudentTicketPrice = 0.0m,
                            ForeignTicketPrice = 0.0m,
                            Latitude = 30.0323587576957,
                            Longitude = 31.253664308366901,
                            Name = "Amir Taz Palace",
                            OpenTime = new TimeOnly(9, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            CloseTime = new TimeOnly(9, 0, 0),
                            Description = "Amr ibn al-As was a prominent Arab military commander and companion of Prophet Muhammad. He played a crucial role in the early Muslim conquests, including the conquest of Egypt in 641 CE. He founded the city of Fustat, which later became Cairo's capital. Amr ibn al-As introduced Islam to the region and governed Egypt for several years. His military and administrative achievements left a lasting impact on the expansion of Islam and the Arab world.",
                            EgyptianStudentTicketPrice = 0.0m,
                            EgyptianTicketPrice = 0.0m,
                            ForeignStudentTicketPrice = 0.0m,
                            ForeignTicketPrice = 0.0m,
                            Latitude = 30.010058193229,
                            Longitude = 31.2331094374956,
                            Name = "Amr Ibn Al-As",
                            OpenTime = new TimeOnly(9, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            CloseTime = new TimeOnly(19, 0, 0),
                            Description = "Nestled in Aswan, Upper Egypt, the Nubian Museum stands as a testament to the rich history and captivating culture of Nubia. Built in response to the international campaign to save Nubian monuments from rising waters due to the Aswan Dam, the museum opened its doors in 1997",
                            EgyptianStudentTicketPrice = 10.0m,
                            EgyptianTicketPrice = 30.0m,
                            ForeignStudentTicketPrice = 150.0m,
                            ForeignTicketPrice = 300.0m,
                            Latitude = 24.085093977757701,
                            Longitude = 32.887073921252401,
                            Name = "Aswan Museum",
                            OpenTime = new TimeOnly(9, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            CloseTime = new TimeOnly(9, 0, 0),
                            Description = "Bab al-Futuh is one of the ancient gates of the historic city of Cairo, Egypt. It was constructed during the 11th century and is known for its impressive architectural design. The gate is adorned with intricate carvings and decorative motifs. It served as a main entrance to the old city and is an important cultural and historical landmark. Visitors can admire the gate's grandeur and learn about Cairo's rich history and heritage.",
                            EgyptianStudentTicketPrice = 0.0m,
                            EgyptianTicketPrice = 0.0m,
                            ForeignStudentTicketPrice = 0.0m,
                            ForeignTicketPrice = 0.0m,
                            Latitude = 30.055467889869401,
                            Longitude = 31.263364602674301,
                            Name = "Bab al-Futuh",
                            OpenTime = new TimeOnly(9, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            CloseTime = new TimeOnly(9, 0, 0),
                            Description = "Bab Zuweila is a historic gate located in the Old City of Cairo, Egypt. It was built in the 11th century and is one of the few remaining gates from the original city walls. The gate is renowned for its architectural beauty, featuring intricate carvings and decorative elements. It served as a significant entrance to the city and a defensive structure. Today, visitors can explore Bab Zuweila and enjoy panoramic views of Cairo from its elevated platforms.\r\n\r\n\r\n\r\n\r\n",
                            EgyptianStudentTicketPrice = 10.0m,
                            EgyptianTicketPrice = 20.0m,
                            ForeignStudentTicketPrice = 50.0m,
                            ForeignTicketPrice = 100.0m,
                            Latitude = 30.042721232524102,
                            Longitude = 31.257780701819801,
                            Name = "Bab Zuweila",
                            OpenTime = new TimeOnly(9, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            CloseTime = new TimeOnly(16, 30, 0),
                            Description = "Baron Empain Palace, also known as the Heliopolis Palace, is a historic landmark located in Heliopolis, Cairo, Egypt. Built in the early 20th century by Belgian industrialist Baron Édouard Empain, it showcases a unique blend of architectural styles, including Hindu and Khmer influences. The palace's distinctive features include its pink hue and intricate detailing. It is considered a masterpiece of architecture and a symbol of Heliopolis. Today, the palace is open to visitors, offering a glimpse into its opulent interiors and the history of its construction.\r\n\r\n\r\n\r\n\r\n",
                            EgyptianStudentTicketPrice = 30.0m,
                            EgyptianTicketPrice = 60.0m,
                            ForeignStudentTicketPrice = 90.0m,
                            ForeignTicketPrice = 180.0m,
                            Latitude = 30.086699776612701,
                            Longitude = 31.330311897686499,
                            Name = "Baron Empain Palace",
                            OpenTime = new TimeOnly(9, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            CloseTime = new TimeOnly(0, 0, 0),
                            Description = "The Cairo Tower is a prominent landmark and observation tower located in Cairo, Egypt. Standing at a height of 187 meters (614 feet), it offers panoramic views of the city's skyline and the Nile River. The tower was constructed in the 1960s and features a futuristic design inspired by lotus flowers and ancient Egyptian architecture. It is a popular tourist attraction and a symbol of modern Cairo. The tower also houses a revolving restaurant, offering a unique dining experience with stunning views.\r\n\r\n\r\n\r\n\r\n",
                            EgyptianStudentTicketPrice = 70.0m,
                            EgyptianTicketPrice = 70.0m,
                            ForeignStudentTicketPrice = 250.0m,
                            ForeignTicketPrice = 250.0m,
                            Latitude = 30.0459258601981,
                            Longitude = 31.224288606195099,
                            Name = "Cairo Tower",
                            OpenTime = new TimeOnly(9, 0, 0)
                        });
                });

            modelBuilder.Entity("Explore_Egypt.Models.LandmarkImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LandmarkId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LandmarkId");

                    b.ToTable("LandmarkImages");
                });

            modelBuilder.Entity("Explore_Egypt.Models.SearchHistory", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("LandmarkID")
                        .HasColumnType("int");

                    b.Property<TimeOnly?>("Date")
                        .HasColumnType("time");

                    b.HasKey("UserId", "LandmarkID");

                    b.HasIndex("LandmarkID");

                    b.ToTable("SearchHistory");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Role", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "security");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "security");
                });

            modelBuilder.Entity("Explore_Egypt.Models.Favour", b =>
                {
                    b.HasOne("Explore_Egypt.Models.Landmark", "Landmark")
                        .WithMany("Favourites")
                        .HasForeignKey("LandmarkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Explore_Egypt.Models.ApplicationUser", "User")
                        .WithMany("Favourites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landmark");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Explore_Egypt.Models.LandmarkImage", b =>
                {
                    b.HasOne("Explore_Egypt.Models.Landmark", "Landmark")
                        .WithMany("Images")
                        .HasForeignKey("LandmarkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landmark");
                });

            modelBuilder.Entity("Explore_Egypt.Models.SearchHistory", b =>
                {
                    b.HasOne("Explore_Egypt.Models.Landmark", "Landmark")
                        .WithMany("SearchHistories")
                        .HasForeignKey("LandmarkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Explore_Egypt.Models.ApplicationUser", "User")
                        .WithMany("SearchHistories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landmark");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Explore_Egypt.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Explore_Egypt.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Explore_Egypt.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Explore_Egypt.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Explore_Egypt.Models.ApplicationUser", b =>
                {
                    b.Navigation("Favourites");

                    b.Navigation("SearchHistories");
                });

            modelBuilder.Entity("Explore_Egypt.Models.Landmark", b =>
                {
                    b.Navigation("Favourites");

                    b.Navigation("Images");

                    b.Navigation("SearchHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
