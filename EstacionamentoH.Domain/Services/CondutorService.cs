using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Domain.Interfaces.Repositories;
using EstacionamentoH.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace EstacionamentoH.Domain.Services
{
    public class CondutorService : ServiceBase<Condutor>, ICondutorService
    {
        private readonly ICondutorRepository _condutorRepository;

        public CondutorService(ICondutorRepository condutorRepository)
            : base(condutorRepository)
        {
            _condutorRepository = condutorRepository;
        }

        public IEnumerable<Condutor> GetPorNome(string nome)
        {
            return _condutorRepository.GetPorNome(nome);
        }
    }
}
