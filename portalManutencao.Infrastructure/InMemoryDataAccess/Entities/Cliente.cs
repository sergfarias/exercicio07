namespace portalManutencao.Infrastructure.InMemoryDataAccess.Entities
{
    using System;
   
    public class Cliente
    {

        public Guid Id { get; set; }

        public string Nome { get;  set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }

        //Cidade
        public string Cidade { get; set; }
        public string UF { get; set; }

        //Endereco
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
    }
}


