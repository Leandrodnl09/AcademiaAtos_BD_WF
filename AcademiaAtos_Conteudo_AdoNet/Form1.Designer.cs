namespace AcademiaAtos_Conteudo_AdoNet
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
            btnConsultar = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            btnFiltrar = new Button();
            btnCadastrar = new Button();
            txbNome = new TextBox();
            txbProfissao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnDRFilter = new Button();
            txbId = new TextBox();
            lblDRFilter = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(488, 60);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(488, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 27);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(767, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(442, 480);
            dataGridView1.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(667, 60);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 29);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(21, 113);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(80, 24);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(284, 27);
            txbNome.TabIndex = 5;
            // 
            // txbProfissao
            // 
            txbProfissao.Location = new Point(99, 66);
            txbProfissao.Name = "txbProfissao";
            txbProfissao.Size = new Size(265, 27);
            txbProfissao.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 7;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 73);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 8;
            label2.Text = "Profissão:";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(139, 113);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(270, 113);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(94, 29);
            btnAtualizar.TabIndex = 10;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDRFilter
            // 
            btnDRFilter.Location = new Point(667, 159);
            btnDRFilter.Name = "btnDRFilter";
            btnDRFilter.Size = new Size(94, 29);
            btnDRFilter.TabIndex = 11;
            btnDRFilter.Text = "DR Filter";
            btnDRFilter.UseVisualStyleBackColor = true;
            btnDRFilter.Click += btnDRFilter_Click;
            // 
            // txbId
            // 
            txbId.Location = new Point(488, 159);
            txbId.Name = "txbId";
            txbId.Size = new Size(156, 27);
            txbId.TabIndex = 12;
            // 
            // lblDRFilter
            // 
            lblDRFilter.AutoSize = true;
            lblDRFilter.Location = new Point(491, 210);
            lblDRFilter.Name = "lblDRFilter";
            lblDRFilter.Size = new Size(50, 20);
            lblDRFilter.TabIndex = 13;
            lblDRFilter.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 537);
            Controls.Add(lblDRFilter);
            Controls.Add(txbId);
            Controls.Add(btnDRFilter);
            Controls.Add(btnAtualizar);
            Controls.Add(btnExcluir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbProfissao);
            Controls.Add(txbNome);
            Controls.Add(btnCadastrar);
            Controls.Add(btnFiltrar);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(btnConsultar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultar;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button btnFiltrar;
        private Button btnCadastrar;
        private TextBox txbNome;
        private TextBox txbProfissao;
        private Label label1;
        private Label label2;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnDRFilter;
        private TextBox txbId;
        private Label lblDRFilter;
    }
}