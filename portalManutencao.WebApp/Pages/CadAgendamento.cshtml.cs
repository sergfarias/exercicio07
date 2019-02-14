using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using portalManutencao.Infrastructure.InMemoryDataAccess.Repositories;
using portalManutencao.Domain.Agendamentos;
using portalManutencao.Infrastructure.InMemoryDataAccess.Entities;
using portalManutencao.Infrastructure.InMemoryDataAccess;

namespace portalManutencao.WebApp.Pages
{
    public class CadAgendamentoModel : PageModel
    {
        public string WelcomeMessage { get; set; }
        public string erroNome { get; set; }
        public List<portalManutencao.Domain.Clientes.Cliente> clienteLista { get; set; }
       
        [BindProperty]
        public portalManutencao.Infrastructure.InMemoryDataAccess.Entities.Agendamento Agendamento { get; set; }

        public void OnGet()
        {
            Context context = Program.Base;
            clienteLista = context.Clientes.ToList();
            WelcomeMessage = "Novo Agendamento";
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                @erroNome = "Selecione os dados de agendamento!";
                Context context = Program.Base;
                clienteLista = context.Clientes.ToList();
                return Page();
            }
            try
            { 
               string dtInicio = Request.Form["dtInicio"].ToString();
               string dtFinal = Request.Form["dtFinal"].ToString();
               Agendamento.DtInicio = Convert.ToDateTime(dtInicio);
               Agendamento.DtFinal = Convert.ToDateTime(dtFinal);
               Guid clienteId = new Guid(Request.Form["cliente"].ToString());
               var agendamento1 = new portalManutencao.Domain.Agendamentos.Agendamento( clienteId,  Agendamento.DtInicio, Agendamento.DtFinal);
               AgendamentoRepository _agendamentoRepository = new AgendamentoRepository(Program.Base);
               _agendamentoRepository.Add(agendamento1);
               return RedirectToPage("VerAgendamento");
            }
            catch (Exception ex)
            {
                @erroNome = ex.Message;
                Context context = Program.Base;
                clienteLista = context.Clientes.ToList();
                return Page();
            }
        }
    }
}