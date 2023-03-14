using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    internal class ClienteServices : IClienteServices
    {
        public static List<Cliente> clientes { get; set; }

        static ClienteServices()
        {
            clientes = new List<Cliente>();
        }

        public void CriarConta()
        {
            Console.Clear();
            Console.WriteLine("Qual tipo de Conta deseja Criar?");
            Console.WriteLine("1 - Pessoa Fisica");
            Console.WriteLine("2 - Pessoa Juridica");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                ContaFisica();
            }
            else if (opcao == 2)
            {
                ContaJuridica();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("Pressione qualquer tecla para prosseguir...");
                Console.ReadKey();
                CriarConta();
            }
        }

        public void ContaFisica()
        {
            Console.Clear();
            PessoaFisica pessoaFisica = new PessoaFisica();
            Console.WriteLine("Data de Nascimento do cliente:");
            pessoaFisica.DataNascimento = DateTime.Parse(Console.ReadLine());
            if (!pessoaFisica.EhMaior())
            {
                Console.WriteLine("não é possivel abrir a conta pois o CLiente é menor de idade");
                return;
            }
            Console.WriteLine($"A idade do cliente é {pessoaFisica.Idade}");
            Console.WriteLine("Nome do cliente:");
            pessoaFisica.Nome = Console.ReadLine();
            Console.WriteLine("CPF do cliente:");
            pessoaFisica.CPF = Console.ReadLine();
            Console.WriteLine("Endereco do cliente:");
            pessoaFisica.Endereco = Console.ReadLine();
            Console.WriteLine("Telefone do cliente:");
            pessoaFisica.Telefone = Console.ReadLine();
            Console.WriteLine("Email do cliente:");
            pessoaFisica.Email = Console.ReadLine();
            Console.WriteLine("Numero Da Conta");
            pessoaFisica.NumeroConta = int.Parse(Console.ReadLine());
            clientes.Add(pessoaFisica);
        }

        public void ContaJuridica()
        {
            Console.Clear();
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            Console.WriteLine("Data de Criação da Empresa:");
            pessoaJuridica.DataCriacao = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"O tempo de atividade da empresa é de {pessoaJuridica.TempoAtividade}");
            Console.WriteLine("Razão Social:");
            pessoaJuridica.RazaoSocial = Console.ReadLine();
            Console.WriteLine("CNPJ do cliente:");
            pessoaJuridica.CNPJ = Console.ReadLine();
            Console.WriteLine("Endereco do cliente:");
            pessoaJuridica.Endereco = Console.ReadLine();
            Console.WriteLine("Telefone do cliente:");
            pessoaJuridica.Telefone = Console.ReadLine();
            Console.WriteLine("Email do cliente:");
            pessoaJuridica.Email = Console.ReadLine();
            Console.WriteLine("Numero Da Conta");
            pessoaJuridica.NumeroConta = int.Parse(Console.ReadLine());
            clientes.Add(pessoaJuridica);
        }
        public Cliente BuscarClientePorNumeroDeConta(int numeroConta)
        {
            ;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.NumeroConta == numeroConta)
                {
                    return cliente;
                }
            }
            return null;
        }

        public void ExibirClientes()
        {
            Console.WriteLine("Número da conta        | Tipo de conta         | Dados cadastrados   ");
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine(clientes[i].ResumoCliente());
            }
            Console.ReadKey();
        }
    }
}
