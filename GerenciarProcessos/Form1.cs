using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciarProcessos
{
    public partial class Form1 : Form
    {
        private string ID = null;
        private StringBuilder SQL;

        public Form1()
        {
            InitializeComponent();
            rdAssunto.CheckedChanged += rdNumero_CheckedChanged;
            rdData.CheckedChanged += rdNumero_CheckedChanged;
            SQL = new StringBuilder("SELECT * FROM processos");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
            addTipo.SelectedIndex = addStatus.SelectedIndex = 0;
            linkAtualizar_LinkClicked(null, null);
            txtDate.Text = Global.Hoje;
        }

        private void rdNumero_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Mask = rdNumero.Checked ? "99999.999999.9999-99" : (rdData.Checked ? "99/99/9999" : "");
            txtPesquisar.Clear();
            txtPesquisar.Focus();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SQL.Clear();
                SQL.Append($"SELECT * FROM processos ");

                DesabilitarPanelTarefas();

                SQL.Append(CampoPesquisado());
                SQL.Append(ChecarTipo());
                SQL.Append(MostrarPConcluidos());

                CarregarDgv(dataGridView: dgvProcessos, sql: SQL.ToString());
            }
        }

        private string CampoPesquisado()
        {
            if (rdNumero.Checked)
            {
                return $"WHERE Numero LIKE '%{txtPesquisar.Text.Trim()}%' ";
            }
            else if (rdPessoa.Checked)
            {
                return $"WHERE Interessado LIKE '%{txtPesquisar.Text.Trim()}%' ";
            }
            else if (rdData.Checked)
            {
                return $"WHERE Data_da_Divisao LIKE '%{txtPesquisar.Text.Trim()}%' ";
            }
            else
            {
                return $"WHERE Assunto LIKE '%{txtPesquisar.Text.Trim()}%' ";
            }
        }

        private string ChecarTipo()
        {
            if (checkFisicos.Checked && !checkEletronicos.Checked)
            {
                return "AND tipo LIKE '%Físico%' ";
            }
            else if (!checkFisicos.Checked && checkEletronicos.Checked)
            {
                return "AND tipo LIKE '%Eletrônico%' ";
            }
            else if (!checkFisicos.Checked && !checkEletronicos.Checked)
            {
                MessageBox.Show("Selecione um dos Tipos de Porcessos.");
                return null;
            }
            else
            {
                return " ";
            }
        }

        private string MostrarPConcluidos()
        {
            if (!checkConcluidos.Checked)
            {
                return "And Status NOT LIKE '%Concluí%' ";
            }
            else
            {
                return " ";
            }
        }

        private void tabPage2_Layout(object sender, LayoutEventArgs e)
        {
            addNumero.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!addNumero.MaskFull || string.IsNullOrEmpty(addAssunto.Text) || string.IsNullOrEmpty(addInteressado.Text) || addStatus.SelectedIndex < 0 || !txtDate.MaskFull)
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                Conexao conn = new(Global.DbName);

                if (conn.Add("processos", addNumero.Text, addTipo.SelectedItem.ToString(), addAssunto.Text.Trim(), addInteressado.Text.Trim(), addStatus.SelectedItem.ToString(), addObservacoes.Text.Trim(), txtDate.Text))
                {
                    MessageBox.Show("Processo adicionado com sucesso.");
                }
                CarregarDgv(dgvProcessos);
                addAssunto.Text = addInteressado.Text = addObservacoes.Text = addNumero.Text = "";
                addStatus.SelectedIndex = 0;
                addNumero.Focus();
            }
        }

        private void CarregarDgv(DataGridView dataGridView, string sql = null)
        {
            dataGridView.DataSource = new Conexao(Global.DbName).DataSource(sql == null ? SQL.ToString() : sql);
            lblAviso.Text = $"{dgvProcessos.Rows.Count} Processo(s) Encontrado(s).";
        }

        private void linkDeletar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Deletar Processos???", "Tem certeza que vai DELETAR os Processos Selecionados???", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvProcessos.SelectedRows)
                {
                    new Conexao(Global.DbName).Delete("processos", int.Parse($"{row.Cells[0].Value}"));
                }
                CarregarDgv(dgvProcessos);
            }
        }

        private void linkAtualizar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregarDgv(dgvProcessos, "SELECT * FROM processos");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            addAssunto.Text = addInteressado.Text = addObservacoes.Text = addNumero.Text = txtDate.Text = "";
            addTipo.SelectedIndex = addStatus.SelectedIndex = 0;
            
            addNumero.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProcessos.SelectedRows)
            {
                new Edit(new Processo()
                {
                    Id = int.Parse(row.Cells[0].Value.ToString()),
                    Numero = row.Cells[1].Value.ToString(),
                    Tipo = row.Cells[2].Value.ToString(),
                    Assunto = row.Cells[3].Value.ToString(),
                    Interessado = row.Cells[4].Value.ToString(),
                    Status = row.Cells[5].Value.ToString(),
                    Observacoes = row.Cells[6].Value.ToString(),
                    Data_da_Divisao = row.Cells[7].Value.ToString()
                }).ShowDialog();
            }
            CarregarDgv(dgvProcessos);
        }

        private void CarregarDados(DataGridViewCellEventArgs e)
        {
            try
            {
                MostrarT();
                ID = dgvProcessos.Rows[e.RowIndex].Cells[0].Value.ToString();
                linkNumero.Text = dgvProcessos.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTipo.Text = dgvProcessos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAssunto.Text = dgvProcessos.Rows[e.RowIndex].Cells[3].Value.ToString();
                linkInteressado.Text = dgvProcessos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtStatus.Text = dgvProcessos.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtObservacoes.Text = dgvProcessos.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDivisao.Text = dgvProcessos.Rows[e.RowIndex].Cells[7].Value.ToString();
                CarregarDgv(dgvTarefas, $"SELECT Id, Nome, Descricao FROM documentos WHERE processo_id = {ID}");
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro no metodo 'CarregarDados()'\n\n" + err.Message);
            }
        }

        private void dgvProcessos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DesabilitarPanelTarefas();
            CarregarDados(e);
        }

        private void btnAddTarefa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlAddTarefa.Visible = true;
            btnAddTarefa.Visible = false;
            arqDesc.Focus();
        }

        private void btnCancelarTarefa_Click(object sender, EventArgs e)
        {
            DesabilitarPanelTarefas();
        }

        private void DesabilitarPanelTarefas()
        {
            pnlAddTarefa.Visible = false;
            btnAddTarefa.Visible = true;
            arqDesc.Clear();
            arqPath.Clear();
        }

        private void btnSalvarTarefa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(arqDesc.Text) && !string.IsNullOrEmpty(arqPath.Text))
            {
                Conexao conn = new(Global.DbName);

                if (conn.AddArquivo(ID, arqPath.Text, arqDesc.Text))
                {
                    MessageBox.Show("Documento Adicionado com Sucesso.");
                }

                CarregarDgv(dgvTarefas, $"SELECT Id, Nome, Descricao FROM documentos WHERE processo_id = {ID}");
                arqDesc.Text = arqPath.Text = "";
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
        }

        private void copiar_LinkLabel(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(((LinkLabel)sender).Text);
        }

        private void MostrarT(bool ocutar = true)
        {
            try
            {
                label21.Visible = btnAddTarefa.Visible = txtObservacoes.ReadOnly = linkEditar.Visible = ocutar;
                button1.Visible = button2.Visible = txtStatus.Enabled = !ocutar;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro na função MostrarT\n\n{err}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarT();
                txtObservacoes.Text = dgvProcessos.SelectedRows[0].Cells[6].Value.ToString();
                txtStatus.Text = dgvProcessos.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Conexao(Global.DbName).Update("processos", ID, "Observacoes", txtObservacoes.Text.Trim());
            new Conexao(Global.DbName).Update("processos", ID, "Status", txtStatus.Text.Trim());
            CarregarDgv(dgvProcessos);
            MostrarT();
        }

        private void linkAbrir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;

            if (linkLabel.Name == "linkAbrir")
            {
                AbrirProcesso(txtTipo.Text.Trim(), linkNumero.Text);
            }
            else
            {
                AbrirProcesso(addTipo.Text.Trim(), addNumero.Text);
            }

            //try
            //{
            //    System.Diagnostics.Process.Start(Global.Navegador, $"https://suap.ifma.edu.br/admin/{ (txtTipo.Text.Trim() == "Físico" ? "protocolo" : "processo_eletronico") }/processo/?q={linkNumero.Text}");
            //}
            //catch (Win32Exception noBrowser)
            //{
            //    if (noBrowser.ErrorCode == -2147467259)
            //        MessageBox.Show($"noBrowser.Message\n\n{noBrowser.Message}");
            //}
            //catch (Exception other)
            //{
            //    MessageBox.Show($"other.Message\n\n{other.Message}");
            //}
        }

        private void AbrirProcesso(string tipo, string numero)
        {
            try
            {
                System.Diagnostics.Process.Start(Global.Navegador, $"https://suap.ifma.edu.br/admin/{ (tipo == "Físico" ? "protocolo" : "processo_eletronico") }/processo/?q={numero}");
            }
            catch (Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show($"noBrowser.Message\n\n{noBrowser.Message}");
            }
            catch (Exception other)
            {
                MessageBox.Show($"other.Message\n\n{other.Message}");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Title = "Abrir Imagem",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                AddExtension = true
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                arqPath.Text = openFile.FileName;
                arqDesc.Text = System.IO.Path.GetFileName(openFile.FileName);
            }
        }

        private void dgvTarefas_DoubleClick(object sender, EventArgs e)
        {
            new Conexao("dclp.db").BaixarArquivo(dgvTarefas);
        }

        private void linkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkEditar.Visible)
            {
                MostrarT(false);
                linkEditar.Visible = false;
            }
        }

        private void linkRecentes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarregarDgv(dgvProcessos, "SELECT * FROM processos ORDER BY Data_Ult_Mod DESC");
        }
    }
}
