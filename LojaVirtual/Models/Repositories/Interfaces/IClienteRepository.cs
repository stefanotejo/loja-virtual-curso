using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        Cliente Login(string email, string senha);

        // CRUD
        void CadastrarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void ExcluirCliente(int id);
        Cliente BuscarCliente(int id);
        IEnumerable<Cliente> BuscarTodosClientes();
    }
}
