using portalManutencao.Domain.ValueObjects.Localizacao;
using portalManutencao.Domain.ValueObjects.PessoasFisicas;
using System;

namespace portalManutencao.Domain.Clientes
{
    public class Cliente : IEntity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public PessoaFisica PessoaFisica { get; private set; }
        public Endereco Endereco { get; private set; }
        public Cidade Cidade { get; private set; }
        public string Telefone { get; private set; }
        public string Celular  { get; private set; }

        private Cliente(){}

        public Cliente(PessoaFisica pessoaFisica, Endereco endereco, string telefone, string celular )
        {
            Id = Guid.NewGuid();
            PessoaFisica = pessoaFisica;
            Endereco = endereco;
           Telefone = telefone;
            Celular = celular;
        }
        
        public static Cliente Carregar(
            Guid idCliente,
            PessoaFisica pessoaFisica,
            Endereco endereco,
            string telefone, 
            string celular
        )
        {
            var cliente = new Cliente();
            cliente.Id = idCliente;
            cliente.PessoaFisica = pessoaFisica;
            cliente.Endereco = endereco;
            cliente.Telefone = telefone;
            cliente.Celular = celular;
            return cliente;
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

            return ((Cliente)obj).Id == Id;
        }

    }
}
