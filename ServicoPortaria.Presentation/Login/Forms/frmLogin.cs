using System;
using System.Collections.Generic;
using AutoMapper;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServicoPortaria.Presentation.ViewModels;
using ServicoPortaria.Domain.Enttities;
using ServicoPortaria.Infra.Data.Repositories;
using ServicoPortaria.Infra.Data.Contexto;

namespace ServicoPortaria.Presentation.Login.Forms
{
    public partial class frmLogin : Form
    {
        private readonly UsuarioRepository _usuario = new UsuarioRepository();

        PortariaContext _context = new PortariaContext();
        public IConfiguration Configuration { get; }
        public frmLogin(IConfiguration configuration)
        {
            Configuration = configuration;
            // var condominioRepository = Mapper.Map<IEnumerable<ServicoPortaria.Domain.Enttities.Condominio>>, IEnumerable< CondominioViewModel >> (_usuario.GetAll());

            InitializeComponent();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PortariaContext>();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
