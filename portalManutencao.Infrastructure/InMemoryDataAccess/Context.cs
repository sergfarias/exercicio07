namespace portalManutencao.Infrastructure.InMemoryDataAccess
{
    using portalManutencao.Domain.Clientes;
    using portalManutencao.Domain.Agendamentos;
    using System.Collections.ObjectModel;

    public class Context
    {
       public Collection<Cliente> Clientes { get; set; }

        public Collection<Agendamento> Agendamentos { get; set; }

        public Context()
        {
            Clientes = new Collection<Cliente>();
            Agendamentos = new Collection<Agendamento>();
        }
    }
}
