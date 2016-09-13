using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using to_do.Store;

namespace todo.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20160912222716_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("to_do.Model.ToDo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Property<Guid?>("ToDoTypeId");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ToDoTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("ToDoItems");
                });

            modelBuilder.Entity("to_do.Model.ToDoType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("ToDoTypes");
                });

            modelBuilder.Entity("to_do.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("to_do.Model.ToDo", b =>
                {
                    b.HasOne("to_do.Model.ToDoType", "ToDoType")
                        .WithMany()
                        .HasForeignKey("ToDoTypeId");

                    b.HasOne("to_do.Model.User")
                        .WithMany("ToDoItems")
                        .HasForeignKey("UserId");
                });
        }
    }
}
