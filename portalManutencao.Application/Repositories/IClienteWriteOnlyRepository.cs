namespace portalManutencao.Application.Repositories
{
    using portalManutencao.Domain.Clientes;
    using System.Threading.Tasks;

    public interface IClienteWriteOnlyRepository
    {
        Task Add(Cliente cliente);
        Task Update(Cliente cliente);
        Task Delete(Cliente cliente);
    }
}
