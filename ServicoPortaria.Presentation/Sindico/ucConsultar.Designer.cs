
namespace ServicoPortaria.Presentation.Sindico
{
    partial class ucConsultar
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucConsultar));
            this.mnsPresentation = new System.Windows.Forms.MenuStrip();
            this.tmsCondominio = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsPredio = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmApartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGaragem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVeículo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPrestadorServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSindico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVisita = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCondominio = new System.Windows.Forms.MenuStrip();
            this.tsmCadastroMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultarMorador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModuloVisitante = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPredio = new System.Windows.Forms.Label();
            this.lblCondominio = new System.Windows.Forms.Label();
            this.lblDocCivil = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblIdCondominio = new System.Windows.Forms.Label();
            this.lblIdPredio = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.txtDocCivil = new System.Windows.Forms.TextBox();
            this.txtCondominio = new System.Windows.Forms.TextBox();
            this.txtPredio = new System.Windows.Forms.TextBox();
            this.groupNome = new System.Windows.Forms.GroupBox();
            this.groupDocumentacao = new System.Windows.Forms.GroupBox();
            this.groupLocal = new System.Windows.Forms.GroupBox();
            this.groupCodigos = new System.Windows.Forms.GroupBox();
            this.groupConsultar = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblClose = new System.Windows.Forms.Label();
            this.mnsPresentation.SuspendLayout();
            this.mnsCondominio.SuspendLayout();
            this.groupNome.SuspendLayout();
            this.groupDocumentacao.SuspendLayout();
            this.groupLocal.SuspendLayout();
            this.groupCodigos.SuspendLayout();
            this.groupConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsPresentation
            // 
            this.mnsPresentation.BackColor = System.Drawing.Color.Black;
            this.mnsPresentation.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnsPresentation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsCondominio,
            this.tmsPredio,
            this.tmsMorador,
            this.tsmApartamento,
            this.tsmVisitante,
            this.tsmGaragem,
            this.tsmVeículo,
            this.tsmPrestadorServicos,
            this.tsmSindico,
            this.tsmInicio,
            this.tsmVisita,
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnsPresentation.Location = new System.Drawing.Point(0, 0);
            this.mnsPresentation.Name = "mnsPresentation";
            this.mnsPresentation.Size = new System.Drawing.Size(137, 800);
            this.mnsPresentation.TabIndex = 52;
            // 
            // tmsCondominio
            // 
            this.tmsCondominio.Enabled = false;
            this.tmsCondominio.ForeColor = System.Drawing.Color.White;
            this.tmsCondominio.Name = "tmsCondominio";
            this.tmsCondominio.Size = new System.Drawing.Size(124, 19);
            this.tmsCondominio.Text = "Condomínio";
            // 
            // tmsPredio
            // 
            this.tmsPredio.ForeColor = System.Drawing.Color.White;
            this.tmsPredio.Name = "tmsPredio";
            this.tmsPredio.Size = new System.Drawing.Size(124, 19);
            this.tmsPredio.Text = "Prédio";
            // 
            // tmsMorador
            // 
            this.tmsMorador.ForeColor = System.Drawing.Color.White;
            this.tmsMorador.Name = "tmsMorador";
            this.tmsMorador.Size = new System.Drawing.Size(124, 19);
            this.tmsMorador.Text = "Morador";
            // 
            // tsmApartamento
            // 
            this.tsmApartamento.ForeColor = System.Drawing.Color.White;
            this.tsmApartamento.Name = "tsmApartamento";
            this.tsmApartamento.Size = new System.Drawing.Size(124, 19);
            this.tsmApartamento.Text = "Apartamento";
            // 
            // tsmVisitante
            // 
            this.tsmVisitante.ForeColor = System.Drawing.Color.White;
            this.tsmVisitante.Name = "tsmVisitante";
            this.tsmVisitante.Size = new System.Drawing.Size(124, 19);
            this.tsmVisitante.Text = "Visitante";
            // 
            // tsmGaragem
            // 
            this.tsmGaragem.ForeColor = System.Drawing.Color.White;
            this.tsmGaragem.Name = "tsmGaragem";
            this.tsmGaragem.Size = new System.Drawing.Size(124, 19);
            this.tsmGaragem.Text = "Garagem";
            // 
            // tsmVeículo
            // 
            this.tsmVeículo.ForeColor = System.Drawing.Color.White;
            this.tsmVeículo.Name = "tsmVeículo";
            this.tsmVeículo.Size = new System.Drawing.Size(124, 19);
            this.tsmVeículo.Text = "Veículo";
            // 
            // tsmPrestadorServicos
            // 
            this.tsmPrestadorServicos.ForeColor = System.Drawing.Color.White;
            this.tsmPrestadorServicos.Name = "tsmPrestadorServicos";
            this.tsmPrestadorServicos.Size = new System.Drawing.Size(124, 19);
            this.tsmPrestadorServicos.Text = "Prestador de Serviços";
            // 
            // tsmSindico
            // 
            this.tsmSindico.ForeColor = System.Drawing.Color.White;
            this.tsmSindico.Name = "tsmSindico";
            this.tsmSindico.Size = new System.Drawing.Size(124, 19);
            this.tsmSindico.Text = "Síndico";
            // 
            // tsmInicio
            // 
            this.tsmInicio.ForeColor = System.Drawing.Color.White;
            this.tsmInicio.Name = "tsmInicio";
            this.tsmInicio.Size = new System.Drawing.Size(124, 19);
            this.tsmInicio.Text = "Home Page";
            // 
            // tsmVisita
            // 
            this.tsmVisita.ForeColor = System.Drawing.Color.White;
            this.tsmVisita.Name = "tsmVisita";
            this.tsmVisita.Size = new System.Drawing.Size(124, 19);
            this.tsmVisita.Text = "Visita";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(124, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(124, 19);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(124, 19);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(124, 19);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // mnsCondominio
            // 
            this.mnsCondominio.BackColor = System.Drawing.Color.Black;
            this.mnsCondominio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCadastroMorador,
            this.tsmConsultarMorador,
            this.tsmModuloVisitante});
            this.mnsCondominio.Location = new System.Drawing.Point(137, 0);
            this.mnsCondominio.Name = "mnsCondominio";
            this.mnsCondominio.Size = new System.Drawing.Size(1233, 24);
            this.mnsCondominio.TabIndex = 60;
            this.mnsCondominio.Text = "Condomínio";
            // 
            // tsmCadastroMorador
            // 
            this.tsmCadastroMorador.ForeColor = System.Drawing.Color.White;
            this.tsmCadastroMorador.Name = "tsmCadastroMorador";
            this.tsmCadastroMorador.Size = new System.Drawing.Size(131, 20);
            this.tsmCadastroMorador.Text = "Cadastro de Morador";
            // 
            // tsmConsultarMorador
            // 
            this.tsmConsultarMorador.ForeColor = System.Drawing.Color.White;
            this.tsmConsultarMorador.Name = "tsmConsultarMorador";
            this.tsmConsultarMorador.Size = new System.Drawing.Size(133, 20);
            this.tsmConsultarMorador.Text = "Bloco do Condomíno";
            // 
            // tsmModuloVisitante
            // 
            this.tsmModuloVisitante.ForeColor = System.Drawing.Color.White;
            this.tsmModuloVisitante.Name = "tsmModuloVisitante";
            this.tsmModuloVisitante.Size = new System.Drawing.Size(125, 20);
            this.tsmModuloVisitante.Text = "Módulo de Visitante";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 61;
            this.lblNome.Text = "Nome";
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.Location = new System.Drawing.Point(16, 66);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(41, 15);
            this.lblPredio.TabIndex = 62;
            this.lblPredio.Text = "Prédio";
            // 
            // lblCondominio
            // 
            this.lblCondominio.AutoSize = true;
            this.lblCondominio.Location = new System.Drawing.Point(16, 18);
            this.lblCondominio.Name = "lblCondominio";
            this.lblCondominio.Size = new System.Drawing.Size(74, 15);
            this.lblCondominio.TabIndex = 63;
            this.lblCondominio.Text = "Condomínio";
            // 
            // lblDocCivil
            // 
            this.lblDocCivil.AutoSize = true;
            this.lblDocCivil.Location = new System.Drawing.Point(23, 113);
            this.lblDocCivil.Name = "lblDocCivil";
            this.lblDocCivil.Size = new System.Drawing.Size(114, 15);
            this.lblDocCivil.TabIndex = 64;
            this.lblDocCivil.Text = "Documentação Civil";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(23, 69);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(22, 15);
            this.lblRG.TabIndex = 65;
            this.lblRG.Text = "RG";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(23, 21);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(28, 15);
            this.lblCPF.TabIndex = 66;
            this.lblCPF.Text = "CPF";
            this.lblCPF.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(16, 69);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(68, 15);
            this.lblSobrenome.TabIndex = 67;
            this.lblSobrenome.Text = "Sobrenome";
            this.lblSobrenome.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(163, 23);
            this.txtNome.TabIndex = 68;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(96, 65);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(163, 23);
            this.txtSobrenome.TabIndex = 69;
            // 
            // lblIdCondominio
            // 
            this.lblIdCondominio.AutoSize = true;
            this.lblIdCondominio.Location = new System.Drawing.Point(95, 24);
            this.lblIdCondominio.Name = "lblIdCondominio";
            this.lblIdCondominio.Size = new System.Drawing.Size(133, 15);
            this.lblIdCondominio.TabIndex = 71;
            this.lblIdCondominio.Text = "Código do Condomínio";
            // 
            // lblIdPredio
            // 
            this.lblIdPredio.AutoSize = true;
            this.lblIdPredio.Location = new System.Drawing.Point(95, 72);
            this.lblIdPredio.Name = "lblIdPredio";
            this.lblIdPredio.Size = new System.Drawing.Size(100, 15);
            this.lblIdPredio.TabIndex = 70;
            this.lblIdPredio.Text = "Código do Prédio";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Black;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(51, 28);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(208, 89);
            this.btnConsultar.TabIndex = 72;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(154, 18);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(173, 23);
            this.mtxCPF.TabIndex = 73;
            // 
            // mtxRG
            // 
            this.mtxRG.Location = new System.Drawing.Point(154, 66);
            this.mtxRG.Mask = "00.000.000-0";
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(173, 23);
            this.mtxRG.TabIndex = 74;
            // 
            // txtDocCivil
            // 
            this.txtDocCivil.Location = new System.Drawing.Point(154, 110);
            this.txtDocCivil.Name = "txtDocCivil";
            this.txtDocCivil.Size = new System.Drawing.Size(173, 23);
            this.txtDocCivil.TabIndex = 75;
            // 
            // txtCondominio
            // 
            this.txtCondominio.Location = new System.Drawing.Point(96, 15);
            this.txtCondominio.Name = "txtCondominio";
            this.txtCondominio.Size = new System.Drawing.Size(163, 23);
            this.txtCondominio.TabIndex = 76;
            // 
            // txtPredio
            // 
            this.txtPredio.Location = new System.Drawing.Point(96, 63);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(163, 23);
            this.txtPredio.TabIndex = 77;
            // 
            // groupNome
            // 
            this.groupNome.Controls.Add(this.txtSobrenome);
            this.groupNome.Controls.Add(this.txtNome);
            this.groupNome.Controls.Add(this.lblSobrenome);
            this.groupNome.Controls.Add(this.lblNome);
            this.groupNome.Location = new System.Drawing.Point(265, 84);
            this.groupNome.Name = "groupNome";
            this.groupNome.Size = new System.Drawing.Size(270, 145);
            this.groupNome.TabIndex = 78;
            this.groupNome.TabStop = false;
            this.groupNome.Text = "Nome";
            // 
            // groupDocumentacao
            // 
            this.groupDocumentacao.Controls.Add(this.txtDocCivil);
            this.groupDocumentacao.Controls.Add(this.mtxRG);
            this.groupDocumentacao.Controls.Add(this.mtxCPF);
            this.groupDocumentacao.Controls.Add(this.lblCPF);
            this.groupDocumentacao.Controls.Add(this.lblRG);
            this.groupDocumentacao.Controls.Add(this.lblDocCivil);
            this.groupDocumentacao.Location = new System.Drawing.Point(548, 84);
            this.groupDocumentacao.Name = "groupDocumentacao";
            this.groupDocumentacao.Size = new System.Drawing.Size(345, 144);
            this.groupDocumentacao.TabIndex = 79;
            this.groupDocumentacao.TabStop = false;
            this.groupDocumentacao.Text = "Documentação Civil";
            // 
            // groupLocal
            // 
            this.groupLocal.Controls.Add(this.txtPredio);
            this.groupLocal.Controls.Add(this.txtCondominio);
            this.groupLocal.Controls.Add(this.lblCondominio);
            this.groupLocal.Controls.Add(this.lblPredio);
            this.groupLocal.Location = new System.Drawing.Point(265, 264);
            this.groupLocal.Name = "groupLocal";
            this.groupLocal.Size = new System.Drawing.Size(267, 95);
            this.groupLocal.TabIndex = 80;
            this.groupLocal.TabStop = false;
            this.groupLocal.Text = "Local";
            // 
            // groupCodigos
            // 
            this.groupCodigos.Controls.Add(this.lblIdCondominio);
            this.groupCodigos.Controls.Add(this.lblIdPredio);
            this.groupCodigos.Location = new System.Drawing.Point(553, 264);
            this.groupCodigos.Name = "groupCodigos";
            this.groupCodigos.Size = new System.Drawing.Size(340, 94);
            this.groupCodigos.TabIndex = 81;
            this.groupCodigos.TabStop = false;
            this.groupCodigos.Text = "Códigos";
            this.groupCodigos.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // groupConsultar
            // 
            this.groupConsultar.Controls.Add(this.btnConsultar);
            this.groupConsultar.Location = new System.Drawing.Point(962, 165);
            this.groupConsultar.Name = "groupConsultar";
            this.groupConsultar.Size = new System.Drawing.Size(279, 138);
            this.groupConsultar.TabIndex = 82;
            this.groupConsultar.TabStop = false;
            this.groupConsultar.Text = "Consultar";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(553, 404);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(450, 271);
            this.dgvData.TabIndex = 83;
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.Red;
            this.lblClose.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1345, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(25, 25);
            this.lblClose.TabIndex = 84;
            this.lblClose.Text = "X";
            // 
            // ucConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.mnsCondominio);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupConsultar);
            this.Controls.Add(this.groupCodigos);
            this.Controls.Add(this.groupLocal);
            this.Controls.Add(this.groupDocumentacao);
            this.Controls.Add(this.groupNome);
            this.Controls.Add(this.mnsPresentation);
            this.Name = "ucConsultar";
            this.Size = new System.Drawing.Size(1370, 800);
            this.mnsPresentation.ResumeLayout(false);
            this.mnsPresentation.PerformLayout();
            this.mnsCondominio.ResumeLayout(false);
            this.mnsCondominio.PerformLayout();
            this.groupNome.ResumeLayout(false);
            this.groupNome.PerformLayout();
            this.groupDocumentacao.ResumeLayout(false);
            this.groupDocumentacao.PerformLayout();
            this.groupLocal.ResumeLayout(false);
            this.groupLocal.PerformLayout();
            this.groupCodigos.ResumeLayout(false);
            this.groupCodigos.PerformLayout();
            this.groupConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPresentation;
        private System.Windows.Forms.ToolStripMenuItem tmsCondominio;
        private System.Windows.Forms.ToolStripMenuItem tmsPredio;
        private System.Windows.Forms.ToolStripMenuItem tmsMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmApartamento;
        private System.Windows.Forms.ToolStripMenuItem tsmVisitante;
        private System.Windows.Forms.ToolStripMenuItem tsmGaragem;
        private System.Windows.Forms.ToolStripMenuItem tsmVeículo;
        private System.Windows.Forms.ToolStripMenuItem tsmPrestadorServicos;
        private System.Windows.Forms.ToolStripMenuItem tsmSindico;
        private System.Windows.Forms.ToolStripMenuItem tsmInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmVisita;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnsCondominio;
        private System.Windows.Forms.ToolStripMenuItem tsmCadastroMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultarMorador;
        private System.Windows.Forms.ToolStripMenuItem tsmModuloVisitante;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.Label lblCondominio;
        private System.Windows.Forms.Label lblDocCivil;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblIdCondominio;
        private System.Windows.Forms.Label lblIdPredio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.TextBox txtDocCivil;
        private System.Windows.Forms.TextBox txtCondominio;
        private System.Windows.Forms.TextBox txtPredio;
        private System.Windows.Forms.GroupBox groupNome;
        private System.Windows.Forms.GroupBox groupDocumentacao;
        private System.Windows.Forms.GroupBox groupLocal;
        private System.Windows.Forms.GroupBox groupCodigos;
        private System.Windows.Forms.GroupBox groupConsultar;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblClose;
    }
}
