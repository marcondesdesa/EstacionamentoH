using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;

namespace EstacionamentoH.Domain.Interfaces.Services
{
    public interface IVeiculoService : IServiceBase<Veiculo>
    {
        IEnumerable<Veiculo> GetPorPlaca(string placa);
    }
}
