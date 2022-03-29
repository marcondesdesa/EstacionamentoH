using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;

namespace EstacionamentoH.Domain.Interfaces.Services
{
    public interface ICondutorService : IServiceBase<Condutor>
    {
        IEnumerable<Condutor> GetPorNome(string nome);
    }
}
