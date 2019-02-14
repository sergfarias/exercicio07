namespace portalManutencao.Infrastructure.InMemoryDataAccess.Repositories
{
    using portalManutencao.Application.Repositories;
    using portalManutencao.Domain.Clientes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class ClienteRepository: IClienteReadOnlyRepository, IClienteWriteOnlyRepository
    {
        private readonly Context _context;

        public ClienteRepository(Context context)
        {
            _context = context;
        }

        public async Task Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await Task.CompletedTask;
        }


        public async Task Delete(Cliente cliente)
        {
            Cliente clienteOld = _context.Clientes
                .Where(e => e.Id == cliente.Id)
                .SingleOrDefault();

            _context.Clientes.Remove(clienteOld);

            await Task.CompletedTask;
        }


        public async Task<Cliente> Get(Guid id)
        {
            Cliente cliente = _context.Clientes
                .Where(e => e.Id == id)
                .SingleOrDefault();

            return await Task.FromResult<Cliente>(cliente);
        }

        public async Task Update(Cliente cliente)
        {
            Cliente clienteOld = _context.Clientes
                .Where(e => e.Id == cliente.Id)
                .SingleOrDefault();

            clienteOld = cliente;
            await Task.CompletedTask;
        }
    }
}
