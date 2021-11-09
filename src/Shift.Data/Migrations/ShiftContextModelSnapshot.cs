﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shift.Data.Contexts;

namespace Shift.Data.Migrations
{
    [DbContext(typeof(ShiftContext))]
    partial class ShiftContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shift.Domain.Models.Cidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EstadoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IBGE")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a8b44372-64ec-4e88-bd9e-eff26ce1a238"),
                            EstadoId = new Guid("653214e2-bd65-48f5-9ba1-dda462a4c2ae"),
                            IBGE = "3589505",
                            Nome = "São José do Rio Preto"
                        });
                });

            modelBuilder.Entity("Shift.Domain.Models.Convenio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Convenio");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3f8c80c3-d61c-404f-b955-6b5930443b5c"),
                            Nome = "Particular"
                        },
                        new
                        {
                            Id = new Guid("ff6a905f-41e1-4dc7-90d1-e11e09d811d1"),
                            Nome = "Unimed"
                        },
                        new
                        {
                            Id = new Guid("690b5ff0-ecbb-4960-bc02-a3a4ad61a4a4"),
                            Nome = "HB Saúde"
                        },
                        new
                        {
                            Id = new Guid("f970def0-a027-4fc8-a1d7-60f5ae3568ab"),
                            Nome = "Padre Albino"
                        },
                        new
                        {
                            Id = new Guid("d345f4b9-46ae-4ee1-85b0-3311c5ef2b16"),
                            Nome = "Cassi"
                        });
                });

            modelBuilder.Entity("Shift.Domain.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid>("CidadeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Endereco");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bf7b1fc7-4fc5-4a47-a2b3-d595ab79f72c"),
                            Bairro = "Centro",
                            CidadeId = new Guid("a8b44372-64ec-4e88-bd9e-eff26ce1a238"),
                            Complemento = "",
                            Logradouro = "Av. Bernardino de Campos",
                            Numero = 330
                        },
                        new
                        {
                            Id = new Guid("16cfb302-b06e-4c96-9f8a-8c052a43f723"),
                            Bairro = "Centro",
                            CidadeId = new Guid("a8b44372-64ec-4e88-bd9e-eff26ce1a238"),
                            Complemento = "Sala 1",
                            Logradouro = "Rua General Glicério",
                            Numero = 1050
                        },
                        new
                        {
                            Id = new Guid("35928392-069d-4719-bcc8-9a965fbc2278"),
                            Bairro = "Vila Diniz",
                            CidadeId = new Guid("a8b44372-64ec-4e88-bd9e-eff26ce1a238"),
                            Complemento = "",
                            Logradouro = "Av. Fernando Costa",
                            Numero = 117
                        },
                        new
                        {
                            Id = new Guid("59bd56a3-c295-45c6-91d7-0fe4f3648de3"),
                            Bairro = "Higienopólis",
                            CidadeId = new Guid("a8b44372-64ec-4e88-bd9e-eff26ce1a238"),
                            Complemento = "Apto. 55",
                            Logradouro = "Rua Vírgilio Varzea",
                            Numero = 119
                        },
                        new
                        {
                            Id = new Guid("ca19f566-b325-4f9b-ab75-6b2b3e0042e2"),
                            Bairro = "Centro",
                            CidadeId = new Guid("a8b44372-64ec-4e88-bd9e-eff26ce1a238"),
                            Complemento = "Apto. 11",
                            Logradouro = "Av. Bernardino de Campos",
                            Numero = 580
                        });
                });

            modelBuilder.Entity("Shift.Domain.Models.Especialidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Especialidade");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6d39a0d8-5102-4da2-8620-12af15626968"),
                            Nome = "Clínico Geral"
                        },
                        new
                        {
                            Id = new Guid("c79dd214-bec3-4717-b598-5a71d66d5e63"),
                            Nome = "Oncologia"
                        },
                        new
                        {
                            Id = new Guid("9022b816-4b85-46bb-b92c-70a858ad0ce2"),
                            Nome = "Pediatria"
                        });
                });

            modelBuilder.Entity("Shift.Domain.Models.Estado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IBGE")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Estado");

                    b.HasData(
                        new
                        {
                            Id = new Guid("653214e2-bd65-48f5-9ba1-dda462a4c2ae"),
                            IBGE = "35",
                            Nome = "São Paulo"
                        });
                });

            modelBuilder.Entity("Shift.Domain.Models.Exame", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoANS")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Exame");

                    b.HasData(
                        new
                        {
                            Id = new Guid("30b098e7-b431-4cd4-8f55-f10f774435ba"),
                            CodigoANS = "10010",
                            Descricao = "PSA",
                            Valor = 60.0
                        },
                        new
                        {
                            Id = new Guid("a282fe62-aa5e-40c1-854b-145d46f2306a"),
                            CodigoANS = "10201",
                            Descricao = "Hemograma",
                            Valor = 35.0
                        },
                        new
                        {
                            Id = new Guid("f5075ef1-eced-41f1-8e83-a5f1a0c63de7"),
                            CodigoANS = "12111",
                            Descricao = "Beta HCG",
                            Valor = 40.0
                        },
                        new
                        {
                            Id = new Guid("4c01d50f-e84d-4f62-9a3b-4bf937eb1d65"),
                            CodigoANS = "10115",
                            Descricao = "Urina I",
                            Valor = 80.0
                        });
                });

            modelBuilder.Entity("Shift.Domain.Models.Medico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CRM")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid>("EspecialidadeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("Medico");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dd2f5629-2e68-4a1e-898c-b7724c72441e"),
                            CRM = "110012",
                            EspecialidadeId = new Guid("6d39a0d8-5102-4da2-8620-12af15626968"),
                            Nome = "Fernando Carvalho de Souza"
                        },
                        new
                        {
                            Id = new Guid("ed6d55d6-d08c-4f30-b317-387bf03b27ff"),
                            CRM = "110012",
                            EspecialidadeId = new Guid("c79dd214-bec3-4717-b598-5a71d66d5e63"),
                            Nome = "Eduardo Ferraz"
                        },
                        new
                        {
                            Id = new Guid("628e4867-b913-4c90-8d78-d89c2ce4aeb7"),
                            CRM = "110012",
                            EspecialidadeId = new Guid("9022b816-4b85-46bb-b92c-70a858ad0ce2"),
                            Nome = "Sonia Hildenburg"
                        });
                });

            modelBuilder.Entity("Shift.Domain.Models.OrdemServico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ConvenioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataOrdem")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MedicoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PostoColetaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ConvenioId");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("PostoColetaId");

                    b.ToTable("OrdemServico");

                    b.HasData(
                        new
                        {
                            Id = new Guid("20fd99ee-caa1-4c16-abc4-d51aac4bbbd8"),
                            ConvenioId = new Guid("ff6a905f-41e1-4dc7-90d1-e11e09d811d1"),
                            DataOrdem = new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = new Guid("ed6d55d6-d08c-4f30-b317-387bf03b27ff"),
                            Numero = 1,
                            PacienteId = new Guid("5114ec9c-1c6e-429f-8dac-fd5e00becae4"),
                            PostoColetaId = new Guid("96a32d6c-c783-4ddc-9e9d-f820c7a4090f")
                        });
                });

            modelBuilder.Entity("Shift.Domain.Models.OrdemServicoExame", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrdemServicoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ExameId");

                    b.HasIndex("OrdemServicoId");

                    b.ToTable("OrdemServicoExame");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a6667d69-aa90-4d5d-8b92-3bf601d8847f"),
                            ExameId = new Guid("a282fe62-aa5e-40c1-854b-145d46f2306a"),
                            OrdemServicoId = new Guid("20fd99ee-caa1-4c16-abc4-d51aac4bbbd8"),
                            Valor = 35.0
                        });
                });

            modelBuilder.Entity("Shift.Domain.Models.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Paciente");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a28be555-079e-4aae-80a7-ed8a78732a97"),
                            DataNascimento = new DateTime(1980, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Documento = "28771-0",
                            EnderecoId = new Guid("35928392-069d-4719-bcc8-9a965fbc2278"),
                            Nome = "Fábio Fernandez da Silva",
                            Sexo = 0
                        },
                        new
                        {
                            Id = new Guid("5114ec9c-1c6e-429f-8dac-fd5e00becae4"),
                            DataNascimento = new DateTime(1997, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Documento = "11231-7",
                            EnderecoId = new Guid("59bd56a3-c295-45c6-91d7-0fe4f3648de3"),
                            Nome = "Mariana Mendes de Souze",
                            Sexo = 1
                        },
                        new
                        {
                            Id = new Guid("bf8a6523-8914-4cf7-9b8c-01ee2df7f858"),
                            DataNascimento = new DateTime(1983, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Documento = "199112-7",
                            EnderecoId = new Guid("ca19f566-b325-4f9b-ab75-6b2b3e0042e2"),
                            Nome = "Ernani de Castro",
                            Sexo = 0
                        });
                });

            modelBuilder.Entity("Shift.Domain.Models.PostoColeta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("PostoColeta");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5394d9a4-fa0c-4450-836f-5c3a05b21602"),
                            Descricao = "Laboratório Tabajara",
                            EnderecoId = new Guid("bf7b1fc7-4fc5-4a47-a2b3-d595ab79f72c")
                        },
                        new
                        {
                            Id = new Guid("96a32d6c-c783-4ddc-9e9d-f820c7a4090f"),
                            Descricao = "Laboratório Vita",
                            EnderecoId = new Guid("16cfb302-b06e-4c96-9f8a-8c052a43f723")
                        });
                });

            modelBuilder.Entity("Shift.Domain.Models.Cidade", b =>
                {
                    b.HasOne("Shift.Domain.Models.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .HasConstraintName("FK_Cidade_Estado")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Shift.Domain.Models.Endereco", b =>
                {
                    b.HasOne("Shift.Domain.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Shift.Domain.Models.Medico", b =>
                {
                    b.HasOne("Shift.Domain.Models.Especialidade", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Shift.Domain.Models.OrdemServico", b =>
                {
                    b.HasOne("Shift.Domain.Models.Convenio", "Convenio")
                        .WithMany()
                        .HasForeignKey("ConvenioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Shift.Domain.Models.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Shift.Domain.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Shift.Domain.Models.PostoColeta", "PostoColeta")
                        .WithMany()
                        .HasForeignKey("PostoColetaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Shift.Domain.Models.OrdemServicoExame", b =>
                {
                    b.HasOne("Shift.Domain.Models.Exame", "Exame")
                        .WithMany()
                        .HasForeignKey("ExameId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Shift.Domain.Models.OrdemServico", "OrdemServico")
                        .WithMany("Exames")
                        .HasForeignKey("OrdemServicoId")
                        .HasConstraintName("FK_OrdemServico_OrdemServicoExame")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Shift.Domain.Models.Paciente", b =>
                {
                    b.HasOne("Shift.Domain.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Shift.Domain.Models.PostoColeta", b =>
                {
                    b.HasOne("Shift.Domain.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
