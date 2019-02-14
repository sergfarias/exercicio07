namespace portalManutencao.Infrastructure.InMemoryDataAccess.Entities
{
    using System;
    public class Agendamento
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFinal { get; set; }
    }
}


