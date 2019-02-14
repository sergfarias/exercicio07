namespace portalManutencao.Domain.ValueObjects.Exceptions
{
    internal sealed class NomeShouldNotBeEmptyException : DomainException
    {
        internal NomeShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
