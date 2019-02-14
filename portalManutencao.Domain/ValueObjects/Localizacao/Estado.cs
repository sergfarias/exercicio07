using portalManutencao.Domain.ValueObjects.Localizacao.Exceptions;
using portalManutencao.Domain.ValueObjects.Exceptions;

namespace portalManutencao.Domain.ValueObjects.Localizacao
{
    public sealed class Estado
    {
        public string Nome { get; private set; }
        public string UF { get; private set; }
       
        public Estado (string nome, string uf)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new NomeShouldNotBeEmptyException("O campo 'Nome' do Estado é requerido");

            if (string.IsNullOrWhiteSpace(nome))
                throw new UfShouldNotBeEmptyException("O campo 'Uf' do Estado é requerido");

            Nome = nome;
            UF = uf.ToUpper();
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

            return ((Estado)obj).Nome == Nome &&
                ((Estado)obj).UF == UF;
        }
    }
}