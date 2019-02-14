namespace portalManutencao.Domain.ValueObjects.Localizacao.Exceptions
{
    internal sealed class LongitudeShouldNotBeZeroException : DomainException
    {
        internal LongitudeShouldNotBeZeroException(string message)
            : base(message)
        { }
    }
}
