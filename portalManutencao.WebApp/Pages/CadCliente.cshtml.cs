using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portalManutencao.Infrastructure.InMemoryDataAccess.Repositories;
using portalManutencao.Domain.ValueObjects.Localizacao;
using portalManutencao.Domain.ValueObjects.PessoasFisicas;
using portalManutencao.Domain.Clientes;

namespace portalManutencao.WebApp.Pages
{
    public class CadClienteModel : PageModel
    {
        public string WelcomeMessage { get; set; }
        public string erroNome { get; set; }

        [BindProperty]
        public portalManutencao.Infrastructure.InMemoryDataAccess.Entities.Cliente Cliente { get; set; }

        public void OnGet()
        {
            WelcomeMessage = "Novo Cliente";
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            { 
                var nome = Cliente.Nome;
                var sobrenome = Cliente.Sobrenome;
                var cpf = Cliente.CPF;
                var pessoaFisica = new PessoaFisica(nome, cpf, sobrenome);
                var estado = new Estado(Cliente.Cidade, Cliente.UF);
                var cidade = new Cidade(Cliente.Cidade, estado);
                var endereco = new Endereco(Cliente.Logradouro, Cliente.Numero, Cliente.Complemento,
                                        Cliente.Bairro, Cliente.CEP, cidade);
                var cliente1 = new Cliente(pessoaFisica, endereco, Cliente.Telefone, Cliente.Celular);
                ClienteRepository _clienteRepository = new ClienteRepository(Program.Base);
               _clienteRepository.Add(cliente1);
               return RedirectToPage("VerCliente");
            }
            catch (Exception ex)
            {
                @erroNome = ex.Message;
                return Page();
            }
        }
    }
}