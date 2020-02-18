using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeuHelp.Models
{
    public class Physicalperson
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Nome { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        [StringLength(15)]
        public string Rg { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        [StringLength(15)]
        public string Cpf { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        [StringLength(15)]
        public string Celular { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        [StringLength(15)]
        public string Telefone { get; set; }
        [Column(TypeName = "VARCHAR(90)")]
        [StringLength(90)]
        public string NomeMae { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string Sexo { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public Shippingway Shippingway { get; set; }
        [Column(TypeName = "INT(4)")]
        public int ShippingwayId { get; set; }
        [Column(TypeName = "VARCHAR(8)")]
        public string Cep { get; set; }
        [Column(TypeName = "VARCHAR(55)")]
        public string Logradouro { get; set; }
        [Column(TypeName = "VARCHAR(5)")]
        public string Numero { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string Complemento { get; set; }
        [Column(TypeName = "VARCHAR(40)")]
        public string Bairro { get; set; }
        [Column(TypeName = "VARCHAR(40)")]
        public string Cidade { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string Estado { get; set; }
        [Column(TypeName = "VARCHAR(7)")]
        [StringLength(7, MinimumLength = 0, ErrorMessage = "Placa deve ter entre 0 e 7 caracteres!")]
        public string PlacaVeiculo { get; set; }
        [Column(TypeName = "VARCHAR(4)")]
        [StringLength(4, MinimumLength = 0, ErrorMessage = "Ano deve ter entre 0 e 7 caracteres!")]
        public string AnoVeiculo { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        public string ModeloVeiculo { get; set; }
        [Column(TypeName = "VARCHAR(4)")]
        public string DataPagamento { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public Plan Plan { get; set; }
        public int PlanId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InicioVigencia { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FimVigencia { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataVenda { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataVencimentoAdesao { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataAdesao { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public Saleschannel Saleschannel { get; set; }
        [Column(TypeName = "INT(4)")]
        public int SaleschannelId { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        public string Odonto { get; set; }

        public Physicalperson()
        {
        }

        public Physicalperson(int id, string nome, string email, DateTime dataNascimento, string rg, string cpf, string celular, string telefone, string nomeMae, string sexo, Shippingway shippingway, int shippingwayId, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string placaVeiculo, string anoVeiculo, string modeloVeiculo, string dataPagamento, Plan plan, int planId, DateTime inicioVigencia, DateTime fimVigencia, DateTime dataVenda, DateTime dataVencimentoAdesao, DateTime dataAdesao, Saleschannel saleschannel, int saleschannelId, string odonto)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Rg = rg;
            Cpf = cpf;
            Celular = celular;
            Telefone = telefone;
            NomeMae = nomeMae;
            Sexo = sexo;
            Shippingway = shippingway;
            ShippingwayId = shippingwayId;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            PlacaVeiculo = placaVeiculo;
            AnoVeiculo = anoVeiculo;
            ModeloVeiculo = modeloVeiculo;
            DataPagamento = dataPagamento;
            Plan = plan;
            PlanId = planId;
            InicioVigencia = inicioVigencia;
            FimVigencia = fimVigencia;
            DataVenda = dataVenda;
            DataVencimentoAdesao = dataVencimentoAdesao;
            DataAdesao = dataAdesao;
            Saleschannel = saleschannel;
            SaleschannelId = saleschannelId;
            Odonto = odonto;
        }
    }
}