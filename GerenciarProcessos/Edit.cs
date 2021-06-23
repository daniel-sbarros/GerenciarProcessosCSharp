using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciarProcessos
{
    public partial class Edit : Form
    {
        public Processo processo;

        public Edit(Processo processo)
        {
            InitializeComponent();
            this.processo = processo;
        }

        private void Edit_Shown(object sender, EventArgs e)
        {
            addNumero.Text = processo.Numero;
            addTipo.Text = processo.Tipo;
            addAssunto.Text = processo.Assunto;
            txtDate.Text = processo.Data_da_Divisao;
            addInteressado.Text = processo.Interessado;
            addStatus.Text = processo.Status;
            addObservacoes.Text = processo.Observacoes;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Conexao conn = new Conexao(Global.DbName);

            if (addNumero.Text.Trim() != processo.Numero) conn.Update("processos", processo.Id.ToString(), "Numero", addNumero.Text.Trim());

            if (addTipo.Text.Trim() != processo.Tipo) conn.Update("processos", processo.Id.ToString(), "Tipo", addTipo.Text.Trim());

            if (addAssunto.Text.Trim() != processo.Assunto) conn.Update("processos", processo.Id.ToString(), "Assunto", addAssunto.Text.Trim());

            if (txtDate.Text.Trim() != processo.Data_da_Divisao) conn.Update("processos", processo.Id.ToString(), "Data_da_Divisao", txtDate.Text.Trim());

            if (addInteressado.Text.Trim() != processo.Interessado) conn.Update("processos", processo.Id.ToString(), "Interessado", addInteressado.Text.Trim());

            if (addStatus.Text.Trim() != processo.Status) conn.Update("processos", processo.Id.ToString(), "Status", addStatus.Text.Trim());

            if (addObservacoes.Text.Trim() != processo.Observacoes) conn.Update("processos", processo.Id.ToString(), "Observacoes", addObservacoes.Text.Trim());

            this.Close();
        }
    }
}
