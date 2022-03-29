using EstacionamentoH.Application;
using EstacionamentoH.Application.Interfaces;
using EstacionamentoH.Domain.Entities;
using System.Collections.Generic;

namespace EstacionamentoH.Domain.Interfaces.Services
{
    public class CondutorAppService : AppServiceBase<Condutor>, ICondutorAppService
    {
        private readonly ICondutorService _condutorService;

        public CondutorAppService(ICondutorService condutorService)
            : base(condutorService)
        {
            _condutorService = condutorService;
        }

        public IEnumerable<Condutor> GetPorNome(string nome)
        {
            return _condutorService.GetPorNome(nome);
        }
    }
}
