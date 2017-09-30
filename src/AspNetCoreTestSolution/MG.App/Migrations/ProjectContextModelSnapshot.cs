﻿// <auto-generated />
using MG.Entity.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MG.App.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MG.Entity.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(250);

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("District")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<bool>("EmailChecked")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("HeadImgUrl")
                        .HasMaxLength(200);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("IsEnableed");

                    b.Property<string>("LastLoginIP")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LastLoginTime");

                    b.Property<DateTime?>("LastWeixinSignInTime");

                    b.Property<string>("NickName")
                        .HasMaxLength(50);

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<int?>("OrganizeId");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("PhoneChecked")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("PicUrl")
                        .HasMaxLength(200);

                    b.Property<string>("Province")
                        .HasMaxLength(50);

                    b.Property<string>("QQ")
                        .HasMaxLength(50);

                    b.Property<string>("RealName")
                        .HasMaxLength(50);

                    b.Property<int>("Sex")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Tel")
                        .HasMaxLength(50);

                    b.Property<string>("ThisLoginIP")
                        .HasMaxLength(50);

                    b.Property<DateTime>("ThisLoginTime");

                    b.Property<int>("Type")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Wallet")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0m);

                    b.Property<string>("WeixinOpenId")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("OrganizeId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("MG.Entity.SysOrganize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(200);

                    b.Property<string>("EnCode")
                        .HasMaxLength(50);

                    b.Property<string>("Fax")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("GuidId")
                        .IsRequired()
                        .HasColumnName("Guid")
                        .HasMaxLength(36);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("IsEnableed");

                    b.Property<int?>("Layer");

                    b.Property<string>("ManagerId")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifyTime");

                    b.Property<string>("ModifyUser")
                        .HasMaxLength(50);

                    b.Property<int?>("ParentId");

                    b.Property<string>("Remark")
                        .HasMaxLength(50);

                    b.Property<int?>("SortCode")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("TelePhone")
                        .HasMaxLength(50);

                    b.Property<short?>("Type");

                    b.Property<string>("WeChat")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("SysOrganize");
                });

            modelBuilder.Entity("MG.Entity.SysRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("AllowEdit")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .HasMaxLength(50);

                    b.Property<string>("EnCode")
                        .HasMaxLength(50);

                    b.Property<string>("GuidId")
                        .IsRequired()
                        .HasColumnName("Guid")
                        .HasMaxLength(36);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsEnableed");

                    b.Property<DateTime?>("ModifyTime");

                    b.Property<string>("ModifyUser")
                        .HasMaxLength(50);

                    b.Property<string>("Remark")
                        .HasMaxLength(50);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("SortCode")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<short?>("Type");

                    b.HasKey("Id");

                    b.ToTable("SysRole");
                });

            modelBuilder.Entity("MG.Entity.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .HasMaxLength(50);

                    b.Property<string>("GuidId")
                        .IsRequired()
                        .HasColumnName("Guid")
                        .HasMaxLength(36);

                    b.Property<int>("RoleId");

                    b.Property<int?>("SortCode");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("MG.Entity.Account", b =>
                {
                    b.HasOne("MG.Entity.SysOrganize", "Organize")
                        .WithMany("Accounts")
                        .HasForeignKey("OrganizeId");
                });

            modelBuilder.Entity("MG.Entity.UserRole", b =>
                {
                    b.HasOne("MG.Entity.SysRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MG.Entity.Account", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
