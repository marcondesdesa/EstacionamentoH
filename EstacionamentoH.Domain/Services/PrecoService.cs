﻿using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Domain.Interfaces.Repositories;
using EstacionamentoH.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace EstacionamentoH.Domain.Services
{
    public class PrecoService : ServiceBase<Preco>, IPrecoService
    {
        private readonly IPrecoRepository _precoRepository;

        public PrecoService(IPrecoRepository precoRepository)
            : base(precoRepository)
        {
            _precoRepository = precoRepository;
        }
        public Preco GetPrecoVigente(DateTime data)
        {
            return _precoRepository.GetPrecoVigente(data);
        }
    }
}
