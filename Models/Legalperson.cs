using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MeuHelp.Models
{
    public class Legalperson
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Cargo { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataVencimento { get; set; }
        public string ValorContrato { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InicioVigencia { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FimVigencia { get; set; }
        public Typeservice Typeservice { get; set; }
        public int TypeserviceId { get; set; }
        public ICollection<Collaborator> Collaborators { get; set; } = new List<Collaborator>();

        public Legalperson()
        {
        }

        public Legalperson(int id, string cnpj, string razaoSocial, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string nome, string email, DateTime dataNascimento, string rg, string cpf, string celular, string cargo, DateTime dataVencimento, string valorContrato, DateTime inicioVigencia, DateTime fimVigencia, Typeservice typeservice)
        {
            Id = id;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            Rg = rg;
            Cpf = cpf;
            Celular = celular;
            Cargo = cargo;
            DataVencimento = dataVencimento;
            ValorContrato = valorContrato;
            InicioVigencia = inicioVigencia;
            FimVigencia = fimVigencia;
            Typeservice = typeservice;
        }
    }
}
