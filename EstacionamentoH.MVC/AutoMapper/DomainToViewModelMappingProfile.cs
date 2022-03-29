using AutoMapper;
using EstacionamentoH.Domain.Entities;
using EstacionamentoH.MVC.ViewModels;

namespace EstacionamentoH.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            
            get { return "ViewModelToDomainMappings"; }
        }
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Condutor, CondutorViewModel>();
            CreateMap<Estacionamento, EstacionamentoViewModel>();
            CreateMap<Parametro, ParametroViewModel>();
            CreateMap<Preco, PrecoViewModel>();
            CreateMap<Veiculo, VeiculoViewModel>();
        }
    }
}
