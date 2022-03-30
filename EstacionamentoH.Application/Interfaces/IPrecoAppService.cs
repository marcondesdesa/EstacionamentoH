using EstacionamentoH.Domain.Entities;
using System;

namespace EstacionamentoH.Application.Interfaces
{     
    public interface IPrecoAppService : IAppServiceBase<Preco>
    {
        Preco GetPrecoVigente(DateTime data);
    }
}
