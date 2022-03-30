using EstacionamentoH.Domain.Entities;
using System;

namespace EstacionamentoH.Domain.Interfaces.Services
{
    public interface IPrecoService : IServiceBase<Preco>
    {
        Preco GetPrecoVigente(DateTime data);
    }
}
