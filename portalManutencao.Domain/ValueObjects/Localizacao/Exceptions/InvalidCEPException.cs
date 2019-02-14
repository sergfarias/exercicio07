namespace portalManutencao.Domain.ValueObjects.Localizacao.Exceptions
{
    internal sealed class InvalidCEPException : DomainException
    {
        internal InvalidCEPException(string message)
            : base(message)
        { }
    }
}
