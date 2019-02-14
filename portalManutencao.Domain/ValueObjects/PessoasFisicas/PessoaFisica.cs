using portalManutencao.Domain.ValueObjects.PessoasFisicas.Exceptions;

namespace portalManutencao.Domain.ValueObjects.PessoasFisicas
{
    public sealed class PessoaFisica
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Sobrenome { get; private set; }


        public PessoaFisica(string nome, string cpf, string sobrenome)
        {
            if (nome == null)
                throw new CPFShouldNotBeEmptyException("O campo 'Nome' da PessoaFisica é requirido");

            if (cpf == null)
                throw new CPFShouldNotBeEmptyException("O campo 'CPF' da PessoaFisica é requirido");


            Nome = nome;
            CPF = cpf;
            Sobrenome = sobrenome;

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

         
            return ((PessoaFisica)obj).Nome == Nome &&
                  ((PessoaFisica)obj).CPF == CPF && ((PessoaFisica)obj).Sobrenome == Sobrenome;
            
        }
    }
}
