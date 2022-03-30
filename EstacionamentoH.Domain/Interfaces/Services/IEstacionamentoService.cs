using EstacionamentoH.Domain.Entities;

namespace EstacionamentoH.Domain.Interfaces.Services
{       
    public interface IEstacionamentoService : IServiceBase<Estacionamento>
    {
        Estacionamento GetVeiculo(string placa);
    }
}
