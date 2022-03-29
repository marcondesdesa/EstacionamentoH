using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;

namespace EstacionamentoH.Domain.Interfaces.Repositories
{
    public interface ICondutorRepository : IRepositoryBase<Condutor>
    {
        IEnumerable<Condutor> GetPorNome(string nome);
    }
}
