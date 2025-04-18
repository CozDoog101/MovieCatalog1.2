﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieCatalog1._2.Data;

#nullable disable

namespace MovieCatalog1._2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250408153015_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.ToTable("AspNetRoles", (string)null);
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

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

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

                    b.ToTable("AspNetUsers", (string)null);
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

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MovieCatalog1._2.Data.Models.Movies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CoverImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoverImage = "/images/movies/inception.jpg",
                            CreatedBy = "Admin",
                            Description = "A mind-bending thriller about dreams within dreams.",
                            Genre = "Sci-Fi",
                            Rating = 8.8000000000000007,
                            Title = "Inception",
                            Year = 2010
                        },
                        new
                        {
                            Id = 2,
                            CoverImage = "/images/movies/TheDarkNight.jpg",
                            CreatedBy = "Admin",
                            Description = "Batman faces off against the Joker in a chaotic fight for Gotham.",
                            Genre = "Action",
                            Rating = 9.0,
                            Title = "The Dark Knight",
                            Year = 2008
                        },
                        new
                        {
                            Id = 3,
                            CoverImage = "/images/movies/TheMatrix.jpg",
                            CreatedBy = "Admin",
                            Description = "A computer hacker learns from mysterious rebels about the true nature of his reality.",
                            Genre = "Sci-Fi",
                            Rating = 8.6999999999999993,
                            Title = "The Matrix",
                            Year = 1999
                        },
                        new
                        {
                            Id = 4,
                            CoverImage = "/images/movies/interstellar.jpg",
                            CreatedBy = "Admin",
                            Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                            Genre = "Sci-Fi",
                            Rating = 8.5999999999999996,
                            Title = "Interstellar",
                            Year = 2014
                        },
                        new
                        {
                            Id = 5,
                            CoverImage = "/images/movies/fightclub.jpg",
                            CreatedBy = "Admin",
                            Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club.",
                            Genre = "Drama",
                            Rating = 8.8000000000000007,
                            Title = "Fight Club",
                            Year = 1999
                        },
                        new
                        {
                            Id = 6,
                            CoverImage = "/images/movies/pulpfiction.jpg",
                            CreatedBy = "Admin",
                            Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            Genre = "Crime",
                            Rating = 8.9000000000000004,
                            Title = "Pulp Fiction",
                            Year = 1994
                        },
                        new
                        {
                            Id = 7,
                            CoverImage = "/images/movies/forrestgump.jpg",
                            CreatedBy = "Admin",
                            Description = "The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75.",
                            Genre = "Drama",
                            Rating = 8.8000000000000007,
                            Title = "Forrest Gump",
                            Year = 1994
                        },
                        new
                        {
                            Id = 8,
                            CoverImage = "/images/movies/thegodfather.jpg",
                            CreatedBy = "Admin",
                            Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                            Genre = "Crime",
                            Rating = 9.1999999999999993,
                            Title = "The Godfather",
                            Year = 1972
                        },
                        new
                        {
                            Id = 9,
                            CoverImage = "/images/movies/shawshank.jpg",
                            CreatedBy = "Admin",
                            Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            Genre = "Drama",
                            Rating = 9.3000000000000007,
                            Title = "The Shawshank Redemption",
                            Year = 1994
                        },
                        new
                        {
                            Id = 10,
                            CoverImage = "/images/movies/schindlerslist.jpg",
                            CreatedBy = "Admin",
                            Description = "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                            Genre = "History",
                            Rating = 9.0,
                            Title = "Schindler's List",
                            Year = 1993
                        },
                        new
                        {
                            Id = 11,
                            CoverImage = "/images/movies/gladiator.jpg",
                            CreatedBy = "Admin",
                            Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",
                            Genre = "Action",
                            Rating = 8.5,
                            Title = "Gladiator",
                            Year = 2000
                        },
                        new
                        {
                            Id = 12,
                            CoverImage = "/images/movies/silenceofthelambs.jpg",
                            CreatedBy = "Admin",
                            Description = "A young FBI cadet seeks the advice of an imprisoned cannibal killer to help catch another serial killer.",
                            Genre = "Thriller",
                            Rating = 8.5999999999999996,
                            Title = "The Silence of the Lambs",
                            Year = 1991
                        },
                        new
                        {
                            Id = 13,
                            CoverImage = "/images/movies/savingprivateryan.jpg",
                            CreatedBy = "Admin",
                            Description = "Following the Normandy landings, a group of U.S. soldiers must find and bring home a paratrooper whose brothers have been killed in action.",
                            Genre = "War",
                            Rating = 8.5999999999999996,
                            Title = "Saving Private Ryan",
                            Year = 1998
                        },
                        new
                        {
                            Id = 14,
                            CoverImage = "/images/movies/lionking.jpg",
                            CreatedBy = "Admin",
                            Description = "Lion prince Simba and his father are targeted by his bitter uncle, who wants to ascend the throne himself.",
                            Genre = "Animation",
                            Rating = 8.5,
                            Title = "The Lion King",
                            Year = 1994
                        },
                        new
                        {
                            Id = 15,
                            CoverImage = "/images/movies/prestige.jpg",
                            CreatedBy = "Admin",
                            Description = "Two magicians engage in a bitter rivalry, each trying to best the other with their tricks and illusions.",
                            Genre = "Mystery",
                            Rating = 8.5,
                            Title = "The Prestige",
                            Year = 2006
                        },
                        new
                        {
                            Id = 16,
                            CoverImage = "/images/movies/avatar.jpg",
                            CreatedBy = "Admin",
                            Description = "A paraplegic Marine dispatched to the moon Pandora on a unique mission becomes torn between following his orders and protecting the world he feels is his home.",
                            Genre = "Sci-Fi",
                            Rating = 7.7999999999999998,
                            Title = "Avatar",
                            Year = 2009
                        },
                        new
                        {
                            Id = 17,
                            CoverImage = "/images/movies/thedeparted.jpg",
                            CreatedBy = "Admin",
                            Description = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in Boston.",
                            Genre = "Crime",
                            Rating = 8.5,
                            Title = "The Departed",
                            Year = 2006
                        },
                        new
                        {
                            Id = 18,
                            CoverImage = "/images/movies/shutterisland.jpg",
                            CreatedBy = "Admin",
                            Description = "A U.S. Marshal investigates the disappearance of a murderer who escaped from a mental institution.",
                            Genre = "Thriller",
                            Rating = 8.0999999999999996,
                            Title = "Shutter Island",
                            Year = 2010
                        },
                        new
                        {
                            Id = 19,
                            CoverImage = "/images/movies/revenant.jpg",
                            CreatedBy = "Admin",
                            Description = "A frontiersman on a quest for survival and revenge against those who left him for dead.",
                            Genre = "Adventure",
                            Rating = 8.0,
                            Title = "The Revenant",
                            Year = 2015
                        },
                        new
                        {
                            Id = 20,
                            CoverImage = "/images/movies/lalaland.jpg",
                            CreatedBy = "Admin",
                            Description = "A jazz musician and an aspiring actress fall in love, but their ambitions threaten to tear them apart.",
                            Genre = "Romance",
                            Rating = 8.0,
                            Title = "La La Land",
                            Year = 2016
                        },
                        new
                        {
                            Id = 21,
                            CoverImage = "/images/movies/grandbudapest.jpg",
                            CreatedBy = "Admin",
                            Description = "The adventures of a legendary concierge at a famous European hotel between the wars.",
                            Genre = "Comedy",
                            Rating = 8.0999999999999996,
                            Title = "The Grand Budapest Hotel",
                            Year = 2014
                        },
                        new
                        {
                            Id = 22,
                            CoverImage = "/images/movies/gonegirl.jpg",
                            CreatedBy = "Admin",
                            Description = "A man becomes the prime suspect in the disappearance of his wife, unraveling secrets along the way.",
                            Genre = "Mystery",
                            Rating = 8.0999999999999996,
                            Title = "Gone Girl",
                            Year = 2014
                        },
                        new
                        {
                            Id = 23,
                            CoverImage = "/images/movies/her.jpg",
                            CreatedBy = "Admin",
                            Description = "A man develops a romantic relationship with an artificial intelligence system.",
                            Genre = "Romance",
                            Rating = 8.0,
                            Title = "Her",
                            Year = 2013
                        },
                        new
                        {
                            Id = 24,
                            CoverImage = "/images/movies/bladerunner2049.jpg",
                            CreatedBy = "Admin",
                            Description = "A new blade runner unearths a long-buried secret that could plunge what's left of society into chaos.",
                            Genre = "Sci-Fi",
                            Rating = 8.0,
                            Title = "Blade Runner 2049",
                            Year = 2017
                        },
                        new
                        {
                            Id = 25,
                            CoverImage = "/images/movies/django.jpg",
                            CreatedBy = "Admin",
                            Description = "A freed slave sets out to rescue his wife from a brutal plantation owner.",
                            Genre = "Western",
                            Rating = 8.4000000000000004,
                            Title = "Django Unchained",
                            Year = 2012
                        },
                        new
                        {
                            Id = 26,
                            CoverImage = "/images/movies/martian.jpg",
                            CreatedBy = "Admin",
                            Description = "An astronaut is stranded on Mars and must use his ingenuity to survive while awaiting rescue.",
                            Genre = "Sci-Fi",
                            Rating = 8.0,
                            Title = "The Martian",
                            Year = 2015
                        },
                        new
                        {
                            Id = 27,
                            CoverImage = "/images/movies/madmax.jpg",
                            CreatedBy = "Admin",
                            Description = "In a post-apocalyptic wasteland, Max teams up with a rebel warrior to escape a tyrannical warlord.",
                            Genre = "Action",
                            Rating = 8.0999999999999996,
                            Title = "Mad Max: Fury Road",
                            Year = 2015
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
