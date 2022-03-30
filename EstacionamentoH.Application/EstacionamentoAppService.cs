using EstacionamentoH.Application;
using EstacionamentoH.Application.Interfaces;
using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;

namespace EstacionamentoH.Domain.Interfaces.Services
{       
    public class EstacionamentoAppService : AppServiceBase<Estacionamento>, IEstacionamentoAppService
    {
        private readonly IEstacionamentoService _estacionamentoService;

        public EstacionamentoAppService(IEstacionamentoService estacionamentoService)
            : base(estacionamentoService)
        {
            _estacionamentoService = estacionamentoService;
        }
        public Estacionamento GetVeiculo(string placa)
        {
            return _estacionamentoService.GetVeiculo(placa);
        }
    }
}
