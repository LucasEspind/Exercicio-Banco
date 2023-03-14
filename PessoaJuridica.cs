using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    public class PessoaJuridica : Cliente
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataCriacao { get; set; }
        public int TempoAtividade { get { return (int)(Math.Floor((DateTime.Now - DataCriacao).TotalDays / 365.25)); } private set { } }

        public override string ResumoCliente()
        {
            return $"{NumeroConta}                | Conta Pessoa Juridica | Razão Social: {RazaoSocial} | CNPJ: {CNPJ}";
        }
    }
}
