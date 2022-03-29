using EstacionamentoH.Application;
using EstacionamentoH.Application.Interfaces;
using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;

namespace EstacionamentoH.Domain.Interfaces.Services
{
    public class ParametroAppService : AppServiceBase<Parametro>, IParametroAppService
    {
        private readonly IParametroService _parametroService;

        public ParametroAppService(IParametroService parametroService)
            : base(parametroService)
        {
            _parametroService = parametroService;
        }
    }
}
