using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using TestMVCApp.Models;
using Microsoft.Data.Entity.Infrastructure;

namespace TestMVCApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder builder)
        {
            builder
                .HasAnnotation("SqlServer:ValueGeneration", "Identity");

            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("OriginalValueIndex", 0);

                    b.Property<string>("ConcurrencyStamp")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("OriginalValueIndex", 1);

                    b.Property<string>("Name")
                        .HasAnnotation("OriginalValueIndex", 2);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("OriginalValueIndex", 3);

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("OriginalValueIndex", 0);

                    b.Property<string>("ClaimType")
                        .HasAnnotation("OriginalValueIndex", 1);

                    b.Property<string>("ClaimValue")
                        .HasAnnotation("OriginalValueIndex", 2);

                    b.Property<string>("RoleId")
                        .HasAnnotation("OriginalValueIndex", 3);

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("OriginalValueIndex", 0);

                    b.Property<string>("ClaimType")
                        .HasAnnotation("OriginalValueIndex", 1);

                    b.Property<string>("ClaimValue")
                        .HasAnnotation("OriginalValueIndex", 2);

                    b.Property<string>("UserId")
                        .HasAnnotation("OriginalValueIndex", 3);

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("OriginalValueIndex", 0);

                    b.Property<string>("ProviderKey")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("OriginalValueIndex", 1);

                    b.Property<string>("ProviderDisplayName")
                        .HasAnnotation("OriginalValueIndex", 2);

                    b.Property<string>("UserId")
                        .HasAnnotation("OriginalValueIndex", 3);

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasAnnotation("OriginalValueIndex", 0);

                    b.Property<string>("RoleId")
                        .HasAnnotation("OriginalValueIndex", 1);

                    b.HasOne("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            builder.Entity("TestMVCApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("OriginalValueIndex", 0);

                    b.Property<int>("AccessFailedCount")
                        .HasAnnotation("OriginalValueIndex", 1);

                    b.Property<string>("ConcurrencyStamp")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("OriginalValueIndex", 2);

                    b.Property<string>("Email")
                        .HasAnnotation("OriginalValueIndex", 3);

                    b.Property<bool>("EmailConfirmed")
                        .HasAnnotation("OriginalValueIndex", 4);

                    b.Property<bool>("LockoutEnabled")
                        .HasAnnotation("OriginalValueIndex", 5);

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasAnnotation("OriginalValueIndex", 6);

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("OriginalValueIndex", 7);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("OriginalValueIndex", 8);

                    b.Property<string>("PasswordHash")
                        .HasAnnotation("OriginalValueIndex", 9);

                    b.Property<string>("PhoneNumber")
                        .HasAnnotation("OriginalValueIndex", 10);

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasAnnotation("OriginalValueIndex", 11);

                    b.Property<string>("SecurityStamp")
                        .HasAnnotation("OriginalValueIndex", 12);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasAnnotation("OriginalValueIndex", 13);

                    b.Property<string>("UserName")
                        .HasAnnotation("OriginalValueIndex", 14);

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TestMVCApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TestMVCApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            builder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("TestMVCApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
