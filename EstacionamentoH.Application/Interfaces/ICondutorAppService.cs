using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;


namespace EstacionamentoH.Application.Interfaces
{
    public interface ICondutorAppService : IAppServiceBase<Condutor>
    {
        IEnumerable<Condutor> GetPorNome(string nome);
    }
}
