namespace portalManutencao.Infrastructure.InMemoryDataAccess.Entities
{
    using System;
    public class Endereco
    {
        public Guid Id { get; set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public int Cidade { get; private set; }
    }
}


