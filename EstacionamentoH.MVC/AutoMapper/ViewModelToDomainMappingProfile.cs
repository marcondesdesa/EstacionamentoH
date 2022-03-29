using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EstacionamentoH.Domain.Entities;
using EstacionamentoH.MVC.ViewModels;

namespace EstacionamentoH.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CondutorViewModel, Condutor>();
            CreateMap<EstacionamentoViewModel, Estacionamento>();
            CreateMap<EstacionamentoViewModel, Estacionamento>();
            CreateMap<ParametroViewModel, Parametro>();
            CreateMap<PrecoViewModel, Preco>();
            CreateMap<VeiculoViewModel, Veiculo>();
        }
    }
}
