using portalManutencao.Domain.ValueObjects.Localizacao.Exceptions;

namespace portalManutencao.Domain.ValueObjects.Localizacao
{
    public sealed class Endereco
    {
        private const int NUMERO_CARACTERES_DO_CEP = 8;

        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public Cidade Cidade { get; private set; }
       
        public Endereco(string logradouro, string numero, string complemento, string bairro, string cep, Cidade cidade)
        {
            ValidaCampos(logradouro, cep, cidade);
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
        }

        private void ValidaCampos(string logradouro, string cep, Cidade cidade)
        {
            if (string.IsNullOrWhiteSpace(logradouro))
                throw new LogradouroShouldNotBeEmptyException("O campo 'Logradouro' do Endereço é requerido");

            if (cidade == null)
                throw new CidadeShouldNotBeNullException("O campo 'Cidade' do endereço é requirido");

            //if (string.IsNullOrWhiteSpace(cep))
            //    throw new CEPShouldNotBeEmptyException("O campo 'CEP' do endereço é requirido");

            if (cep.Length != NUMERO_CARACTERES_DO_CEP)
                throw new InvalidCEPException($"O campo 'CEP' do endereço precisa ter exatamento {NUMERO_CARACTERES_DO_CEP} dígitos");
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

            return ((Endereco)obj).Logradouro == Logradouro &&
                    ((Endereco)obj).Numero == Numero &&
                    ((Endereco)obj).Bairro == Bairro &&
                    ((Endereco)obj).Cidade == Cidade;
        }

    }
}
