namespace portalManutencao.Domain.ValueObjects.PessoasFisicas.Exceptions
{
    internal sealed class NomeFantasiaShouldNotBeEmptyException : DomainException
    {
        internal NomeFantasiaShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
