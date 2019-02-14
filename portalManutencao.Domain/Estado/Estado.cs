namespace portalManutencao.Domain.Estados
{
    using System;
    //using portalManutencao.Domain.ValueObjects.Geral;
    public sealed class Estado : IEntity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string UF { get; private set; }
      
        public Estado(string nome,  string uf)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            UF = uf;
        }

        private Estado() { }

        public static Estado Carregar(Guid id, string nome, string uf) 
        {
            Estado estado = new Estado();
            estado.Id = id;
            estado.Nome = nome;
            estado.UF = uf;
            return estado;
        }
    }
}
