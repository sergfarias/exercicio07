namespace portalManutencao.Domain.ValueObjects.Localizacao.Exceptions
{
    internal sealed class CidadeShouldNotBeNullException : DomainException
    {
        internal CidadeShouldNotBeNullException(string message)
            : base(message)
        { }
    }
}
