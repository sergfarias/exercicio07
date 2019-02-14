namespace portalManutencao.Domain.ValueObjects.Exceptions
{
    internal sealed class DescricaoShouldNotBeEmptyException : DomainException
    {
        internal DescricaoShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
