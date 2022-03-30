using EstacionamentoH.Domain.Entities;

namespace EstacionamentoH.Application.Interfaces
{
    public interface IEstacionamentoAppService : IAppServiceBase<Estacionamento>
    {
        Estacionamento GetVeiculo(string placa);
    }
}
