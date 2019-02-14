namespace portalManutencao.Domain.ValueObjects.Localizacao.Exceptions
{
    internal sealed class EstadoShouldNotBeNullException : DomainException
    {
        internal EstadoShouldNotBeNullException(string message)
            : base(message)
        { }
    }
}
