namespace portalManutencao.Domain.Agendamentos.Exceptions
{
    internal sealed class IntervaloTempoException : DomainException
    {
        internal IntervaloTempoException(string message)
            : base(message)
        { }
    }
}
