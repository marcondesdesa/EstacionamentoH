using EstacionamentoH.Application;
using EstacionamentoH.Application.Interfaces;
using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;

namespace EstacionamentoH.Domain.Interfaces.Services
{
    public class VeiculoAppService : AppServiceBase<Veiculo>, IVeiculoAppService
    {
        private readonly IVeiculoService _veiculoService;

        public VeiculoAppService(IVeiculoService veiculoService)
            : base(veiculoService)
        {
            _veiculoService = veiculoService;
        }
    }
}
