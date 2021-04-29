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
            Mapper.CreatingMap<CondominioViewModel, ServicoPortaria.Domain.Enttities.Condominio>();
            Mapper.CreatingMap<PredioViewModel, ServicoPortaria.Domain.Enttities.Predio>();
            Mapper.CreatingMap<MoradorViewModel, ServicoPortaria.Domain.Enttities.Morador>();
            Mapper.CreatingMap<ApartamentoViewModel, ServicoPortaria.Domain.Enttities.Apartamento>();
            Mapper.CreatingMap<VisitanteViewModel, ServicoPortaria.Domain.Enttities.Visitante>();
            Mapper.CreatingMap<GaragemViewModel, ServicoPortaria.Domain.Enttities.Garagem>();
            Mapper.CreatingMap<VeiculoViewModel, ServicoPortaria.Domain.Enttities.Veiculo>();
            Mapper.CreatingMap<PrestadorServicosViewModel, ServicoPortaria.Domain.Enttities.PrestadorSevicos>();
            Mapper.CreatingMap<SindicoViewModel, ServicoPortaria.Domain.Enttities.Sindico>();
            Mapper.CreatingMap<UsuarioViewModel, ServicoPortaria.Domain.Enttities.Usuario>();
            Mapper.CreatingMap<RecuperacaoSenhaViewModel, ServicoPortaria.Domain.Enttities.RecuperacaoSenha>();
            Mapper.CreatingMap<VisitaViewModel, ServicoPortaria.Domain.Entities.Visita>();
        } */
    }
}
