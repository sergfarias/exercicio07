namespace portalManutencao.Infrastructure.InMemoryDataAccess.Repositories
{
    using portalManutencao.Application.Repositories;
    using portalManutencao.Domain.Agendamentos;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class AgendamentoRepository : IAgendamentoReadOnlyRepository, IAgendamentoWriteOnlyRepository
    {
        private readonly Context _context;

        public AgendamentoRepository(Context context)
        {
            _context = context;
        }

        public async Task Add(Agendamento agendamento)
        {
            _context.Agendamentos.Add(agendamento);
            await Task.CompletedTask;
        }

        public async Task Delete(Agendamento agendamento)
        {
            Agendamento agendamentoOld = _context.Agendamentos
                .Where(e => e.Id == agendamento.Id)
                .SingleOrDefault();

            _context.Agendamentos.Remove(agendamentoOld);

            await Task.CompletedTask;
        }



        public async Task<Agendamento> Get(Guid id)
        {
            Agendamento agendamento = _context.Agendamentos
                .Where(e => e.Id == id)
                .SingleOrDefault();

            return await Task.FromResult<Agendamento>(agendamento);
        }

        public async Task Update(Agendamento agendamento)
        {
            Agendamento agendamentoOld = _context.Agendamentos
                .Where(e => e.Id == agendamento.Id)
                .SingleOrDefault();

            agendamentoOld = agendamento;
            await Task.CompletedTask;
        }
    }
}
