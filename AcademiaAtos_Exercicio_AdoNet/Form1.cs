using AcademiaAtos_Exercicio_AdoNet.Classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace AcademiaAtos_Exercicio_AdoNet
{
    public partial class Form1 : Form
    {
        private Banco banco; // Objeto da classe Banco para acessar o banco de dados

        public Form1()
        {
            InitializeComponent();
            banco = new Banco(); // Inicializa o objeto Banco
        }

        // Evento de carga do Formul�rio principal
        private void FormMiniERP_Load(object sender, EventArgs e)
        {
            // Carrega os dados dos fornecedores no ComboBox da tela de Cadastro de Produtos
            string sqlFornecedores = "SELECT Id, Nome FROM Fornecedor";
            DataTable dtFornecedores = banco.executarConsultaGenerica(sqlFornecedores);
            cmbFornecedor.DataSource = dtFornecedores;
            cmbFornecedor.DisplayMember = "Nome";
            cmbFornecedor.ValueMember = "Id";

            // Carrega os dados dos clientes no ComboBox da tela de Lan�amento de Nota
            string sqlClientes = "SELECT Id, Nome FROM Cliente";
            DataTable dtClientes = banco.executarConsultaGenerica(sqlClientes);
            cmbCliente.DataSource = dtClientes;
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";

            // Carrega os dados dos produtos no ComboBox da tela de Lan�amento de Nota
            string sqlProdutos = "SELECT Id, Nome FROM Produto";
            DataTable dtProdutos = banco.executarConsultaGenerica(sqlProdutos);
            cmbProduto.DataSource = dtProdutos;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "Id";
        }

        // Evento de clique do bot�o "Salvar" na tela de Cadastro de Fornecedores
        private void btnSalvarFornecedor_Click(object sender, EventArgs e)
        {
            // Obt�m os dados inseridos nos campos de texto
            string nome = txtNomeFornecedor.Text;
            string endereco = txtEnderecoFornecedor.Text;
            string telefone = txtTelefoneFornecedor.Text;

            // Executa o comando SQL para inserir o fornecedor no banco de dados
            string sql = $"INSERT INTO Fornecedor (Nome, Endereco, Telefone) VALUES ('{nome}', '{endereco}', '{telefone}')";
            banco.executarConsultaGenerica(sql);

            // Limpa os campos de texto ap�s salvar o fornecedor
            LimparCamposFornecedor();
        }

        // Evento de clique do bot�o "Salvar" na tela de Cadastro de Produtos
        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            // Obt�m os dados inseridos nos campos de texto
            string nome = txtNomeProduto.Text;
            decimal preco = Convert.ToDecimal(txtPrecoProduto.Text);
            int fornecedorId = Convert.ToInt32(cmbFornecedor.SelectedValue);

            // Executa o comando SQL para inserir o produto no banco de dados
            string sql = $"INSERT INTO Produto (Nome, Preco, FornecedorId) VALUES ('{nome}', {preco}, {fornecedorId})";
            banco.executarConsultaGenerica(sql);

            // Limpa os campos de texto ap�s salvar o produto
            LimparCamposProduto();
        }

        // Evento de clique do bot�o "Salvar" na tela de Cadastro de Clientes
        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            // Obt�m os dados inseridos nos campos de texto
            string nome = txtNomeCliente.Text;
            string endereco = txtEnderecoCliente.Text;
            string telefone = txtTelefoneCliente.Text;

            // Executa o comando SQL para inserir o cliente no banco de dados
            string sql = $"INSERT INTO Cliente (Nome, Endereco, Telefone) VALUES ('{nome}', '{endereco}', '{telefone}')";
            banco.executarConsultaGenerica(sql);

            // Limpa os campos de texto ap�s salvar o cliente
            LimparCamposCliente();
        }

        // Evento de clique do bot�o "Adicionar Produto" na tela de Lan�amento de Nota
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            // Obt�m os dados selecionados nos ComboBoxes e a quantidade do produto
            int produtoId = Convert.ToInt32(cmbProduto.SelectedValue);
            int quantidade = Convert.ToInt32(txtQuantidade.Text);

            // Obt�m o pre�o do produto selecionado
            string sqlPreco = $"SELECT Preco FROM Produto WHERE Id = {produtoId}";
            DataTable dtPreco = banco.executarConsultaGenerica(sqlPreco);
            decimal precoUnitario = Convert.ToDecimal(dtPreco.Rows[0]["Preco"]);

            // Calcula o valor total do produto
            decimal valorTotal = precoUnitario * quantidade;

            // Adiciona o produto � DataGridView
            dgvProdutos.Rows.Add(produtoId, cmbProduto.Text, quantidade, precoUnitario, valorTotal);

            // Limpa os campos de texto ap�s adicionar o produto
            LimparCamposNota();
        }

        // Evento de clique do bot�o "Salvar Nota" na tela de Lan�amento de Nota
        private void btnSalvarNota_Click(object sender, EventArgs e)
        {
            // Obt�m o cliente selecionado
            int clienteId = Convert.ToInt32(cmbCliente.SelectedValue);

            // Insere a nota no banco de dados
            string sqlNota = $"INSERT INTO Nota (ClienteId, Data) VALUES ({clienteId}, GETDATE())";
            banco.executarConsultaGenerica(sqlNota);

            // Obt�m o ID da �ltima nota inserida
            string sqlUltimaNota = "SELECT TOP 1 Id FROM Nota ORDER BY Id DESC";
            DataTable dtUltimaNota = banco.executarConsultaGenerica(sqlUltimaNota);
            int notaId = Convert.ToInt32(dtUltimaNota.Rows[0]["Id"]);

            // Insere os produtos da nota no banco de dados
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                int produtoId = Convert.ToInt32(row.Cells["ProdutoId"].Value);
                int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                decimal precoUnitario = Convert.ToDecimal(row.Cells["PrecoUnitario"].Value);

                string sqlNotaProduto = $"INSERT INTO NotaProduto (NotaId, ProdutoId, Quantidade, PrecoUnitario) " +
                    $"VALUES ({notaId}, {produtoId}, {quantidade}, {precoUnitario})";
                banco.executarConsultaGenerica(sqlNotaProduto);
            }

            // Limpa os campos e a DataGridView ap�s salvar a nota
            LimparCamposNota();
            dgvProdutos.Rows.Clear();
        }

        // M�todo para limpar os campos de texto da tela de Cadastro de Fornecedores
        private void LimparCamposFornecedor()
        {
            txtNomeFornecedor.Text = "";
            txtEnderecoFornecedor.Text = "";
            txtTelefoneFornecedor.Text = "";
        }

        // M�todo para limpar os campos de texto da tela de Cadastro de Produtos
        private void LimparCamposProduto()
        {
            cmbFornecedor.SelectedIndex = -1;
            txtNomeProduto.Text = "";
            txtPrecoProduto.Text = "";
        }

        // M�todo para limpar os campos de texto da tela de Cadastro de Clientes
        private void LimparCamposCliente()
        {
            txtNomeCliente.Text = "";
            txtEnderecoCliente.Text = "";
            txtTelefoneCliente.Text = "";
        }

        // M�todo para limpar os campos de texto da tela de Lan�amento de Nota
        private void LimparCamposNota()
        {
            cmbCliente.SelectedIndex = -1;
            cmbProduto.SelectedIndex = -1;
            txtQuantidade.Text = "";
        }
    }
}
