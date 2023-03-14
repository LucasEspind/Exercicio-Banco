
namespace M1S3_SistemaBanco
{
    public class Cliente 
    {
        ClienteServices _clienteServices = new ClienteServices();
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo {  get {return GetSaldo(); }  private set{} }

        
        
        public List<Transacao> Extrato { get; set; }

        public Cliente()
        {
            Extrato = new List<Transacao>();
        }
        private double GetSaldo(){
            double saldo = 0;
            foreach(Transacao transacao  in Extrato){
                saldo += transacao.Valor;
            }
            return saldo;
        }

        public void AdicionarTransacao()
        {
            Console.Clear();
            Console.WriteLine("Qual a conta?");
            int numeroConta = int.Parse(Console.ReadLine());

            Cliente contaCliente = _clienteServices.BuscarClientePorNumeroDeConta(numeroConta);

            if (contaCliente == null)
            {
                Console.Clear();
                Console.WriteLine("Conta não cadastrada, favor cadastrar antes");
                Console.WriteLine("\nPressione qualquer tecla para prosseguir...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Qual o valor da transação?");
            double valor = double.Parse(Console.ReadLine());
            Transacao transacao = new Transacao(DateTime.Now, valor);

            contaCliente.Extrato.Add(transacao);
            Console.Clear();
        }

        public void ExibirExtrato()
        {
            Console.Clear();
            Console.WriteLine("Qual a conta?");
            int numeroConta = int.Parse(Console.ReadLine());

            Cliente contaCliente = _clienteServices.BuscarClientePorNumeroDeConta(numeroConta);

            if (contaCliente == null)
            {
                Console.Clear();
                Console.WriteLine("Conta não cadastrada, favor cadastrar antes");
                Console.WriteLine("\nPressione qualquer tecla para prosseguir...");
                Console.ReadKey();
                return;
            }
            foreach (Transacao transacao in contaCliente.Extrato)
            {
                Console.Clear();
                Console.WriteLine($"Data: {transacao.Data} Valor: R$  {transacao.Valor}");
            }

            Console.WriteLine("Saldo = " + contaCliente.Saldo);
            Console.WriteLine("\nPressione qualquer tecla para prosseguir...");
            Console.ReadKey();
        }

        public virtual string ResumoCliente()
        {
            return $"{NumeroConta}";
        }
    }
}