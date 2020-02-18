using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeuHelp.Models
{
    public class Serviceprovider
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(15)")]
        [StringLength(15)]
        public string Cnpj { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string RazaoSocial { get; set; }
        [Column(TypeName = "VARCHAR(8)")]
        [StringLength(8)]
        public string Cep { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Logradouro { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string Numero { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        [StringLength(20)]
        public string Complemento { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        [StringLength(20)]
        public string Bairro { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        [StringLength(20)]
        public string Cidade { get; set; }
        [Column(TypeName = "VARCHAR(20)")]
        [StringLength(20)]
        public string Estado { get; set; }
        [Column(TypeName = "VARCHAR(90)")]
        [StringLength(90)]
        public string Nome { get; set; }
        [Column(TypeName = "VARCHAR(40)")]
        [StringLength(40)]
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string DataNascimento { get; set; }
        [Column(TypeName = "VARCHAR(11)")]
        [StringLength(11)]
        public string Rg { get; set; }
        [Column(TypeName = "VARCHAR(11)")]
        [StringLength(11)]
        public string Cpf { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string Telefone { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string Celular { get; set; }
        public Typeservice Typeservice { get; set; }
        public int TypeserviceId { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string ValorSaida { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string KmSaida { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string ValorExesso { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string KmExesso { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string ValorPatins { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string ValorRoda { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string ValorDiaEstacionamento { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string ValorDestombamento { get; set; }
        [Column(TypeName = "VARCHAR(10)")]
        [StringLength(10)]
        public string ValorHoraParada { get; set; }
        public Serviceprovider()
        {
        }

        public Serviceprovider(int id, string cnpj, string razaoSocial, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string nome, string email, string dataNascimento, string rg, string cpf, string telefone, string celular, Typeservice typeservice, int typeserviceId, string valorSaida, string kmSaida, string valorExesso, string kmExesso, string valorPatins, string valorRoda, string valorDiaEstacionamento, string valorDestombamento, string valorHoraParada)
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
            Telefone = telefone;
            Celular = celular;
            Typeservice = typeservice;
            TypeserviceId = typeserviceId;
            ValorSaida = valorSaida;
            KmSaida = kmSaida;
            ValorExesso = valorExesso;
            KmExesso = kmExesso;
            ValorPatins = valorPatins;
            ValorRoda = valorRoda;
            ValorDiaEstacionamento = valorDiaEstacionamento;
            ValorDestombamento = valorDestombamento;
            ValorHoraParada = valorHoraParada;
        }
    }
}
