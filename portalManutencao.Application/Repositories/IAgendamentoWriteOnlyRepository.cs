namespace portalManutencao.Application.Repositories
{
    using portalManutencao.Domain.Agendamentos;
    using System.Threading.Tasks;

    public interface IAgendamentoWriteOnlyRepository
    {
        Task Add(Agendamento agendamento);//, Credit credit
        Task Update(Agendamento agendamento);//, Credit credit
        Task Delete(Agendamento agendamento);
    }
}
