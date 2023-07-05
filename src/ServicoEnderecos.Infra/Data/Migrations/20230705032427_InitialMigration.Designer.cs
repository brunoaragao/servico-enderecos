﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServicoEnderecos.Infra.Data;

#nullable disable

namespace ServicoEnderecos.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230705032427_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.Distrito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("MunicipioId")
                        .HasColumnType("int")
                        .HasColumnName("municipio_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("pk_distritos");

                    b.HasIndex("MunicipioId")
                        .HasDatabaseName("ix_distritos_municipio_id");

                    b.ToTable("distritos", (string)null);
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.Mesorregiao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<int>("UFId")
                        .HasColumnType("int")
                        .HasColumnName("uf_id");

                    b.HasKey("Id")
                        .HasName("pk_mesorregioes");

                    b.HasIndex("UFId")
                        .HasDatabaseName("ix_mesorregioes_uf_id");

                    b.ToTable("mesorregioes", (string)null);
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.Microrregiao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("MesorregiaoId")
                        .HasColumnType("int")
                        .HasColumnName("mesorregiao_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.HasKey("Id")
                        .HasName("pk_microrregioes");

                    b.HasIndex("MesorregiaoId")
                        .HasDatabaseName("ix_microrregioes_mesorregiao_id");

                    b.ToTable("microrregioes", (string)null);
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("MicrorregiaoId")
                        .HasColumnType("int")
                        .HasColumnName("microrregiao_id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<int>("RegiaoimediataId")
                        .HasColumnType("int")
                        .HasColumnName("regiaoimediata_id");

                    b.HasKey("Id")
                        .HasName("pk_municipios");

                    b.HasIndex("MicrorregiaoId")
                        .HasDatabaseName("ix_municipios_microrregiao_id");

                    b.HasIndex("RegiaoimediataId")
                        .HasDatabaseName("ix_municipios_regiaoimediata_id");

                    b.ToTable("municipios", (string)null);
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.Regiao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("sigla");

                    b.HasKey("Id")
                        .HasName("pk_regioes");

                    b.ToTable("regioes", (string)null);
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.RegiaoImediata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<int>("RegiaoIntermediariaId")
                        .HasColumnType("int")
                        .HasColumnName("regiao_intermediaria_id");

                    b.HasKey("Id")
                        .HasName("pk_regioes_imediatas");

                    b.HasIndex("RegiaoIntermediariaId")
                        .HasDatabaseName("ix_regioes_imediatas_regiao_intermediaria_id");

                    b.ToTable("regioes_imediatas", (string)null);
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.RegiaoIntermediaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<int>("UFId")
                        .HasColumnType("int")
                        .HasColumnName("uf_id");

                    b.HasKey("Id")
                        .HasName("pk_regioes_intermediaras");

                    b.HasIndex("UFId")
                        .HasDatabaseName("ix_regioes_intermediaras_uf_id");

                    b.ToTable("regioes_intermediaras", (string)null);
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.UF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<int>("RegiaoId")
                        .HasColumnType("int")
                        .HasColumnName("regiao_id");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("sigla");

                    b.HasKey("Id")
                        .HasName("pk_u_fs");

                    b.HasIndex("RegiaoId")
                        .HasDatabaseName("ix_u_fs_regiao_id");

                    b.ToTable("u_fs", (string)null);
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.Distrito", b =>
                {
                    b.HasOne("ServicoEnderecos.Core.Entities.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_distritos_municipios_municipio_id");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.Mesorregiao", b =>
                {
                    b.HasOne("ServicoEnderecos.Core.Entities.UF", "UF")
                        .WithMany()
                        .HasForeignKey("UFId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_mesorregioes_u_fs_uf_id");

                    b.Navigation("UF");
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.Microrregiao", b =>
                {
                    b.HasOne("ServicoEnderecos.Core.Entities.Mesorregiao", "Mesorregiao")
                        .WithMany()
                        .HasForeignKey("MesorregiaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_microrregioes_mesorregioes_mesorregiao_id");

                    b.Navigation("Mesorregiao");
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.Municipio", b =>
                {
                    b.HasOne("ServicoEnderecos.Core.Entities.Microrregiao", "Microrregiao")
                        .WithMany()
                        .HasForeignKey("MicrorregiaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_municipios_microrregioes_microrregiao_id");

                    b.HasOne("ServicoEnderecos.Core.Entities.RegiaoImediata", "Regiaoimediata")
                        .WithMany()
                        .HasForeignKey("RegiaoimediataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_municipios_regioes_imediatas_regiaoimediata_id");

                    b.Navigation("Microrregiao");

                    b.Navigation("Regiaoimediata");
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.RegiaoImediata", b =>
                {
                    b.HasOne("ServicoEnderecos.Core.Entities.RegiaoIntermediaria", "Regiaointermediaria")
                        .WithMany()
                        .HasForeignKey("RegiaoIntermediariaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_regioes_imediatas_regioes_intermediaras_regiao_intermediaria");

                    b.Navigation("Regiaointermediaria");
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.RegiaoIntermediaria", b =>
                {
                    b.HasOne("ServicoEnderecos.Core.Entities.UF", "UF")
                        .WithMany()
                        .HasForeignKey("UFId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_regioes_intermediaras_u_fs_uf_id");

                    b.Navigation("UF");
                });

            modelBuilder.Entity("ServicoEnderecos.Core.Entities.UF", b =>
                {
                    b.HasOne("ServicoEnderecos.Core.Entities.Regiao", "Regiao")
                        .WithMany()
                        .HasForeignKey("RegiaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_u_fs_regioes_regiao_id");

                    b.Navigation("Regiao");
                });
#pragma warning restore 612, 618
        }
    }
}