using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EstacionamentoH.Infra.Data.Repositories
{
    public class VeiculoRepository : RepositoryBase<Veiculo>, IVeiculoRepository
    {
        public IEnumerable<Veiculo> GetPorPlaca(string placa)
        {
            return Db.Veiculos.Where(p => p.Placa == placa);
        }
    }
}
