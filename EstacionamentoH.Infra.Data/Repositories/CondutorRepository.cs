using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EstacionamentoH.Infra.Data.Repositories
{
    public class CondutorRepository : RepositoryBase<Condutor>, ICondutorRepository
    {
        public IEnumerable<Condutor> GetPorNome(string nome)
        {
            return Db.Condutores.Where(p => p.Nome == nome);
        }
    }
}
