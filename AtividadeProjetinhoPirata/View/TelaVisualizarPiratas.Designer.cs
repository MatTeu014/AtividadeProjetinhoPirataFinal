namespace AtividadeProjetinhoPirata.View
{
    partial class TelaVisualizarPiratas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisualizarPiratas));
            botao_pesquisar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            texto_nome = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // botao_pesquisar
            // 
            botao_pesquisar.Location = new Point(511, 93);
            botao_pesquisar.Margin = new Padding(3, 2, 3, 2);
            botao_pesquisar.Name = "botao_pesquisar";
            botao_pesquisar.Size = new Size(103, 28);
            botao_pesquisar.TabIndex = 32;
            botao_pesquisar.Text = "Pesquisar";
            botao_pesquisar.UseVisualStyleBackColor = true;
            botao_pesquisar.Click += botao_pesquisar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(60, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 74);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 18);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 17;
            label1.Text = "Pesquisa de Piratas";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.InactiveCaption;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Location = new Point(0, 241);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(700, 97);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(298, 97);
            texto_nome.Margin = new Padding(3, 2, 3, 2);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(176, 23);
            texto_nome.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(161, 98);
            label8.Name = "label8";
            label8.Size = new Size(110, 19);
            label8.TabIndex = 34;
            label8.Text = "Nome do Pirata:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(60, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(602, 175);
            dataGridView1.TabIndex = 35;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nome";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Pilhagens";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Maldicao";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "MoedasOuro";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Pistolas";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Sabres";
            Column7.Name = "Column7";
            // 
            // TelaVisualizarPiratas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(texto_nome);
            Controls.Add(botao_pesquisar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaVisualizarPiratas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisa de Piratas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_pesquisar;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox texto_nome;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}