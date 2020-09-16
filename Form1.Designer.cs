namespace BancodeDadosBelezaWeb
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntSalvar = new System.Windows.Forms.Button();
            this.txbNomeMarca = new System.Windows.Forms.TextBox();
            this.txbDescricaoMarca = new System.Windows.Forms.TextBox();
            this.txbHistoriaMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewBW = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHistoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBW)).BeginInit();
            this.SuspendLayout();
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(12, 104);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 0;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // txbNomeMarca
            // 
            this.txbNomeMarca.Location = new System.Drawing.Point(12, 33);
            this.txbNomeMarca.Name = "txbNomeMarca";
            this.txbNomeMarca.Size = new System.Drawing.Size(161, 20);
            this.txbNomeMarca.TabIndex = 1;
            // 
            // txbDescricaoMarca
            // 
            this.txbDescricaoMarca.Location = new System.Drawing.Point(193, 32);
            this.txbDescricaoMarca.Name = "txbDescricaoMarca";
            this.txbDescricaoMarca.Size = new System.Drawing.Size(191, 20);
            this.txbDescricaoMarca.TabIndex = 2;
            // 
            // txbHistoriaMarca
            // 
            this.txbHistoriaMarca.Location = new System.Drawing.Point(390, 31);
            this.txbHistoriaMarca.Name = "txbHistoriaMarca";
            this.txbHistoriaMarca.Size = new System.Drawing.Size(275, 20);
            this.txbHistoriaMarca.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descricao:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Historia:";
            // 
            // dataGridViewBW
            // 
            this.dataGridViewBW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNome,
            this.ColumnDescricao,
            this.ColumnHistoria});
            this.dataGridViewBW.Location = new System.Drawing.Point(6, 155);
            this.dataGridViewBW.Name = "dataGridViewBW";
            this.dataGridViewBW.Size = new System.Drawing.Size(694, 150);
            this.dataGridViewBW.TabIndex = 7;
            this.dataGridViewBW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            // 
            // ColumnDescricao
            // 
            this.ColumnDescricao.HeaderText = "Descricao";
            this.ColumnDescricao.Name = "ColumnDescricao";
            // 
            // ColumnHistoria
            // 
            this.ColumnHistoria.HeaderText = "Historia";
            this.ColumnHistoria.Name = "ColumnHistoria";
            this.ColumnHistoria.Width = 350;
            // 
            // bntEditar
            // 
            this.bntEditar.Location = new System.Drawing.Point(98, 104);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(75, 23);
            this.bntEditar.TabIndex = 8;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Location = new System.Drawing.Point(196, 104);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(75, 23);
            this.bntExcluir.TabIndex = 9;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(287, 104);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 10;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(13, 78);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(37, 20);
            this.txbID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.dataGridViewBW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbHistoriaMarca);
            this.Controls.Add(this.txbDescricaoMarca);
            this.Controls.Add(this.txbNomeMarca);
            this.Controls.Add(this.bntSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Banco de Dados BelezaWeb";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.TextBox txbNomeMarca;
        private System.Windows.Forms.TextBox txbDescricaoMarca;
        private System.Windows.Forms.TextBox txbHistoriaMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewBW;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHistoria;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label4;
    }
}

