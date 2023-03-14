using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    public static class Menu
    {

        public static int mostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindos ao Banco FULL STACK BANCK, escolha uma opção");
            Console.WriteLine("1 - Criar Conta ");
            Console.WriteLine("2 - Adicionar Transacao");
            Console.WriteLine("3 - Consultar Extrato");
            Console.WriteLine("4 - Exibir Clientes");
            Console.WriteLine("5 - Sair");
            Console.Write("Opção: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
