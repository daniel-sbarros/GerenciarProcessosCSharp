
namespace GerenciarProcessos
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addObservacoes = new System.Windows.Forms.RichTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.addInteressado = new System.Windows.Forms.TextBox();
            this.addAssunto = new System.Windows.Forms.TextBox();
            this.addStatus = new System.Windows.Forms.ComboBox();
            this.addTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.addNumero = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDate.Location = new System.Drawing.Point(747, 156);
            this.txtDate.Mask = "99/99/9999";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(230, 33);
            this.txtDate.TabIndex = 3;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(594, 159);
            this.label9.MinimumSize = new System.Drawing.Size(125, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Data da Divisão:";
            // 
            // addObservacoes
            // 
            this.addObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addObservacoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addObservacoes.Location = new System.Drawing.Point(179, 327);
            this.addObservacoes.Name = "addObservacoes";
            this.addObservacoes.Size = new System.Drawing.Size(798, 126);
            this.addObservacoes.TabIndex = 6;
            this.addObservacoes.Text = "";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnLimpar.Location = new System.Drawing.Point(608, 501);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(210, 59);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Cancelar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btnAdicionar.Location = new System.Drawing.Point(271, 501);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(210, 59);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Salvar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // addInteressado
            // 
            this.addInteressado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addInteressado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addInteressado.Location = new System.Drawing.Point(179, 213);
            this.addInteressado.Name = "addInteressado";
            this.addInteressado.Size = new System.Drawing.Size(373, 33);
            this.addInteressado.TabIndex = 4;
            // 
            // addAssunto
            // 
            this.addAssunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addAssunto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addAssunto.Location = new System.Drawing.Point(179, 156);
            this.addAssunto.Name = "addAssunto";
            this.addAssunto.Size = new System.Drawing.Size(373, 33);
            this.addAssunto.TabIndex = 2;
            // 
            // addStatus
            // 
            this.addStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addStatus.FormattingEnabled = true;
            this.addStatus.Items.AddRange(new object[] {
            "Não Iniciado",
            "Em Execução",
            "Esperando Homologação",
            "Esperando Assinatura",
            "Concluído"});
            this.addStatus.Location = new System.Drawing.Point(179, 270);
            this.addStatus.Name = "addStatus";
            this.addStatus.Size = new System.Drawing.Size(373, 33);
            this.addStatus.TabIndex = 5;
            // 
            // addTipo
            // 
            this.addTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addTipo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTipo.FormattingEnabled = true;
            this.addTipo.Items.AddRange(new object[] {
            "Físico",
            "Eletrônico"});
            this.addTipo.Location = new System.Drawing.Point(747, 99);
            this.addTipo.Name = "addTipo";
            this.addTipo.Size = new System.Drawing.Size(230, 33);
            this.addTipo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 330);
            this.label8.MinimumSize = new System.Drawing.Size(125, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Observações:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 273);
            this.label7.MinimumSize = new System.Drawing.Size(125, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Status:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 216);
            this.label6.MinimumSize = new System.Drawing.Size(125, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Interessando:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 159);
            this.label5.MinimumSize = new System.Drawing.Size(125, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Assunto:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 102);
            this.label4.MinimumSize = new System.Drawing.Size(125, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 102);
            this.label3.MinimumSize = new System.Drawing.Size(125, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Número:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(386, 26);
            this.lblTitulo.MinimumSize = new System.Drawing.Size(262, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(262, 37);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Editar Processo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addNumero
            // 
            this.addNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addNumero.Culture = new System.Globalization.CultureInfo("en-001");
            this.addNumero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNumero.Location = new System.Drawing.Point(179, 99);
            this.addNumero.Mask = "99999.999999.9999-99";
            this.addNumero.Name = "addNumero";
            this.addNumero.Size = new System.Drawing.Size(373, 33);
            this.addNumero.TabIndex = 0;
            this.addNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.LimeGreen;
            this.linkLabel1.Location = new System.Drawing.Point(555, 102);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(30, 25);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "IR";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAbrir_LinkClicked);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1034, 586);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.addObservacoes);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.addInteressado);
            this.Controls.Add(this.addAssunto);
            this.Controls.Add(this.addStatus);
            this.Controls.Add(this.addTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.addNumero);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Processo";
            this.Shown += new System.EventHandler(this.Edit_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox addObservacoes;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox addInteressado;
        private System.Windows.Forms.TextBox addAssunto;
        private System.Windows.Forms.ComboBox addStatus;
        private System.Windows.Forms.ComboBox addTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox addNumero;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}