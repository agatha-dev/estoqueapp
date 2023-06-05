using AutoMapper;
using EstoqueApp.Application.Models.Commands;
using EstoqueApp.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueApp.Application.Profiles
{
    public class CommandToModelProfile : Profile
    {
        public CommandToModelProfile() 
        {
            CreateMap<EstoqueCreateCommand, Estoque>()
               .AfterMap((comamnd, model ) => {
                   model.Id = Guid.NewGuid();
               });

            CreateMap<ProdutoCreateCommand, Produto>()
                .AfterMap((comamnd, model) =>
                {
                    model.Id = Guid.NewGuid();
                });

        }
    }
}
