using EstacionamentoH.Application;
using EstacionamentoH.Application.Interfaces;
using EstacionamentoH.Domain.Entities;
using System;
using System.Collections.Generic;

namespace EstacionamentoH.Domain.Interfaces.Services
{
    public class PrecoAppService : AppServiceBase<Preco>, IPrecoAppService
    {
        private readonly IPrecoService _precoService;

        public PrecoAppService(IPrecoService precoService)
            : base(precoService)
        {
            _precoService = precoService;
        }
        public Preco GetPrecoVigente(DateTime data)
        {
            return _precoService.GetPrecoVigente(data);
        }
    }
}
