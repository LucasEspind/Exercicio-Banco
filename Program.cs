
using System.Globalization;
using M1S3_SistemaBanco;

bool BancoFuncionando = true;
IClienteServices _clienteServices = new ClienteServices();
Cliente cliente = new Cliente();

while (BancoFuncionando){
    
    var opcao = Menu.mostrarMenu();   
    switch (opcao)
    {
        case 1:
            Console.Clear();
            _clienteServices.CriarConta();
            break;
        case 2:
            Console.Clear();
            cliente.AdicionarTransacao();
            break;
        case 3:
            Console.Clear();
            cliente.ExibirExtrato();
            break;
        case 4:
            Console.Clear();
            _clienteServices.ExibirClientes();
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Fechando Sistema...");
            Thread.Sleep(1000);
            BancoFuncionando = false;
            break;
        default: Console.WriteLine(); break;
    }
}














