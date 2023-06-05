using EstoqueApp.Domain.Domain;
using EstoqueApp.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Domain.Interfaces.Reposotories
{
    public interface IEstoqueRepository : IBaseDomainService<Estoque, Guid>
    {
    }
}