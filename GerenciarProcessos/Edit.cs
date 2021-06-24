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

        public Edit(Processo processo = null)
        {
            InitializeComponent();

            if (processo != null)
            {
                this.processo = processo;
            }
        }

        private void Edit_Shown(object sender, EventArgs e)
        {
            if (processo != null)
            {
                addNumero.Text = processo.Numero;
                addTipo.Text = processo.Tipo;
                addAssunto.Text = processo.Assunto;
                txtDate.Text = processo.Data_da_Divisao;
                addInteressado.Text = processo.Interessado;
                addStatus.Text = processo.Status;
                addObservacoes.Text = processo.Observacoes;
            }
            else
            {
                lblTitulo.Text = "Adicionar Processo";
                addNumero.Text = "23249";
                addTipo.SelectedIndex = addStatus.SelectedIndex = 0;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Conexao conn = new Conexao(Global.DbName);

            if (processo != null)
            {
                if (addNumero.Text.Trim() != processo.Numero) conn.Update("processos", processo.Id.ToString(), "Numero", addNumero.Text.Trim());

                if (addTipo.Text.Trim() != processo.Tipo) conn.Update("processos", processo.Id.ToString(), "Tipo", addTipo.Text.Trim());

                if (addAssunto.Text.Trim() != processo.Assunto) conn.Update("processos", processo.Id.ToString(), "Assunto", addAssunto.Text.Trim());

                if (txtDate.Text.Trim() != processo.Data_da_Divisao) conn.Update("processos", processo.Id.ToString(), "Data_da_Divisao", txtDate.Text.Trim());

                if (addInteressado.Text.Trim() != processo.Interessado) conn.Update("processos", processo.Id.ToString(), "Interessado", addInteressado.Text.Trim());

                if (addStatus.Text.Trim() != processo.Status) conn.Update("processos", processo.Id.ToString(), "Status", addStatus.Text.Trim());

                if (addObservacoes.Text.Trim() != processo.Observacoes) conn.Update("processos", processo.Id.ToString(), "Observacoes", addObservacoes.Text.Trim());

                this.Close();
            }
            else
            {
                if (!addNumero.MaskFull || string.IsNullOrEmpty(addAssunto.Text) || string.IsNullOrEmpty(addInteressado.Text) || addStatus.SelectedIndex < 0 || !txtDate.MaskFull)
                {
                    MessageBox.Show("Preencha todos os campos.");
                }
                else
                {
                    if (conn.Add("processos", addNumero.Text, addTipo.SelectedItem.ToString(), addAssunto.Text.Trim(), addInteressado.Text.Trim(), addStatus.SelectedItem.ToString(), addObservacoes.Text.Trim(), txtDate.Text))
                    {
                        MessageBox.Show("Processo adicionado com sucesso.");
                    }
                    
                    addAssunto.Text = addInteressado.Text = addObservacoes.Text = "";
                    addStatus.SelectedIndex = 0;

                    addNumero.Text = "23249";
                    addNumero.Focus();
                }
            }
        }

        private void linkAbrir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (addNumero.MaskFull)
            {
                System.Diagnostics.Process.Start(Global.Navegador, $"https://suap.ifma.edu.br/admin/{ (addTipo.Text == "Físico" ? "protocolo" : "processo_eletronico") }/processo/?q={addNumero.Text}");
            }
        }
    }
}
