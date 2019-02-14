namespace portalManutencao.Domain.ValueObjects.Localizacao.Exceptions
{
    internal sealed class UfShouldNotBeEmptyException : DomainException
    {
        internal UfShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
