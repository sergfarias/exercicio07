namespace portalManutencao.Domain.ValueObjects.Localizacao.Exceptions
{
    internal sealed class LogradouroShouldNotBeEmptyException : DomainException
    {
        internal LogradouroShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
