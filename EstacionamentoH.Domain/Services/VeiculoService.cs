using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Domain.Interfaces.Repositories;
using EstacionamentoH.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace EstacionamentoH.Domain.Services
{
    public class VeiculoService : ServiceBase<Veiculo>, IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
            : base(veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }
        public IEnumerable<Veiculo> GetPorPlaca(string placa)
        {
            return _veiculoRepository.GetPorPlaca(placa);
        }
    }
}
