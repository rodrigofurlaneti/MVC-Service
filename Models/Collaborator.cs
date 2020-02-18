using MySql.Data.MySqlClient;
using System;
using System.ComponentModel.DataAnnotations;

namespace MeuHelp.Models
{
    public class Collaborator
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Legalperson Legalperson { get; set; }
        public int LegalpersonId { get; set; }
        public string Email { get; set; }
        public string DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string NomeMae { get; set; }
        public string Sexo { get; set; }
        public Shippingway Shippingway { get; set; }
        public int ShippingwayId { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string PlacaVeiculo { get; set; }
        public string AnoVeiculo { get; set; }
        public string ModeloVeiculo { get; set; }
        public string DataPagamento { get; set; }
        public Plan Plan { get; set; }
        public int PlanId { get; set; }
        public string InicioVigencia { get; set; }
        public string FimVigencia { get; set; }
        public string DataVenda { get; set; }
        public string DataVencimentoAdesao { get; set; }
        public string DataAdesao { get; set; }
        public Saleschannel Saleschannel { get; set; }
        public int SaleschannelId { get; set; }
        public string Conta { get; set; }
        public string Odonto { get; set; }

        public Collaborator(int id, string nome, Legalperson legalperson, int legalpersonId, string email, string dataNascimento, string rg, string cpf, string celular, string telefone, string nomeMae, string sexo, Shippingway shippingway, int shippingwayId, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string placaVeiculo, string anoVeiculo, string modeloVeiculo, string dataPagamento, Plan plan, int planId, string inicioVigencia, string fimVigencia, string dataVenda, string dataVencimentoAdesao, string dataAdesao, Saleschannel saleschannel, int saleschannelId, string conta, string odonto)
        {
            Id = id;
            Nome = nome;
            Legalperson = legalperson;
            LegalpersonId = legalpersonId;
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
            Conta = conta;
            Odonto = odonto;
        }
        public Collaborator()
        {
        }
    }
}