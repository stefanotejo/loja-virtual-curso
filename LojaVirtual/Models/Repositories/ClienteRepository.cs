using LojaVirtual.Data;
using LojaVirtual.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        // DEPENDÊNCIAS
        private readonly LojaVirtualContext _context;

        // CONSTRUTOR
        public ClienteRepository(LojaVirtualContext context)
        {
            _context = context;
        }

        // MÉTODOS IClienteRepository
        public Cliente Login(string email, string senha)
        {
            return _context.Clientes.Where(obj => obj.Email == email && obj.Senha == senha).FirstOrDefault();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _context.Update(cliente);
            _context.SaveChanges();
        }

        
        public void ExcluirCliente(int id)
        {
            Cliente cliente = BuscarCliente(id);
            _context.Remove(cliente);
            _context.SaveChanges();
        }

        public Cliente BuscarCliente(int id)
        {
            return _context.Clientes.Find(id);
        }

        public IEnumerable<Cliente> BuscarTodosClientes()
        {
            return _context.Clientes.ToList();
        }
    }
}
