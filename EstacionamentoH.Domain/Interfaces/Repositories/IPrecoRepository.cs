using EstacionamentoH.Domain.Entities;
using System;

namespace EstacionamentoH.Domain.Interfaces.Repositories
{
    public interface IPrecoRepository : IRepositoryBase<Preco>
    {
        Preco GetPrecoVigente(DateTime data);
    }
}
