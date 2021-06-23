
namespace GerenciarProcessos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvProcessos = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.linkAdd = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkDeletar = new System.Windows.Forms.LinkLabel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkRecentes = new System.Windows.Forms.LinkLabel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dgvTarefas = new System.Windows.Forms.DataGridView();
            this.pnlAddTarefa = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.arqPath = new System.Windows.Forms.TextBox();
            this.btnCancelarTarefa = new System.Windows.Forms.Button();
            this.btnSalvarTarefa = new System.Windows.Forms.Button();
            this.arqDesc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.linkEditar = new System.Windows.Forms.LinkLabel();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.linkAbrir = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddTarefa = new System.Windows.Forms.LinkLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDivisao = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.linkInteressado = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.linkNumero = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdPessoa = new System.Windows.Forms.RadioButton();
            this.rdNumero = new System.Windows.Forms.RadioButton();
            this.checkEletronicos = new System.Windows.Forms.CheckBox();
            this.txtPesquisar = new System.Windows.Forms.MaskedTextBox();
            this.rdAssunto = new System.Windows.Forms.RadioButton();
            this.checkFisicos = new System.Windows.Forms.CheckBox();
            this.checkConcluidos = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxLstValores = new System.Windows.Forms.ComboBox();
            this.cbxLstTipo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessos)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).BeginInit();
            this.pnlAddTarefa.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 120);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(436, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciar Processos";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(10, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 800);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1327, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(30, 800);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(40, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1287, 800);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.infoPanel);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 164);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(1285, 634);
            this.panel6.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(5, 5);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5);
            this.panel8.Size = new System.Drawing.Size(597, 622);
            this.panel8.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvProcessos);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(5, 43);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(585, 518);
            this.panel11.TabIndex = 2;
            // 
            // dgvProcessos
            // 
            this.dgvProcessos.AllowUserToAddRows = false;
            this.dgvProcessos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvProcessos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcessos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProcessos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProcessos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvProcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcessos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcessos.Location = new System.Drawing.Point(0, 0);
            this.dgvProcessos.Name = "dgvProcessos";
            this.dgvProcessos.ReadOnly = true;
            this.dgvProcessos.RowTemplate.Height = 25;
            this.dgvProcessos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcessos.Size = new System.Drawing.Size(585, 518);
            this.dgvProcessos.TabIndex = 2;
            this.dgvProcessos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcessos_RowEnter);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.linkAdd);
            this.panel10.Controls.Add(this.linkLabel1);
            this.panel10.Controls.Add(this.linkDeletar);
            this.panel10.Controls.Add(this.lblAviso);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(5, 561);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(585, 54);
            this.panel10.TabIndex = 1;
            // 
            // linkAdd
            // 
            this.linkAdd.AutoSize = true;
            this.linkAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.linkAdd.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkAdd.LinkColor = System.Drawing.Color.White;
            this.linkAdd.Location = new System.Drawing.Point(4, 15);
            this.linkAdd.MinimumSize = new System.Drawing.Size(95, 0);
            this.linkAdd.Name = "linkAdd";
            this.linkAdd.Size = new System.Drawing.Size(95, 25);
            this.linkAdd.TabIndex = 4;
            this.linkAdd.TabStop = true;
            this.linkAdd.Text = "Adicionar";
            this.linkAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdd_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(105, 15);
            this.linkLabel1.MinimumSize = new System.Drawing.Size(95, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 25);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Editar";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkDeletar
            // 
            this.linkDeletar.AutoSize = true;
            this.linkDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.linkDeletar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkDeletar.LinkColor = System.Drawing.Color.White;
            this.linkDeletar.Location = new System.Drawing.Point(206, 15);
            this.linkDeletar.MaximumSize = new System.Drawing.Size(75, 0);
            this.linkDeletar.MinimumSize = new System.Drawing.Size(95, 0);
            this.linkDeletar.Name = "linkDeletar";
            this.linkDeletar.Size = new System.Drawing.Size(95, 25);
            this.linkDeletar.TabIndex = 2;
            this.linkDeletar.TabStop = true;
            this.linkDeletar.Text = "Deletar";
            this.linkDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkDeletar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDeletar_LinkClicked);
            // 
            // lblAviso
            // 
            this.lblAviso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(312, 15);
            this.lblAviso.MinimumSize = new System.Drawing.Size(270, 0);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(270, 25);
            this.lblAviso.TabIndex = 0;
            this.lblAviso.Text = "000 Registro(s) Encontrado(s).";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.linkLabel2);
            this.panel9.Controls.Add(this.linkRecentes);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(5, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(585, 38);
            this.panel9.TabIndex = 0;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(4, 9);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(98, 20);
            this.linkLabel2.TabIndex = 12;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Mostrar Tudo";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAtualizar_LinkClicked);
            // 
            // linkRecentes
            // 
            this.linkRecentes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkRecentes.AutoSize = true;
            this.linkRecentes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkRecentes.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkRecentes.LinkColor = System.Drawing.Color.White;
            this.linkRecentes.Location = new System.Drawing.Point(514, 9);
            this.linkRecentes.Name = "linkRecentes";
            this.linkRecentes.Size = new System.Drawing.Size(68, 20);
            this.linkRecentes.TabIndex = 11;
            this.linkRecentes.TabStop = true;
            this.linkRecentes.Text = "Recentes";
            this.linkRecentes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRecentes_LinkClicked);
            // 
            // infoPanel
            // 
            this.infoPanel.AutoScroll = true;
            this.infoPanel.Controls.Add(this.panel12);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoPanel.Location = new System.Drawing.Point(602, 5);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.infoPanel.Size = new System.Drawing.Size(676, 622);
            this.infoPanel.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Controls.Add(this.pnlAddTarefa);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(5, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(671, 622);
            this.panel12.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dgvTarefas);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(0, 436);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(5);
            this.panel15.Size = new System.Drawing.Size(669, 67);
            this.panel15.TabIndex = 2;
            // 
            // dgvTarefas
            // 
            this.dgvTarefas.AllowUserToAddRows = false;
            this.dgvTarefas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvTarefas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTarefas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTarefas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarefas.Location = new System.Drawing.Point(5, 5);
            this.dgvTarefas.Name = "dgvTarefas";
            this.dgvTarefas.ReadOnly = true;
            this.dgvTarefas.RowTemplate.Height = 25;
            this.dgvTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarefas.Size = new System.Drawing.Size(659, 57);
            this.dgvTarefas.TabIndex = 3;
            this.dgvTarefas.DoubleClick += new System.EventHandler(this.dgvTarefas_DoubleClick);
            // 
            // pnlAddTarefa
            // 
            this.pnlAddTarefa.Controls.Add(this.label14);
            this.pnlAddTarefa.Controls.Add(this.btnPesquisar);
            this.pnlAddTarefa.Controls.Add(this.arqPath);
            this.pnlAddTarefa.Controls.Add(this.btnCancelarTarefa);
            this.pnlAddTarefa.Controls.Add(this.btnSalvarTarefa);
            this.pnlAddTarefa.Controls.Add(this.arqDesc);
            this.pnlAddTarefa.Controls.Add(this.label13);
            this.pnlAddTarefa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddTarefa.Location = new System.Drawing.Point(0, 503);
            this.pnlAddTarefa.Name = "pnlAddTarefa";
            this.pnlAddTarefa.Size = new System.Drawing.Size(669, 117);
            this.pnlAddTarefa.TabIndex = 1;
            this.pnlAddTarefa.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(15, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Arquivo:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPesquisar.Image = global::GerenciarProcessos.Properties.Resources.loupe_24;
            this.btnPesquisar.Location = new System.Drawing.Point(621, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(32, 32);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // arqPath
            // 
            this.arqPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arqPath.Location = new System.Drawing.Point(101, 8);
            this.arqPath.Name = "arqPath";
            this.arqPath.ReadOnly = true;
            this.arqPath.Size = new System.Drawing.Size(514, 27);
            this.arqPath.TabIndex = 7;
            // 
            // btnCancelarTarefa
            // 
            this.btnCancelarTarefa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarTarefa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelarTarefa.Location = new System.Drawing.Point(378, 77);
            this.btnCancelarTarefa.Name = "btnCancelarTarefa";
            this.btnCancelarTarefa.Size = new System.Drawing.Size(169, 32);
            this.btnCancelarTarefa.TabIndex = 5;
            this.btnCancelarTarefa.Text = "Cancelar";
            this.btnCancelarTarefa.UseVisualStyleBackColor = true;
            this.btnCancelarTarefa.Click += new System.EventHandler(this.btnCancelarTarefa_Click);
            // 
            // btnSalvarTarefa
            // 
            this.btnSalvarTarefa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarTarefa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSalvarTarefa.Location = new System.Drawing.Point(162, 77);
            this.btnSalvarTarefa.Name = "btnSalvarTarefa";
            this.btnSalvarTarefa.Size = new System.Drawing.Size(169, 32);
            this.btnSalvarTarefa.TabIndex = 4;
            this.btnSalvarTarefa.Text = "Salvar";
            this.btnSalvarTarefa.UseVisualStyleBackColor = true;
            this.btnSalvarTarefa.Click += new System.EventHandler(this.btnSalvarTarefa_Click);
            // 
            // arqDesc
            // 
            this.arqDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arqDesc.Location = new System.Drawing.Point(101, 43);
            this.arqDesc.Name = "arqDesc";
            this.arqDesc.Size = new System.Drawing.Size(552, 27);
            this.arqDesc.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(15, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Descrição:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.linkEditar);
            this.panel13.Controls.Add(this.txtStatus);
            this.panel13.Controls.Add(this.label15);
            this.panel13.Controls.Add(this.linkAbrir);
            this.panel13.Controls.Add(this.button2);
            this.panel13.Controls.Add(this.button1);
            this.panel13.Controls.Add(this.btnAddTarefa);
            this.panel13.Controls.Add(this.label21);
            this.panel13.Controls.Add(this.txtObservacoes);
            this.panel13.Controls.Add(this.label20);
            this.panel13.Controls.Add(this.txtDivisao);
            this.panel13.Controls.Add(this.label19);
            this.panel13.Controls.Add(this.label17);
            this.panel13.Controls.Add(this.linkInteressado);
            this.panel13.Controls.Add(this.label16);
            this.panel13.Controls.Add(this.txtAssunto);
            this.panel13.Controls.Add(this.label10);
            this.panel13.Controls.Add(this.txtTipo);
            this.panel13.Controls.Add(this.label12);
            this.panel13.Controls.Add(this.linkNumero);
            this.panel13.Controls.Add(this.label11);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(669, 436);
            this.panel13.TabIndex = 0;
            // 
            // linkEditar
            // 
            this.linkEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkEditar.AutoSize = true;
            this.linkEditar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkEditar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkEditar.LinkColor = System.Drawing.Color.White;
            this.linkEditar.Location = new System.Drawing.Point(604, 5);
            this.linkEditar.Name = "linkEditar";
            this.linkEditar.Size = new System.Drawing.Size(48, 20);
            this.linkEditar.TabIndex = 22;
            this.linkEditar.TabStop = true;
            this.linkEditar.Text = "Editar";
            this.linkEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditar_LinkClicked);
            // 
            // txtStatus
            // 
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStatus.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Não Iniciado",
            "Em Execução",
            "Esperando Homologação",
            "Esperando Assinatura",
            "Concluído"});
            this.txtStatus.Location = new System.Drawing.Point(153, 179);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(260, 33);
            this.txtStatus.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(244, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 25);
            this.label15.TabIndex = 19;
            this.label15.Text = "Tarefas Executadas";
            // 
            // linkAbrir
            // 
            this.linkAbrir.AutoSize = true;
            this.linkAbrir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkAbrir.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkAbrir.LinkColor = System.Drawing.Color.LimeGreen;
            this.linkAbrir.Location = new System.Drawing.Point(378, 59);
            this.linkAbrir.Name = "linkAbrir";
            this.linkAbrir.Size = new System.Drawing.Size(30, 25);
            this.linkAbrir.TabIndex = 18;
            this.linkAbrir.TabStop = true;
            this.linkAbrir.Text = "IR";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(483, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(152, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddTarefa
            // 
            this.btnAddTarefa.AutoSize = true;
            this.btnAddTarefa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTarefa.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.btnAddTarefa.LinkColor = System.Drawing.Color.White;
            this.btnAddTarefa.Location = new System.Drawing.Point(518, 410);
            this.btnAddTarefa.Name = "btnAddTarefa";
            this.btnAddTarefa.Size = new System.Drawing.Size(129, 20);
            this.btnAddTarefa.TabIndex = 15;
            this.btnAddTarefa.TabStop = true;
            this.btnAddTarefa.Text = "Adicionar Arquivo";
            this.btnAddTarefa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnAddTarefa_LinkClicked);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(295, 405);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 25);
            this.label21.TabIndex = 14;
            this.label21.Text = "Anexos";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(152, 220);
            this.txtObservacoes.MaximumSize = new System.Drawing.Size(500, 150);
            this.txtObservacoes.MinimumSize = new System.Drawing.Size(500, 150);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.ReadOnly = true;
            this.txtObservacoes.Size = new System.Drawing.Size(500, 150);
            this.txtObservacoes.TabIndex = 13;
            this.txtObservacoes.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(14, 223);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 25);
            this.label20.TabIndex = 12;
            this.label20.Text = "Observacoes:";
            // 
            // txtDivisao
            // 
            this.txtDivisao.AutoSize = true;
            this.txtDivisao.BackColor = System.Drawing.Color.White;
            this.txtDivisao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDivisao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtDivisao.Location = new System.Drawing.Point(532, 182);
            this.txtDivisao.MaximumSize = new System.Drawing.Size(120, 0);
            this.txtDivisao.MinimumSize = new System.Drawing.Size(120, 0);
            this.txtDivisao.Name = "txtDivisao";
            this.txtDivisao.Size = new System.Drawing.Size(120, 25);
            this.txtDivisao.TabIndex = 11;
            this.txtDivisao.Text = "00/00/0000";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(419, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 25);
            this.label19.TabIndex = 10;
            this.label19.Text = "Divisão de:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(13, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 25);
            this.label17.TabIndex = 8;
            this.label17.Text = "Status :";
            // 
            // linkInteressado
            // 
            this.linkInteressado.AutoSize = true;
            this.linkInteressado.BackColor = System.Drawing.Color.White;
            this.linkInteressado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkInteressado.ForeColor = System.Drawing.Color.ForestGreen;
            this.linkInteressado.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkInteressado.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkInteressado.Location = new System.Drawing.Point(152, 141);
            this.linkInteressado.MaximumSize = new System.Drawing.Size(500, 25);
            this.linkInteressado.MinimumSize = new System.Drawing.Size(500, 25);
            this.linkInteressado.Name = "linkInteressado";
            this.linkInteressado.Size = new System.Drawing.Size(500, 25);
            this.linkInteressado.TabIndex = 7;
            this.linkInteressado.TabStop = true;
            this.linkInteressado.Text = "00000.000000.0000-00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(14, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 25);
            this.label16.TabIndex = 6;
            this.label16.Text = "Interessado :";
            // 
            // txtAssunto
            // 
            this.txtAssunto.AutoSize = true;
            this.txtAssunto.BackColor = System.Drawing.Color.White;
            this.txtAssunto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAssunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtAssunto.Location = new System.Drawing.Point(152, 100);
            this.txtAssunto.MaximumSize = new System.Drawing.Size(500, 25);
            this.txtAssunto.MinimumSize = new System.Drawing.Size(500, 25);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(500, 25);
            this.txtAssunto.TabIndex = 5;
            this.txtAssunto.Text = "Eletrônico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(14, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Assunto:";
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSize = true;
            this.txtTipo.BackColor = System.Drawing.Color.White;
            this.txtTipo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtTipo.Location = new System.Drawing.Point(503, 59);
            this.txtTipo.MaximumSize = new System.Drawing.Size(150, 0);
            this.txtTipo.MinimumSize = new System.Drawing.Size(150, 0);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(150, 25);
            this.txtTipo.TabIndex = 3;
            this.txtTipo.Text = "Eletrônico";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(440, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tipo:";
            // 
            // linkNumero
            // 
            this.linkNumero.AutoSize = true;
            this.linkNumero.BackColor = System.Drawing.Color.White;
            this.linkNumero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkNumero.ForeColor = System.Drawing.Color.ForestGreen;
            this.linkNumero.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkNumero.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkNumero.Location = new System.Drawing.Point(152, 59);
            this.linkNumero.MaximumSize = new System.Drawing.Size(220, 25);
            this.linkNumero.MinimumSize = new System.Drawing.Size(220, 0);
            this.linkNumero.Name = "linkNumero";
            this.linkNumero.Size = new System.Drawing.Size(220, 25);
            this.linkNumero.TabIndex = 1;
            this.linkNumero.TabStop = true;
            this.linkNumero.Text = "00000.000000.0000-00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(14, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Número:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1285, 164);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1285, 164);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.rdPessoa);
            this.tabPage1.Controls.Add(this.rdNumero);
            this.tabPage1.Controls.Add(this.checkEletronicos);
            this.tabPage1.Controls.Add(this.txtPesquisar);
            this.tabPage1.Controls.Add(this.rdAssunto);
            this.tabPage1.Controls.Add(this.checkFisicos);
            this.tabPage1.Controls.Add(this.checkConcluidos);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1277, 126);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisar";
            // 
            // rdPessoa
            // 
            this.rdPessoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdPessoa.AutoSize = true;
            this.rdPessoa.BackColor = System.Drawing.Color.Black;
            this.rdPessoa.Location = new System.Drawing.Point(545, 6);
            this.rdPessoa.Name = "rdPessoa";
            this.rdPessoa.Size = new System.Drawing.Size(188, 29);
            this.rdPessoa.TabIndex = 3;
            this.rdPessoa.Text = "Pessoa Interessada";
            this.rdPessoa.UseVisualStyleBackColor = false;
            // 
            // rdNumero
            // 
            this.rdNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdNumero.AutoSize = true;
            this.rdNumero.BackColor = System.Drawing.Color.Black;
            this.rdNumero.Checked = true;
            this.rdNumero.Location = new System.Drawing.Point(335, 6);
            this.rdNumero.Name = "rdNumero";
            this.rdNumero.Size = new System.Drawing.Size(99, 29);
            this.rdNumero.TabIndex = 2;
            this.rdNumero.TabStop = true;
            this.rdNumero.Text = "Número";
            this.rdNumero.UseVisualStyleBackColor = false;
            this.rdNumero.CheckedChanged += new System.EventHandler(this.rdNumero_CheckedChanged);
            // 
            // checkEletronicos
            // 
            this.checkEletronicos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkEletronicos.AutoSize = true;
            this.checkEletronicos.Checked = true;
            this.checkEletronicos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEletronicos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEletronicos.Location = new System.Drawing.Point(771, 86);
            this.checkEletronicos.Name = "checkEletronicos";
            this.checkEletronicos.Size = new System.Drawing.Size(169, 24);
            this.checkEletronicos.TabIndex = 8;
            this.checkEletronicos.Text = "Processos Eletrônicos";
            this.checkEletronicos.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesquisar.Culture = new System.Globalization.CultureInfo("en-001");
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisar.Location = new System.Drawing.Point(335, 47);
            this.txtPesquisar.Mask = "99999.999999.9999-99";
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(607, 33);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // rdAssunto
            // 
            this.rdAssunto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdAssunto.AutoSize = true;
            this.rdAssunto.BackColor = System.Drawing.Color.Black;
            this.rdAssunto.Location = new System.Drawing.Point(844, 6);
            this.rdAssunto.Name = "rdAssunto";
            this.rdAssunto.Size = new System.Drawing.Size(97, 29);
            this.rdAssunto.TabIndex = 4;
            this.rdAssunto.TabStop = true;
            this.rdAssunto.Text = "Assunto";
            this.rdAssunto.UseVisualStyleBackColor = false;
            // 
            // checkFisicos
            // 
            this.checkFisicos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkFisicos.AutoSize = true;
            this.checkFisicos.Checked = true;
            this.checkFisicos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFisicos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkFisicos.Location = new System.Drawing.Point(568, 86);
            this.checkFisicos.Name = "checkFisicos";
            this.checkFisicos.Size = new System.Drawing.Size(139, 24);
            this.checkFisicos.TabIndex = 9;
            this.checkFisicos.Text = "Processos Físicos";
            this.checkFisicos.UseVisualStyleBackColor = true;
            // 
            // checkConcluidos
            // 
            this.checkConcluidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkConcluidos.AutoSize = true;
            this.checkConcluidos.Checked = true;
            this.checkConcluidos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkConcluidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkConcluidos.Location = new System.Drawing.Point(335, 86);
            this.checkConcluidos.Name = "checkConcluidos";
            this.checkConcluidos.Size = new System.Drawing.Size(169, 24);
            this.checkConcluidos.TabIndex = 7;
            this.checkConcluidos.Text = "Processos Concluidos";
            this.checkConcluidos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.btnListar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbxLstValores);
            this.tabPage2.Controls.Add(this.cbxLstTipo);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1277, 126);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listar";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnListar.Location = new System.Drawing.Point(957, 44);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(133, 38);
            this.btnListar.TabIndex = 24;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(206, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Listar Por:";
            // 
            // cbxLstValores
            // 
            this.cbxLstValores.BackColor = System.Drawing.Color.Black;
            this.cbxLstValores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLstValores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxLstValores.ForeColor = System.Drawing.Color.LimeGreen;
            this.cbxLstValores.FormattingEnabled = true;
            this.cbxLstValores.Location = new System.Drawing.Point(580, 47);
            this.cbxLstValores.Name = "cbxLstValores";
            this.cbxLstValores.Size = new System.Drawing.Size(371, 33);
            this.cbxLstValores.TabIndex = 22;
            // 
            // cbxLstTipo
            // 
            this.cbxLstTipo.BackColor = System.Drawing.Color.Black;
            this.cbxLstTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLstTipo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxLstTipo.ForeColor = System.Drawing.Color.LimeGreen;
            this.cbxLstTipo.FormattingEnabled = true;
            this.cbxLstTipo.Items.AddRange(new object[] {
            "Status",
            "Tipo",
            "Data da Divisão"});
            this.cbxLstTipo.Location = new System.Drawing.Point(314, 47);
            this.cbxLstTipo.Name = "cbxLstTipo";
            this.cbxLstTipo.Size = new System.Drawing.Size(260, 33);
            this.cbxLstTipo.TabIndex = 21;
            this.cbxLstTipo.SelectedIndexChanged += new System.EventHandler(this.cbxLstTipo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1367, 940);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Processos";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcessos)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefas)).EndInit();
            this.pnlAddTarefa.ResumeLayout(false);
            this.pnlAddTarefa.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPesquisar;
        private System.Windows.Forms.CheckBox checkConcluidos;
        private System.Windows.Forms.CheckBox checkFisicos;
        private System.Windows.Forms.CheckBox checkEletronicos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgvProcessos;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.LinkLabel linkAdd;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkDeletar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.LinkLabel linkRecentes;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.DataGridView dgvTarefas;
        private System.Windows.Forms.Panel pnlAddTarefa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox arqPath;
        private System.Windows.Forms.Button btnCancelarTarefa;
        private System.Windows.Forms.Button btnSalvarTarefa;
        private System.Windows.Forms.TextBox arqDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkAbrir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel btnAddTarefa;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox txtObservacoes;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label txtDivisao;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.LinkLabel linkInteressado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txtAssunto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtTipo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkNumero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkEditar;
        private System.Windows.Forms.RadioButton rdNumero;
        private System.Windows.Forms.RadioButton rdAssunto;
        private System.Windows.Forms.RadioButton rdPessoa;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxLstValores;
        private System.Windows.Forms.ComboBox cbxLstTipo;
    }
}

