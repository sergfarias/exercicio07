namespace portalManutencao.Application.Repositories
{
    using portalManutencao.Domain.Clientes;
    using System;
    using System.Threading.Tasks;

    public interface IClienteReadOnlyRepository
    {
        Task<Cliente> Get(Guid id);        
    }
}
