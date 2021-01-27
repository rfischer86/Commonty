﻿// <auto-generated />
using BuildLogger_DB_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BuildLogger.Migrations
{
    [DbContext(typeof(BuildLoggerContext))]
    [Migration("20210121164444_Formular-1")]
    partial class Formular1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("BuildLogger_DB_Context.BuildLogRef", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<int?>("buildStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("errorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("projectId")
                        .HasColumnType("TEXT");

                    b.Property<string>("serverId")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("BuildLog");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.Error", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("code")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Error");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.Form", b =>
                {
                    b.Property<string>("apiId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FormapiId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("activ")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isValid")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("local")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("parentFormularId")
                        .HasColumnType("TEXT");

                    b.Property<string>("version")
                        .HasColumnType("TEXT");

                    b.HasKey("apiId");

                    b.HasIndex("FormapiId");

                    b.ToTable("Form");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.FormElement", b =>
                {
                    b.Property<string>("apiId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FormapiId")
                        .HasColumnType("TEXT");

                    b.Property<string>("defaultValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<int>("formType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("label")
                        .HasColumnType("TEXT");

                    b.Property<string>("metaData")
                        .HasColumnType("TEXT");

                    b.Property<bool>("required")
                        .HasColumnType("INTEGER");

                    b.Property<string>("unit")
                        .HasColumnType("TEXT");

                    b.Property<bool>("valid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("value")
                        .HasColumnType("TEXT");

                    b.Property<string>("version")
                        .HasColumnType("TEXT");

                    b.Property<string>("widthClass")
                        .HasColumnType("TEXT");

                    b.HasKey("apiId");

                    b.HasIndex("FormapiId");

                    b.ToTable("FormElement");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.FormForm", b =>
                {
                    b.Property<string>("child_API_Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("parent_API_Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("apiId")
                        .HasColumnType("TEXT");

                    b.Property<string>("childapiId")
                        .HasColumnType("TEXT");

                    b.Property<string>("parentapiId")
                        .HasColumnType("TEXT");

                    b.HasKey("child_API_Id", "parent_API_Id");

                    b.HasIndex("childapiId");

                    b.HasIndex("parentapiId");

                    b.ToTable("FormForm");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.FormFormElement", b =>
                {
                    b.Property<string>("apiId")
                        .HasColumnType("TEXT");

                    b.Property<string>("child_API_Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("childapiId")
                        .HasColumnType("TEXT");

                    b.Property<string>("parent_API_Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("parentapiId")
                        .HasColumnType("TEXT");

                    b.HasKey("apiId");

                    b.HasIndex("childapiId");

                    b.HasIndex("parentapiId");

                    b.HasIndex("child_API_Id", "parent_API_Id");

                    b.ToTable("FormFormElement");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.Nav", b =>
                {
                    b.Property<string>("apiId")
                        .HasColumnType("TEXT");

                    b.Property<string>("NavapiId")
                        .HasColumnType("TEXT");

                    b.Property<string>("contentType")
                        .HasColumnType("TEXT");

                    b.Property<string>("link")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("state")
                        .HasColumnType("TEXT");

                    b.Property<string>("type")
                        .HasColumnType("TEXT");

                    b.HasKey("apiId");

                    b.HasIndex("NavapiId");

                    b.ToTable("Nav");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.NavNav", b =>
                {
                    b.Property<string>("child_API_Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("parent_API_Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("childapiId")
                        .HasColumnType("TEXT");

                    b.Property<string>("parentapiId")
                        .HasColumnType("TEXT");

                    b.HasKey("child_API_Id", "parent_API_Id");

                    b.HasIndex("childapiId");

                    b.HasIndex("parentapiId");

                    b.ToTable("NavNav");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.Text", b =>
                {
                    b.Property<string>("apiId")
                        .HasColumnType("TEXT");

                    b.Property<string>("contentData")
                        .HasColumnType("TEXT");

                    b.HasKey("apiId");

                    b.ToTable("Text");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.Form", b =>
                {
                    b.HasOne("BuildLogger_DB_Context.Form", null)
                        .WithMany("subFormulars")
                        .HasForeignKey("FormapiId");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.FormElement", b =>
                {
                    b.HasOne("BuildLogger_DB_Context.Form", null)
                        .WithMany("formElements")
                        .HasForeignKey("FormapiId");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.FormForm", b =>
                {
                    b.HasOne("BuildLogger_DB_Context.Form", "child")
                        .WithMany()
                        .HasForeignKey("childapiId");

                    b.HasOne("BuildLogger_DB_Context.Form", "parent")
                        .WithMany()
                        .HasForeignKey("parentapiId");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.FormFormElement", b =>
                {
                    b.HasOne("BuildLogger_DB_Context.FormElement", "child")
                        .WithMany()
                        .HasForeignKey("childapiId");

                    b.HasOne("BuildLogger_DB_Context.Form", "parent")
                        .WithMany()
                        .HasForeignKey("parentapiId");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.Nav", b =>
                {
                    b.HasOne("BuildLogger_DB_Context.Nav", null)
                        .WithMany("navData")
                        .HasForeignKey("NavapiId");
                });

            modelBuilder.Entity("BuildLogger_DB_Context.NavNav", b =>
                {
                    b.HasOne("BuildLogger_DB_Context.Nav", "child")
                        .WithMany()
                        .HasForeignKey("childapiId");

                    b.HasOne("BuildLogger_DB_Context.Nav", "parent")
                        .WithMany()
                        .HasForeignKey("parentapiId");
                });
#pragma warning restore 612, 618
        }
    }
}