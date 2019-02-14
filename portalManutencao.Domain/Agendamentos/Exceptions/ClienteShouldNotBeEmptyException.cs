namespace portalManutencao.Domain.Agendamentos.Exceptions
{
    internal sealed class ClienteShouldNotBeEmptyException : DomainException
    {
        internal ClienteShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
