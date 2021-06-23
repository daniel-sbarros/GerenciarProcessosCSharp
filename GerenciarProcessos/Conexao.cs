using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciarProcessos
{
    class Conexao
    {
        private SQLiteConnection conexao;

        public Conexao(string nomeDB)
        {
            conexao = new SQLiteConnection("Data Source=" + nomeDB);
        }

        private void Open()
        {
            if (conexao.State == ConnectionState.Closed) conexao.Open();
        }

        public void Close()
        {
            if (conexao.State == ConnectionState.Open) conexao.Close();
        }

        public SQLiteDataReader Select(string sql)
        {
            try
            {
                Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conexao);
                return cmd.ExecuteReader();
            }
            catch (Exception err)
            {
                Alert("Erro ao listar registro. \n\n" + err.Message);
                Close();
                return null;
            }
        }

        public void BaixarArquivo(System.Windows.Forms.DataGridView dataGridView)
        {
            try
            {
                Open();
                using (var cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "SELECT Arquivo FROM documentos WHERE id = @ID";
                    cmd.Parameters.Add(new SQLiteParameter("ID", dataGridView.CurrentRow.Cells["ID"].Value));
                    var bytes = cmd.ExecuteScalar() as byte[];

                    if (bytes != null)
                    {
                        var arquivo_nome = dataGridView.CurrentRow.Cells["Nome"].Value.ToString();

                        System.Windows.Forms.SaveFileDialog save = new System.Windows.Forms.SaveFileDialog()
                        {
                            Title = "Salvar Imagem", 
                            FileName = arquivo_nome,
                            Filter = $"(*{Path.GetExtension(arquivo_nome)})|*{Path.GetExtension(arquivo_nome)}|Todos os Arquivos (*.*)|*.*",
                            CheckPathExists = true,
                            AddExtension = true
                        };

                        if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            var arquivo_temp = save.FileName;
                            File.WriteAllBytes(arquivo_temp, bytes);

                            Alert("Arquivo Salvo com Sucesso.");
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Alert($"Erro no método btnBaixar_Click();\n\n{err}");
            }
            Close();
        }

        public DataTable DataSource(string sql)
        {
            DataTable table = new DataTable();

            try
            {
                Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, conexao);
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(cmd);

                dataAdapter.Fill(table);
            }
            catch (Exception)
            {
                table = null;
            }

            Close();
            return table;
        }

        public bool Add(string table, params string[] values)
        {
            bool retorno = true;

            try
            {
                if (values.Length != 7)
                {
                    Alert("Values Insuficientes");
                    return false;
                }

                SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO {table} VALUES (NULL, @num, @tipo, @assunto, @int, @status, @obs, @data, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP)", conexao);
                cmd.Parameters.AddWithValue("num", values[0]);
                cmd.Parameters.AddWithValue("tipo", values[1]);
                cmd.Parameters.AddWithValue("assunto", values[2]);
                cmd.Parameters.AddWithValue("int", values[3]);
                cmd.Parameters.AddWithValue("status", values[4]);
                cmd.Parameters.AddWithValue("obs", values[5]);
                cmd.Parameters.AddWithValue("data", values[6]);

                Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                if (err.Message.Contains("UNIQUE constraint failed: processos.Numero")) {
                    Alert("Processo já adicionado.");
                }
                else {
                    Alert("Erro ao adicionar registro. \n\n" + err.Message);
                }
                
                retorno = false;
            }

            Close();
            return retorno;
        }

        public bool AddArquivo(string processo_id, string arquivo, string descricao)
        {
            bool retorno = true;

            try
            {
                SQLiteCommand cmd = new SQLiteCommand($"INSERT INTO documentos VALUES (NULL, @processo_id, @nome, @arquivo, @descricao)", conexao);
                cmd.Parameters.AddWithValue("processo_id", processo_id);
                cmd.Parameters.AddWithValue("nome", Path.GetFileName(arquivo));
                cmd.Parameters.Add(new SQLiteParameter("arquivo", File.ReadAllBytes(arquivo)));
                cmd.Parameters.AddWithValue("descricao", descricao);

                Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Alert("Erro ao adicionar registro. \n\n" + err.Message);
                retorno = false;
            }

            Close();
            return retorno;
        }

        public bool Delete(string table, int id)
        {
            bool retorno = true;

            Open();
            SQLiteCommand cmd = new SQLiteCommand($"DELETE FROM {table} WHERE Id = @id", conexao);
            cmd.Parameters.AddWithValue("id", id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Alert("Erro ao deletar registro. \n\n" + err.Message);
                retorno = false;
            }

            Close();
            return retorno;
        }

        public bool Update(string table, string id, string campo, string novoValor)
        {
            bool retorno = true;
            Open();

            SQLiteCommand cmd = new SQLiteCommand($"UPDATE {table} SET {campo} = @novo, Data_Ult_Mod = CURRENT_TIMESTAMP WHERE Id = @id", conexao);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("novo", novoValor);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Alert("ERRO AO ATUALIZAR REGISTRO\n\n" + err);
                retorno = false;
            }

            Close();
            return retorno;
        }

        private void Alert(object msg)
        {
            System.Windows.Forms.MessageBox.Show(msg.ToString());
        }
    }
}
