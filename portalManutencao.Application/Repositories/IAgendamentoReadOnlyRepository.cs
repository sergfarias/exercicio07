namespace portalManutencao.Application.Repositories
{
    using portalManutencao.Domain.Agendamentos;
    using System;
    using System.Threading.Tasks;

    public interface IAgendamentoReadOnlyRepository
    {
        Task<Agendamento> Get(Guid id);        
    }
}
