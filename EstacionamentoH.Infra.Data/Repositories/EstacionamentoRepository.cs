using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EstacionamentoH.Infra.Data.Repositories
{
    public class EstacionamentoRepository : RepositoryBase<Estacionamento>, IEstacionamentoRepository
    {
        public Estacionamento GetVeiculo(string placa)
        {
            return Db.Estacionamentos.Where(p => p.Veiculo.Placa == placa).FirstOrDefault();
        }      
    }
}
