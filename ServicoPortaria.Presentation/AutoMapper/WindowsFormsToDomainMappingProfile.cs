using AutoMapper;
using ServicoPortaria.Presentation.ViewModels;

namespace ServicoPortaria.Presentation.AutoMapper
{
    public class WindowsFormsToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        /* protected override void Configure()
        {
            Mapper.CreatingMap<CondominioViewModel, ServicoPortaria.Domain.Entities.Condominio>();
            Mapper.CreatingMap<PredioViewModel, ServicoPortaria.Domain.Entities.Predio>();
            Mapper.CreatingMap<MoradorViewModel, ServicoPortaria.Domain.Entities.Morador>();
            Mapper.CreatingMap<ApartamentoViewModel, ServicoPortaria.Domain.Entities.Apartamento>();
            Mapper.CreatingMap<VisitanteViewModel, ServicoPortaria.Domain.Entities.Visitante>();
            Mapper.CreatingMap<GaragemViewModel, ServicoPortaria.Domain.Entities.Garagem>();
            Mapper.CreatingMap<VeiculoViewModel, ServicoPortaria.Domain.Entities.Veiculo>();
            Mapper.CreatingMap<PrestadorServicosViewModel, ServicoPortaria.Domain.Entities.PrestadorSevicos>();
            Mapper.CreatingMap<SindicoViewModel, ServicoPortaria.Domain.Entities.Sindico>();
            Mapper.CreatingMap<UsuarioViewModel, ServicoPortaria.Domain.Entities.Usuario>();
            Mapper.CreatingMap<RecuperacaoSenhaViewModel, ServicoPortaria.Domain.Entities.RecuperacaoSenha>();
            Mapper.CreatingMap<VisitaViewModel, ServicoPortaria.Domain.Entities.Visita>();
        } */
    }
}
