﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoSGOS.Models;

#nullable disable

namespace ProjetoSGOS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240515204227_ValidacoesTeste")]
    partial class ValidacoesTeste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("ProjetoSGOS.Models.Acabamento", b =>
                {
                    b.Property<string>("AcabamentoId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("AcabamentoId");

                    b.ToTable("Acabamentos");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.Cliente", b =>
                {
                    b.Property<string>("ClienteId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("RG")
                        .IsUnique();

                    b.HasIndex("RG", "CPF")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.Equipamento", b =>
                {
                    b.Property<string>("EquipamentoId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("EquipamentoId");

                    b.ToTable("Equipamentos");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.Funcionario", b =>
                {
                    b.Property<string>("FuncionarioId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Senha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Usuario")
                        .HasColumnType("TEXT");

                    b.HasKey("FuncionarioId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.OrdemServico", b =>
                {
                    b.Property<string>("OrdemServicoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClienteId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("TEXT");

                    b.Property<string>("FuncionarioId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("OrdemServicoId");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("OrdemServicos");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.Pagamento", b =>
                {
                    b.Property<string>("PagamentoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Forma")
                        .HasColumnType("TEXT");

                    b.Property<string>("OrdemServicoId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("PagamentoId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.Produto", b =>
                {
                    b.Property<string>("ProdutoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("AcabamentoId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("EquipamentoId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<double>("Preco")
                        .HasColumnType("REAL");

                    b.HasKey("ProdutoId");

                    b.HasIndex("AcabamentoId");

                    b.HasIndex("EquipamentoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.OrdemServico", b =>
                {
                    b.HasOne("ProjetoSGOS.Models.Funcionario", "Funcionario")
                        .WithMany("OrdemServicos")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoSGOS.Models.Cliente", "Cliente")
                        .WithMany("OrdemServicos")
                        .HasForeignKey("OrdemServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.Pagamento", b =>
                {
                    b.HasOne("ProjetoSGOS.Models.OrdemServico", "OrdemServico")
                        .WithMany("Pagamentos")
                        .HasForeignKey("PagamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrdemServico");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.Produto", b =>
                {
                    b.HasOne("ProjetoSGOS.Models.Acabamento", "Acabamento")
                        .WithMany("Produtos")
                        .HasForeignKey("AcabamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoSGOS.Models.Equipamento", "Equipamento")
                        .WithMany("Produtos")
                        .HasForeignKey("EquipamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acabamento");

                    b.Navigation("Equipamento");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.Acabamento", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.Cliente", b =>
                {
                    b.Navigation("OrdemServicos");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.Equipamento", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.Funcionario", b =>
                {
                    b.Navigation("OrdemServicos");
                });

            modelBuilder.Entity("ProjetoSGOS.Models.OrdemServico", b =>
                {
                    b.Navigation("Pagamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
