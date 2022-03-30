using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;

namespace EstacionamentoH.Application.Interfaces
{
    public interface IVeiculoAppService : IAppServiceBase<Veiculo>
    {
        IEnumerable<Veiculo> GetPorPlaca(string placa);
    }

}
