using portalManutencao.Domain.ValueObjects.Localizacao.Exceptions;
using portalManutencao.Domain.ValueObjects.Exceptions;

namespace portalManutencao.Domain.ValueObjects.Localizacao
{
    public sealed class Cidade
    {
        public string Nome { get; private set; }
        public Estado Estado { get; private set; }

        public Cidade (string nome, Estado estado)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new NomeShouldNotBeEmptyException("O campo 'Nome' da Cidade é requerido");

            if (string.IsNullOrWhiteSpace(nome))
                throw new EstadoShouldNotBeNullException("O campo 'Estado' da Cidade é requerido");

            Nome = nome;
            Estado = estado;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return ((Cidade)obj).Nome == Nome &&
                    ((Cidade)obj).Estado == Estado;
        }
    }
}