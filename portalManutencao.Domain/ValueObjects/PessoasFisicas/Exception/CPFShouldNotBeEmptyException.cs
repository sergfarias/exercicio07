namespace portalManutencao.Domain.ValueObjects.PessoasFisicas.Exceptions
{
    internal sealed class CPFShouldNotBeEmptyException : DomainException
    {
        internal CPFShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
