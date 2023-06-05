namespace AcademiaAtos_Exercicio_AdoNet
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
            tabControl1 = new TabControl();
            tabCadastroDeProdutos = new TabPage();
            cmbFornecedor = new ComboBox();
            lblFornecedor = new Label();
            txtPrecoProduto = new TextBox();
            txtNomeProduto = new TextBox();
            lblPrecoProduto = new Label();
            lblNomeProduto = new Label();
            tabCadastroDeFornecedores = new TabPage();
            label6 = new Label();
            label5 = new Label();
            txtTelefoneFornecedor = new TextBox();
            txtEnderecoFornecedor = new TextBox();
            txtNomeFornecedor = new TextBox();
            tabCadastroDeClientes = new TabPage();
            txtTelefoneCliente = new TextBox();
            txtEnderecoCliente = new TextBox();
            txtNomeCliente = new TextBox();
            tabLancamentoNotas = new TabPage();
            btnAdicionarProduto = new Button();
            txtQuantidade = new NumericUpDown();
            lblQuantidade = new Label();
            cmbProduto = new ComboBox();
            lblProduto = new Label();
            lblCliente = new Label();
            btnGerarNotaPDF = new Button();
            btnSalvarProduto = new Button();
            lblNomeFornecedor = new Label();
            btnSalvarFornecedor = new Button();
            lblNomeCliente = new Label();
            lblEnderecoCliente = new Label();
            lblTelefoneCliente = new Label();
            btnSalvarCliente = new Button();
            cmbCliente = new ComboBox();
            dgvProdutosNota = new DataGridView();
            btnSalvarNota = new Button();
            tabControl1.SuspendLayout();
            tabCadastroDeProdutos.SuspendLayout();
            tabCadastroDeFornecedores.SuspendLayout();
            tabCadastroDeClientes.SuspendLayout();
            tabLancamentoNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutosNota).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCadastroDeProdutos);
            tabControl1.Controls.Add(tabCadastroDeFornecedores);
            tabControl1.Controls.Add(tabCadastroDeClientes);
            tabControl1.Controls.Add(tabLancamentoNotas);
            tabControl1.Location = new Point(14, 16);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(887, 528);
            tabControl1.TabIndex = 0;
            tabControl1.Click += btnSalvarCliente_Click;
            // 
            // tabCadastroDeProdutos
            // 
            tabCadastroDeProdutos.Controls.Add(btnSalvarProduto);
            tabCadastroDeProdutos.Controls.Add(cmbFornecedor);
            tabCadastroDeProdutos.Controls.Add(lblFornecedor);
            tabCadastroDeProdutos.Controls.Add(txtPrecoProduto);
            tabCadastroDeProdutos.Controls.Add(txtNomeProduto);
            tabCadastroDeProdutos.Controls.Add(lblPrecoProduto);
            tabCadastroDeProdutos.Controls.Add(lblNomeProduto);
            tabCadastroDeProdutos.Location = new Point(4, 29);
            tabCadastroDeProdutos.Margin = new Padding(3, 4, 3, 4);
            tabCadastroDeProdutos.Name = "tabCadastroDeProdutos";
            tabCadastroDeProdutos.Padding = new Padding(3, 4, 3, 4);
            tabCadastroDeProdutos.Size = new Size(879, 495);
            tabCadastroDeProdutos.TabIndex = 0;
            tabCadastroDeProdutos.Text = "Cadastro de Produtos";
            tabCadastroDeProdutos.UseVisualStyleBackColor = true;
            // 
            // cmbFornecedor
            // 
            cmbFornecedor.FormattingEnabled = true;
            cmbFornecedor.Location = new Point(198, 173);
            cmbFornecedor.Margin = new Padding(3, 4, 3, 4);
            cmbFornecedor.Name = "cmbFornecedor";
            cmbFornecedor.Size = new Size(138, 28);
            cmbFornecedor.TabIndex = 7;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Location = new Point(50, 177);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(87, 20);
            lblFornecedor.TabIndex = 6;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // txtPrecoProduto
            // 
            txtPrecoProduto.Location = new Point(222, 109);
            txtPrecoProduto.Margin = new Padding(3, 4, 3, 4);
            txtPrecoProduto.Name = "txtPrecoProduto";
            txtPrecoProduto.Size = new Size(114, 27);
            txtPrecoProduto.TabIndex = 3;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(222, 45);
            txtNomeProduto.Margin = new Padding(3, 4, 3, 4);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(114, 27);
            txtNomeProduto.TabIndex = 2;
            // 
            // lblPrecoProduto
            // 
            lblPrecoProduto.AutoSize = true;
            lblPrecoProduto.Location = new Point(50, 109);
            lblPrecoProduto.Name = "lblPrecoProduto";
            lblPrecoProduto.Size = new Size(128, 20);
            lblPrecoProduto.TabIndex = 1;
            lblPrecoProduto.Text = "Preço do Produto:";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(47, 45);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(132, 20);
            lblNomeProduto.TabIndex = 0;
            lblNomeProduto.Text = "Nome do Produto:";
            // 
            // tabCadastroDeFornecedores
            // 
            tabCadastroDeFornecedores.Controls.Add(btnSalvarFornecedor);
            tabCadastroDeFornecedores.Controls.Add(lblNomeFornecedor);
            tabCadastroDeFornecedores.Controls.Add(label6);
            tabCadastroDeFornecedores.Controls.Add(label5);
            tabCadastroDeFornecedores.Controls.Add(txtTelefoneFornecedor);
            tabCadastroDeFornecedores.Controls.Add(txtEnderecoFornecedor);
            tabCadastroDeFornecedores.Controls.Add(txtNomeFornecedor);
            tabCadastroDeFornecedores.Location = new Point(4, 29);
            tabCadastroDeFornecedores.Margin = new Padding(3, 4, 3, 4);
            tabCadastroDeFornecedores.Name = "tabCadastroDeFornecedores";
            tabCadastroDeFornecedores.Padding = new Padding(3, 4, 3, 4);
            tabCadastroDeFornecedores.Size = new Size(879, 495);
            tabCadastroDeFornecedores.TabIndex = 1;
            tabCadastroDeFornecedores.Text = "Cadastro de Fornecedores";
            tabCadastroDeFornecedores.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 161);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 6;
            label6.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 103);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 5;
            label5.Text = "Endereço:";
            // 
            // txtTelefoneFornecedor
            // 
            txtTelefoneFornecedor.Location = new Point(235, 164);
            txtTelefoneFornecedor.Margin = new Padding(3, 4, 3, 4);
            txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            txtTelefoneFornecedor.Size = new Size(114, 27);
            txtTelefoneFornecedor.TabIndex = 3;
            // 
            // txtEnderecoFornecedor
            // 
            txtEnderecoFornecedor.Location = new Point(232, 103);
            txtEnderecoFornecedor.Margin = new Padding(3, 4, 3, 4);
            txtEnderecoFornecedor.Name = "txtEnderecoFornecedor";
            txtEnderecoFornecedor.Size = new Size(114, 27);
            txtEnderecoFornecedor.TabIndex = 2;
            // 
            // txtNomeFornecedor
            // 
            txtNomeFornecedor.Location = new Point(226, 45);
            txtNomeFornecedor.Margin = new Padding(3, 4, 3, 4);
            txtNomeFornecedor.Name = "txtNomeFornecedor";
            txtNomeFornecedor.Size = new Size(114, 27);
            txtNomeFornecedor.TabIndex = 1;
            // 
            // tabCadastroDeClientes
            // 
            tabCadastroDeClientes.Controls.Add(btnSalvarCliente);
            tabCadastroDeClientes.Controls.Add(lblTelefoneCliente);
            tabCadastroDeClientes.Controls.Add(lblEnderecoCliente);
            tabCadastroDeClientes.Controls.Add(lblNomeCliente);
            tabCadastroDeClientes.Controls.Add(txtTelefoneCliente);
            tabCadastroDeClientes.Controls.Add(txtEnderecoCliente);
            tabCadastroDeClientes.Controls.Add(txtNomeCliente);
            tabCadastroDeClientes.Location = new Point(4, 29);
            tabCadastroDeClientes.Margin = new Padding(3, 4, 3, 4);
            tabCadastroDeClientes.Name = "tabCadastroDeClientes";
            tabCadastroDeClientes.Size = new Size(879, 495);
            tabCadastroDeClientes.TabIndex = 2;
            tabCadastroDeClientes.Text = "Cadastro de Clientes";
            tabCadastroDeClientes.UseVisualStyleBackColor = true;
            // 
            // txtTelefoneCliente
            // 
            txtTelefoneCliente.Location = new Point(245, 164);
            txtTelefoneCliente.Margin = new Padding(3, 4, 3, 4);
            txtTelefoneCliente.Name = "txtTelefoneCliente";
            txtTelefoneCliente.Size = new Size(114, 27);
            txtTelefoneCliente.TabIndex = 6;
            // 
            // txtEnderecoCliente
            // 
            txtEnderecoCliente.Location = new Point(250, 101);
            txtEnderecoCliente.Margin = new Padding(3, 4, 3, 4);
            txtEnderecoCliente.Name = "txtEnderecoCliente";
            txtEnderecoCliente.Size = new Size(114, 27);
            txtEnderecoCliente.TabIndex = 5;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(253, 41);
            txtNomeCliente.Margin = new Padding(3, 4, 3, 4);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(114, 27);
            txtNomeCliente.TabIndex = 4;
            // 
            // tabLancamentoNotas
            // 
            tabLancamentoNotas.Controls.Add(btnSalvarNota);
            tabLancamentoNotas.Controls.Add(dgvProdutosNota);
            tabLancamentoNotas.Controls.Add(cmbCliente);
            tabLancamentoNotas.Controls.Add(btnAdicionarProduto);
            tabLancamentoNotas.Controls.Add(txtQuantidade);
            tabLancamentoNotas.Controls.Add(lblQuantidade);
            tabLancamentoNotas.Controls.Add(cmbProduto);
            tabLancamentoNotas.Controls.Add(lblProduto);
            tabLancamentoNotas.Controls.Add(lblCliente);
            tabLancamentoNotas.Controls.Add(btnGerarNotaPDF);
            tabLancamentoNotas.Location = new Point(4, 29);
            tabLancamentoNotas.Margin = new Padding(3, 4, 3, 4);
            tabLancamentoNotas.Name = "tabLancamentoNotas";
            tabLancamentoNotas.Padding = new Padding(3, 4, 3, 4);
            tabLancamentoNotas.Size = new Size(879, 495);
            tabLancamentoNotas.TabIndex = 3;
            tabLancamentoNotas.Text = "Lancamento de Notas";
            tabLancamentoNotas.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Location = new Point(60, 228);
            btnAdicionarProduto.Margin = new Padding(3, 4, 3, 4);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(165, 31);
            btnAdicionarProduto.TabIndex = 10;
            btnAdicionarProduto.Text = "Adicionar Produto";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(168, 161);
            txtQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(157, 27);
            txtQuantidade.TabIndex = 9;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(56, 165);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(90, 20);
            lblQuantidade.TabIndex = 8;
            lblQuantidade.Text = "Quantidade:";
            // 
            // cmbProduto
            // 
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(131, 99);
            cmbProduto.Margin = new Padding(3, 4, 3, 4);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(193, 28);
            cmbProduto.TabIndex = 7;
            cmbProduto.Text = "Nome produto";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(50, 100);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(65, 20);
            lblProduto.TabIndex = 6;
            lblProduto.Text = "Produto:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(57, 42);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente:";
            // 
            // btnGerarNotaPDF
            // 
            btnGerarNotaPDF.Location = new Point(287, 228);
            btnGerarNotaPDF.Margin = new Padding(3, 4, 3, 4);
            btnGerarNotaPDF.Name = "btnGerarNotaPDF";
            btnGerarNotaPDF.Size = new Size(94, 31);
            btnGerarNotaPDF.TabIndex = 4;
            btnGerarNotaPDF.Text = "Gerar Nota";
            btnGerarNotaPDF.UseVisualStyleBackColor = true;
            // 
            // btnSalvarProduto
            // 
            btnSalvarProduto.Location = new Point(65, 237);
            btnSalvarProduto.Name = "btnSalvarProduto";
            btnSalvarProduto.Size = new Size(133, 29);
            btnSalvarProduto.TabIndex = 8;
            btnSalvarProduto.Text = "Salvar Produto";
            btnSalvarProduto.UseVisualStyleBackColor = true;
            btnSalvarProduto.Click += btnSalvarProduto_Click;
            // 
            // lblNomeFornecedor
            // 
            lblNomeFornecedor.AutoSize = true;
            lblNomeFornecedor.Location = new Point(67, 45);
            lblNomeFornecedor.Name = "lblNomeFornecedor";
            lblNomeFornecedor.Size = new Size(53, 20);
            lblNomeFornecedor.TabIndex = 7;
            lblNomeFornecedor.Text = "Nome:";
            // 
            // btnSalvarFornecedor
            // 
            btnSalvarFornecedor.Location = new Point(77, 247);
            btnSalvarFornecedor.Name = "btnSalvarFornecedor";
            btnSalvarFornecedor.Size = new Size(163, 29);
            btnSalvarFornecedor.TabIndex = 8;
            btnSalvarFornecedor.Text = "Salvar Fornecedor";
            btnSalvarFornecedor.UseVisualStyleBackColor = true;
            btnSalvarFornecedor.Click += btnSalvarFornecedor_Click;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(93, 44);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(53, 20);
            lblNomeCliente.TabIndex = 7;
            lblNomeCliente.Text = "Nome:";
            // 
            // lblEnderecoCliente
            // 
            lblEnderecoCliente.AutoSize = true;
            lblEnderecoCliente.Location = new Point(100, 103);
            lblEnderecoCliente.Name = "lblEnderecoCliente";
            lblEnderecoCliente.Size = new Size(74, 20);
            lblEnderecoCliente.TabIndex = 8;
            lblEnderecoCliente.Text = "Endereço:";
            // 
            // lblTelefoneCliente
            // 
            lblTelefoneCliente.AutoSize = true;
            lblTelefoneCliente.Location = new Point(101, 167);
            lblTelefoneCliente.Name = "lblTelefoneCliente";
            lblTelefoneCliente.Size = new Size(73, 20);
            lblTelefoneCliente.TabIndex = 9;
            lblTelefoneCliente.Text = "Telefone: ";
            // 
            // btnSalvarCliente
            // 
            btnSalvarCliente.Location = new Point(93, 219);
            btnSalvarCliente.Name = "btnSalvarCliente";
            btnSalvarCliente.Size = new Size(139, 29);
            btnSalvarCliente.TabIndex = 10;
            btnSalvarCliente.Text = "Salvar Cliente";
            btnSalvarCliente.UseVisualStyleBackColor = true;
            btnSalvarCliente.Click += btnSalvarCliente_Click;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(161, 45);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(151, 28);
            cmbCliente.TabIndex = 11;
            // 
            // dgvProdutosNota
            // 
            dgvProdutosNota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutosNota.Location = new Point(464, 42);
            dgvProdutosNota.Name = "dgvProdutosNota";
            dgvProdutosNota.RowHeadersWidth = 51;
            dgvProdutosNota.RowTemplate.Height = 29;
            dgvProdutosNota.Size = new Size(300, 188);
            dgvProdutosNota.TabIndex = 12;
            // 
            // btnSalvarNota
            // 
            btnSalvarNota.Location = new Point(60, 275);
            btnSalvarNota.Name = "btnSalvarNota";
            btnSalvarNota.Size = new Size(94, 29);
            btnSalvarNota.TabIndex = 13;
            btnSalvarNota.Text = "Salvar Nota";
            btnSalvarNota.UseVisualStyleBackColor = true;
            btnSalvarNota.Click += btnSalvarNota_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabCadastroDeProdutos.ResumeLayout(false);
            tabCadastroDeProdutos.PerformLayout();
            tabCadastroDeFornecedores.ResumeLayout(false);
            tabCadastroDeFornecedores.PerformLayout();
            tabCadastroDeClientes.ResumeLayout(false);
            tabCadastroDeClientes.PerformLayout();
            tabLancamentoNotas.ResumeLayout(false);
            tabLancamentoNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutosNota).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCadastroDeProdutos;
        private TabPage tabCadastroDeFornecedores;
        private TextBox txtPrecoProduto;
        private TextBox txtNomeProduto;
        private Label lblPrecoProduto;
        private Label lblNomeProduto;
        private DataGridView dgvProdutos;
        private Button btnCadastrarProduto;
        private TabPage tabCadastroDeClientes;
        private TextBox txtQuantidadeProduto;
        private Label lblFornecedor;
        private TextBox txtEmailFornecedor;
        private TextBox txtTelefoneFornecedor;
        private TextBox txtEnderecoFornecedor;
        private TextBox txtNomeFornecedor;
        private Label label4;
        private Label label5;
        private DataGridView dgvFornecedores;
        private Button btnCadastrarFornecedor;
        private Label label7;
        private Label label6;
        private TextBox txtEmailCliente;
        private TextBox txtTelefoneCliente;
        private TextBox txtEnderecoCliente;
        private TextBox txtNomeCliente;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnCadastrarCliente;
        private DataGridView dgvClientes;
        private ComboBox cmbFornecedorProduto;
        private TabPage tabLancamentoNotas;
        private DataGridView dgvNotas;
        private ComboBox cmbClienteNota;
        private Button btnLancarNotas;
        private DataGridView dgvProdutosNotas;
        private Button btnGerarNotaPDF;
        private Label lblCliente;
        private NumericUpDown txtQuantidade;
        private Label lblQuantidade;
        private ComboBox cmbProduto;
        private Label lblProduto;
        private Button btnAdicionarProduto;
        private ComboBox cmbFornecedor;
        private Button btnSalvarProduto;
        private Button btnSalvarFornecedor;
        private Label lblNomeFornecedor;
        private Label lblNomeCliente;
        private Button btnSalvarCliente;
        private Label lblTelefoneCliente;
        private Label lblEnderecoCliente;
        private ComboBox cmbCliente;
        private Button btnSalvarNota;
        private DataGridView dgvProdutosNota;
    }
}