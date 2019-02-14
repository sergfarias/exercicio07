namespace portalManutencao.Domain.ValueObjects.Localizacao.Exceptions
{
    internal sealed class CEPShouldNotBeEmptyException : DomainException
    {
        internal CEPShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
