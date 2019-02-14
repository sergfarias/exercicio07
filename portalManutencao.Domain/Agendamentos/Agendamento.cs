using portalManutencao.Domain.Agendamentos.Exceptions;

namespace portalManutencao.Domain.Agendamentos
{
    using System;
    public sealed class Agendamento : IEntity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public Guid ClienteId { get; private set; }
        public DateTime DtInicio { get; private set; }
        public DateTime DtFinal { get; private set; }
        
        public Agendamento(Guid clienteId,  DateTime dtInicio, DateTime dtFinal)
        {

            if (clienteId == null)
                throw new ClienteShouldNotBeEmptyException("O campo 'Cliente'  é requirido");


            TimeSpan ts = dtInicio - dtFinal;

            double TotalMinutos=0;

            TotalMinutos = ts.TotalMinutes;

            if (TotalMinutos < 0) { TotalMinutos = TotalMinutos * -1; }

            if (TotalMinutos < 30)
                throw new IntervaloTempoException("O cliente pode agendar duas massagens com duração de trinta minutos cada uma ou uma massagem com uma hora de duração");

            if (TotalMinutos > 60)
                throw new IntervaloTempoException("O cliente pode agendar duas massagens com duração de trinta minutos cada uma ou uma massagem com uma hora de duração");

            if ((TotalMinutos > 30)&&(TotalMinutos < 60))
                throw new IntervaloTempoException("O cliente pode agendar duas massagens com duração de trinta minutos cada uma ou uma massagem com uma hora de duração");

            if (dtInicio.Hour<8)
                throw new IntervaloTempoException("Os agendamentos podem ser realizados entre as oito horas e as dezessete horas");

            if (dtInicio.Hour>17)
                throw new IntervaloTempoException("Os agendamentos podem ser realizados entre as oito horas e as dezessete horas");

            if (dtFinal.Hour < 8)
                throw new IntervaloTempoException("Os agendamentos podem ser realizados entre as oito horas e as dezessete horas");

            if (dtFinal.Hour > 17)
                throw new IntervaloTempoException("Os agendamentos podem ser realizados entre as oito horas e as dezessete horas");


            

            Id = Guid.NewGuid();
            ClienteId = clienteId;
            DtInicio = dtInicio;
            DtFinal = dtFinal;
        }

        private Agendamento() { }

        public static Agendamento Carregar(Guid id, Guid clienteId,  DateTime dtInicio, DateTime dtFinal) 
        {
            Agendamento agendamento = new Agendamento();
            agendamento.Id = id;
            agendamento.ClienteId = clienteId;
            agendamento.DtInicio = dtInicio;
            agendamento.DtFinal = dtFinal;
            return agendamento;
        }
    }
}
