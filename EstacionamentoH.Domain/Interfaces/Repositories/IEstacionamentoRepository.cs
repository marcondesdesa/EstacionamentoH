using EstacionamentoH.Domain.Entities;

namespace EstacionamentoH.Domain.Interfaces.Repositories
{
    public interface IEstacionamentoRepository : IRepositoryBase<Estacionamento>
    {
        Estacionamento GetVeiculo(string placa);
    }
}
