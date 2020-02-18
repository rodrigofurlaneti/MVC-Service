﻿// <auto-generated />
using System;
using MeuHelp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MeuHelp.Migrations
{
    [DbContext(typeof(MeuHelpContext))]
    [Migration("20200113224905_Initial10")]
    partial class Initial10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MeuHelp.Models.Collaborator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnoVeiculo");

                    b.Property<string>("Bairro");

                    b.Property<string>("Celular");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Conta");

                    b.Property<string>("Cpf");

                    b.Property<string>("DataAdesao");

                    b.Property<string>("DataNascimento");

                    b.Property<string>("DataPagamento");

                    b.Property<string>("DataVencimentoAdesao");

                    b.Property<string>("DataVenda");

                    b.Property<string>("Email");

                    b.Property<string>("Estado");

                    b.Property<string>("FimVigencia");

                    b.Property<string>("InicioVigencia");

                    b.Property<int>("LegalpersonId");

                    b.Property<string>("Logradouro");

                    b.Property<string>("ModeloVeiculo");

                    b.Property<string>("Nome");

                    b.Property<string>("NomeMae");

                    b.Property<string>("Numero");

                    b.Property<string>("PlacaVeiculo");

                    b.Property<int>("PlanId");

                    b.Property<string>("Rg");

                    b.Property<int>("SaleschannelId");

                    b.Property<string>("Sexo");

                    b.Property<int>("ShippingwayId");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("LegalpersonId");

                    b.HasIndex("PlanId");

                    b.HasIndex("SaleschannelId");

                    b.HasIndex("ShippingwayId");

                    b.ToTable("Collaborator");
                });

            modelBuilder.Entity("MeuHelp.Models.Legalperson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cargo");

                    b.Property<string>("Celular");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<DateTime>("DataVencimento");

                    b.Property<string>("Email");

                    b.Property<string>("Estado");

                    b.Property<DateTime>("FimVigencia");

                    b.Property<DateTime>("InicioVigencia");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("Rg");

                    b.Property<int>("TypeserviceId");

                    b.Property<string>("ValorContrato");

                    b.HasKey("Id");

                    b.HasIndex("TypeserviceId");

                    b.ToTable("Legalperson");
                });

            modelBuilder.Entity("MeuHelp.Models.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Celular");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Estado");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Nome");

                    b.Property<string>("NomeMae");

                    b.Property<string>("Numero");

                    b.Property<string>("QuantFuncionarios");

                    b.Property<string>("Rg");

                    b.Property<string>("Sexo");

                    b.Property<string>("Telefone");

                    b.Property<int>("TypeserviceId");

                    b.HasKey("Id");

                    b.HasIndex("TypeserviceId");

                    b.ToTable("Partner");
                });

            modelBuilder.Entity("MeuHelp.Models.Physicalperson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnoVeiculo");

                    b.Property<string>("Bairro");

                    b.Property<string>("Celular");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataAdesao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<DateTime>("DataPagamento");

                    b.Property<DateTime>("DataVencimentoAdesao");

                    b.Property<DateTime>("DataVenda");

                    b.Property<string>("Email");

                    b.Property<string>("Estado");

                    b.Property<DateTime>("FimVigencia");

                    b.Property<DateTime>("InicioVigencia");

                    b.Property<string>("Logradouro");

                    b.Property<string>("ModeloVeiculo");

                    b.Property<string>("Nome")
                        .HasColumnType("VARCHAR(90)");

                    b.Property<string>("NomeMae");

                    b.Property<string>("Numero");

                    b.Property<string>("PlacaVeiculo");

                    b.Property<int>("PlanId");

                    b.Property<string>("Rg");

                    b.Property<int>("SaleschannelId");

                    b.Property<string>("Sexo");

                    b.Property<int>("ShippingwayId");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.HasIndex("SaleschannelId");

                    b.HasIndex("ShippingwayId");

                    b.ToTable("Physicalperson");
                });

            modelBuilder.Entity("MeuHelp.Models.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("MeuHelp.Models.Saleschannel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Saleschannel");
                });

            modelBuilder.Entity("MeuHelp.Models.Serviceprovider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Celular");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Cnpj");

                    b.Property<string>("Complemento");

                    b.Property<string>("Cpf");

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Estado");

                    b.Property<string>("KmExesso");

                    b.Property<string>("KmSaida");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Nome");

                    b.Property<string>("Numero");

                    b.Property<string>("RazaoSocial");

                    b.Property<string>("Rg");

                    b.Property<string>("Telefone");

                    b.Property<int>("TypeserviceId");

                    b.Property<string>("ValorDestombamento");

                    b.Property<string>("ValorDiaEstacionamento");

                    b.Property<string>("ValorExesso");

                    b.Property<string>("ValorHoraParada");

                    b.Property<string>("ValorPatins");

                    b.Property<string>("ValorRoda");

                    b.Property<string>("ValorSaida");

                    b.HasKey("Id");

                    b.HasIndex("TypeserviceId");

                    b.ToTable("Serviceprovider");
                });

            modelBuilder.Entity("MeuHelp.Models.Shippingway", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Shippingway");
                });

            modelBuilder.Entity("MeuHelp.Models.Typeservice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Typeservice");
                });

            modelBuilder.Entity("MeuHelp.Models.Collaborator", b =>
                {
                    b.HasOne("MeuHelp.Models.Legalperson", "Legalperson")
                        .WithMany("Collaborators")
                        .HasForeignKey("LegalpersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MeuHelp.Models.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MeuHelp.Models.Saleschannel", "Saleschannel")
                        .WithMany()
                        .HasForeignKey("SaleschannelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MeuHelp.Models.Shippingway", "Shippingway")
                        .WithMany()
                        .HasForeignKey("ShippingwayId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MeuHelp.Models.Legalperson", b =>
                {
                    b.HasOne("MeuHelp.Models.Typeservice", "Typeservice")
                        .WithMany()
                        .HasForeignKey("TypeserviceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MeuHelp.Models.Partner", b =>
                {
                    b.HasOne("MeuHelp.Models.Typeservice", "Typeservice")
                        .WithMany()
                        .HasForeignKey("TypeserviceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MeuHelp.Models.Physicalperson", b =>
                {
                    b.HasOne("MeuHelp.Models.Plan", "Plan")
                        .WithMany("Physicalpersons")
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MeuHelp.Models.Saleschannel", "Saleschannel")
                        .WithMany("Physicalpersons")
                        .HasForeignKey("SaleschannelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MeuHelp.Models.Shippingway", "Shippingway")
                        .WithMany("Physicalpersons")
                        .HasForeignKey("ShippingwayId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MeuHelp.Models.Serviceprovider", b =>
                {
                    b.HasOne("MeuHelp.Models.Typeservice", "Typeservice")
                        .WithMany()
                        .HasForeignKey("TypeserviceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
