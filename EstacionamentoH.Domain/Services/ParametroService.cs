using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Domain.Interfaces.Repositories;
using EstacionamentoH.Domain.Interfaces.Services;

namespace EstacionamentoH.Domain.Services
{
    public class ParametroService : ServiceBase<Parametro>, IParametroService
    {
        private readonly IParametroRepository _parametroRepository;

        public ParametroService(IParametroRepository parametroRepository)
            : base(parametroRepository)
        {
            _parametroRepository = parametroRepository;
        }
    }
}
