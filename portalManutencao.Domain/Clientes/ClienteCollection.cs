namespace portalManutencao.Domain.Prestadores
{
    using System.Collections.Generic;
    using System;
    using System.Collections.ObjectModel;

    public sealed class PrestadorCollection
    {
        private readonly IList<Guid> _prestadorIds;

        public PrestadorCollection()
        {
            _prestadorIds = new List<Guid>();
        }

        public IReadOnlyCollection<Guid> GetPrestadorIds()
        {
            IReadOnlyCollection<Guid> prestadorIds = new ReadOnlyCollection<Guid>(_prestadorIds);
            return prestadorIds;
        }

        public void Add(Guid prestadorId)
        {
            _prestadorIds.Add(prestadorId);
        }
    }
}
