namespace WFA
{
    partial class ListaCarro
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnoFabricacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageLista = new System.Windows.Forms.TabPage();
            this.TabageCadastro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabPageLista.SuspendLayout();
            this.TabageCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnMarca,
            this.ColumnAnoFabricacao,
            this.ColumnValor});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(659, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.HeaderText = "Marca";
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.ReadOnly = true;
            // 
            // ColumnAnoFabricacao
            // 
            this.ColumnAnoFabricacao.HeaderText = "AnoFabricacao";
            this.ColumnAnoFabricacao.Name = "ColumnAnoFabricacao";
            this.ColumnAnoFabricacao.ReadOnly = true;
            // 
            // ColumnValor
            // 
            this.ColumnValor.HeaderText = "Valor";
            this.ColumnValor.Name = "ColumnValor";
            this.ColumnValor.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(486, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADICIONAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageLista);
            this.tabControl1.Controls.Add(this.TabageCadastro);
            this.tabControl1.ItemSize = new System.Drawing.Size(105, 22);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 445);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // TabPageLista
            // 
            this.TabPageLista.Controls.Add(this.button5);
            this.TabPageLista.Controls.Add(this.button4);
            this.TabPageLista.Controls.Add(this.dataGridView1);
            this.TabPageLista.Controls.Add(this.button1);
            this.TabPageLista.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPageLista.Location = new System.Drawing.Point(4, 26);
            this.TabPageLista.Name = "TabPageLista";
            this.TabPageLista.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageLista.Size = new System.Drawing.Size(651, 415);
            this.TabPageLista.TabIndex = 0;
            this.TabPageLista.Text = "Lista";
            this.TabPageLista.UseVisualStyleBackColor = true;
            // 
            // TabageCadastro
            // 
            this.TabageCadastro.Controls.Add(this.button3);
            this.TabageCadastro.Controls.Add(this.button2);
            this.TabageCadastro.Controls.Add(this.txtValor);
            this.TabageCadastro.Controls.Add(this.label4);
            this.TabageCadastro.Controls.Add(this.txtAno);
            this.TabageCadastro.Controls.Add(this.label3);
            this.TabageCadastro.Controls.Add(this.txtMarca);
            this.TabageCadastro.Controls.Add(this.label2);
            this.TabageCadastro.Controls.Add(this.txtNome);
            this.TabageCadastro.Controls.Add(this.label1);
            this.TabageCadastro.Location = new System.Drawing.Point(4, 26);
            this.TabageCadastro.Name = "TabageCadastro";
            this.TabageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.TabageCadastro.Size = new System.Drawing.Size(651, 415);
            this.TabageCadastro.TabIndex = 1;
            this.TabageCadastro.Text = "Cadastro";
            this.TabageCadastro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(22, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(580, 30);
            this.txtNome.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(22, 123);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(580, 30);
            this.txtMarca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(22, 191);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(580, 30);
            this.txtAno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ano";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(22, 260);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(580, 30);
            this.txtValor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(22, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 63);
            this.button2.TabIndex = 8;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(311, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(291, 63);
            this.button3.TabIndex = 9;
            this.button3.Text = "SALVAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(315, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 63);
            this.button4.TabIndex = 2;
            this.button4.Text = "EDITAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(137, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 63);
            this.button5.TabIndex = 3;
            this.button5.Text = "APAGAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ListaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(684, 460);
            this.Controls.Add(this.tabControl1);
            this.Name = "ListaCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Carros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabPageLista.ResumeLayout(false);
            this.TabageCadastro.ResumeLayout(false);
            this.TabageCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnoFabricacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPageLista;
        private System.Windows.Forms.TabPage TabageCadastro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

