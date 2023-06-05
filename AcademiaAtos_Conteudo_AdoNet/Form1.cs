using System.Data;
using System.Data.SqlClient;

namespace AcademiaAtos_Conteudo_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from pessoas";

            DataTable dataTable = new DataTable();

            dataTable = bd.executarConsultaGenerica(sql);
            dataGridView1.DataSource = dataTable;
        }

        private void btnFiltar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from pessoas where nome = '" + textBox1.Text + "'";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.nome = txbNome.Text;
            pessoa.profissao = txbProfissao.Text;

            if (pessoa.gravarPessoa())
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se foi selecionada alguma linha no DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém o valor da coluna "id" da linha selecionada
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                // Cria uma instância da classe Pessoa
                Pessoa pessoa = new Pessoa();

                // Define o ID da pessoa a ser excluída
                pessoa.id = id;

                // Chama o método de exclusão
                if (pessoa.excluir())
                {
                    MessageBox.Show("Excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao excluir!");
                }

                // Atualiza o DataGridView após a exclusão
                btnConsultar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa para excluir.");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Verifica se foi selecionada alguma linha no DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém os valores das colunas "id", "nome" e "profissao" da linha selecionada
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                string nomeAtual = dataGridView1.SelectedRows[0].Cells["nome"].Value.ToString();
                string profissaoAtual = dataGridView1.SelectedRows[0].Cells["profissao"].Value.ToString();

                // Obtém os novos valores dos TextBoxes
                string novoNome = txbNome.Text;
                string novaProfissao = txbProfissao.Text;

                // Cria uma instância da classe Pessoa
                Pessoa pessoa = new Pessoa();

                // Define os valores atuais da pessoa
                pessoa.id = id;
                pessoa.nome = nomeAtual;
                pessoa.profissao = profissaoAtual;

                // Verifica se o campo "nome" foi modificado
                if (!string.IsNullOrWhiteSpace(novoNome))
                    pessoa.nome = novoNome;

                // Verifica se o campo "profissao" foi modificado
                if (!string.IsNullOrWhiteSpace(novaProfissao))
                    pessoa.profissao = novaProfissao;

                // Chama o método de atualização
                if (pessoa.atualizar())
                {
                    MessageBox.Show("Atualizado com sucesso!");

                    // Atualiza os valores no DataGridView
                    dataGridView1.SelectedRows[0].Cells["nome"].Value = pessoa.nome;
                    dataGridView1.SelectedRows[0].Cells["profissao"].Value = pessoa.profissao;
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar!");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa para atualizar.");
            }
        }

        private void btnDRFilter_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa = pessoa.consultaPessoa(int.Parse(txbId.Text));

            lblDRFilter.Text = pessoa.nome;
        }
    }
}