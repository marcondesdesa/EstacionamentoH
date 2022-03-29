using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Domain.Interfaces.Repositories;
using EstacionamentoH.Domain.Interfaces.Services;

namespace EstacionamentoH.Domain.Services
{
    public class EstacionamentoService : ServiceBase<Estacionamento>, IEstacionamentoService
    {
        private readonly IEstacionamentoRepository _estacionamentoRepository;

        public EstacionamentoService(IEstacionamentoRepository estacionamentoRepository)
            : base(estacionamentoRepository)
        {
            _estacionamentoRepository = estacionamentoRepository;
        }
    }
}
