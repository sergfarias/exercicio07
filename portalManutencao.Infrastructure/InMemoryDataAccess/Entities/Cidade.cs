namespace portalManutencao.Infrastructure.InMemoryDataAccessDataAccess.Entities
{
    using System;
    public class Cidade
    {
        public Guid Id { get; set; }
        public string Nome { get; private set; }
        public int Estado { get; private set; }
    }
}


