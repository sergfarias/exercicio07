namespace portalManutencao.Domain.Agendamentos.Exceptions
{
    internal sealed class NomeShouldNotBeEmptyException : DomainException
    {
        internal NomeShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
