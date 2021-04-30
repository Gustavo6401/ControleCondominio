using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ServicoPortaria.Presentation.Condominio.Forms;
using ServicoPortaria.Infra.Data.Contexto;
using ServicoPortaria.Infra.Data.Repositories;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Presentation.Condominio
{
    public partial class ucListarTodos : UserControl
    {
        public ucListarTodos()
        {
            InitializeComponent();
        }

        private void ucListarTodos_Load(object sender, EventArgs e)
        {
            PortariaContext context = new PortariaContext();
            CondominioRepository repository = new CondominioRepository();

            dgvData.DataSource = repository.ConsultarTodos();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmInserir_Click(object sender, EventArgs e)
        {
            frmInserir form = new frmInserir();
            form.Show();
        }

        private void tsmConsultar_Click(object sender, EventArgs e)
        {
            frmConsultar form = new frmConsultar();
            form.Show();

            frmConsultarTodos tela = new frmConsultarTodos();
            tela.Close();
        }

        private void tsmRemove_Click(object sender, EventArgs e)
        {
            frmDeletar form = new frmDeletar();
            form.Show();

            frmConsultarTodos tela = new frmConsultarTodos();
            tela.Close();
        }

        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            frmModificar form = new frmModificar();
            form.Show();

            frmConsultarTodos tela = new frmConsultarTodos();
            tela.Close();
        }

        private void tsmConsultarComId_Click(object sender, EventArgs e)
        {
            frmConsultarPorId form = new frmConsultarPorId();
            form.Show();

            frmConsultarTodos tela = new frmConsultarTodos();
            tela.Close();
        }
    }
}
