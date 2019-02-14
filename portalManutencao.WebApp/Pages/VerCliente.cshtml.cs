using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portalManutencao.Infrastructure.InMemoryDataAccess.Repositories;
using portalManutencao.Domain.Clientes;

namespace portalManutencao.WebApp.Pages
{
    public class VerClienteModel : PageModel
    {
        public string WelcomeMessage { get; set; }
        public List<Cliente> clienteLista { get; set; }

        public void OnGet()
        {
            string acao = HttpContext.Request.Query["action"].ToString();
            if (acao == "Delete")
            {
                string id = HttpContext.Request.Query["Id"].ToString();
                if (string.IsNullOrEmpty(id)) { id = "0"; }
                Guid Id = new Guid(id);
                Delete(Id);
                clienteLista = Program.Base.Clientes.ToList();
            }
            else
            {
                clienteLista = Program.Base.Clientes.ToList();
                WelcomeMessage = "Lista Cliente";
            }
         }

        public ActionResult Delete(Guid Id)
        {
            var cont = new DesignTimeDbContextFactory();
            ClienteRepository _clienteRepository = new ClienteRepository(Program.Base);
            Task<Cliente> resultado = _clienteRepository.Get(Id);
            Cliente resultado1 = Cliente.Carregar(Id, resultado.Result.PessoaFisica, 
                                                    resultado.Result.Endereco, resultado.Result.Telefone, resultado.Result.Celular);
            _clienteRepository.Delete(resultado1);
            return RedirectToPage("VerCliente");
        }
    }
}