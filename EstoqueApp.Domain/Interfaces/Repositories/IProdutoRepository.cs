using EstoqueApp.Domain.Domain;
using EstoqueApp.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EstoqueApp.Domain.Interfaces.Reposotories
{
    public interface IProdutoRepository : IBaseRepository<Produto, Guid>
    {
    }
}