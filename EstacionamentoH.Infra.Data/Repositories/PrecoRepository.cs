using EstacionamentoH.Domain.Entities;
using EstacionamentoH.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EstacionamentoH.Infra.Data.Repositories
{
    public class PrecoRepository : RepositoryBase<Preco>, IPrecoRepository
    {
        public Preco GetPrecoVigente(DateTime data)
        {
            return Db.Precos.FirstOrDefault(p => p.DataInicial <= data && p.DataFinal >= data);
        }
    }
}
