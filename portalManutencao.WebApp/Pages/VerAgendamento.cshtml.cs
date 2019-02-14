using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portalManutencao.Infrastructure.InMemoryDataAccess.Repositories;
using portalManutencao.Domain.Agendamentos;

namespace portalManutencao.WebApp.Pages
{
    public class VerAgendamentoModel : PageModel
    {
        public string WelcomeMessage { get; set; }
        public List<Agendamento> agendamentoLista { get; set; }
        public void OnGet()
        {
            string acao = HttpContext.Request.Query["action"].ToString();
            if (acao == "Delete")
            {
                string id = HttpContext.Request.Query["Id"].ToString();
                if (string.IsNullOrEmpty(id)) { id = "0"; }
                Guid Id = new Guid(id);
                Delete(Id);
                agendamentoLista = Program.Base.Agendamentos.ToList();
            }
            else
            {
                agendamentoLista = Program.Base.Agendamentos.ToList();
                WelcomeMessage = "Lista Agendamento";
            }
        }
      
        public ActionResult Delete(Guid Id)
        {
            var cont = new DesignTimeDbContextFactory();
            AgendamentoRepository _agendamentoRepository= new  AgendamentoRepository(Program.Base);
            Task<Agendamento> resultado =  _agendamentoRepository.Get(Id);
            Agendamento resultado1=  Agendamento.Carregar(Id, resultado.Result.ClienteId, resultado.Result.DtInicio, resultado.Result.DtFinal);
           _agendamentoRepository.Delete(resultado1);
            return RedirectToPage("VerAgendamento");
        }
    }
}