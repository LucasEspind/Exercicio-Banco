using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco
{
    public interface IClienteServices
    {
        void CriarConta();
        Cliente BuscarClientePorNumeroDeConta(int numeroConta);
        void ExibirClientes();
    }
}
