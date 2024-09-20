namespace AtividadeProjetinhoPirata.View
{
    partial class TelaVisualizarCaravelas
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
            label1 = new Label();
            label2 = new Label();
            texto_nome = new TextBox();
            pictureBox2 = new PictureBox();
            botao_pesquisar = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 22);
            label1.Name = "label1";
            label1.Size = new Size(297, 37);
            label1.TabIndex = 0;
            label1.Text = "Pesquisa de Caravelas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 80);
            label2.Name = "label2";
            label2.Size = new Size(126, 19);
            label2.TabIndex = 1;
            label2.Text = "Nome da Caravela:";
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(271, 78);
            texto_nome.Margin = new Padding(3, 2, 3, 2);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(210, 23);
            texto_nome.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.pngtree_digital_ocean_wave_painting_png_image_6564274;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Location = new Point(0, 203);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(700, 135);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // botao_pesquisar
            // 
            botao_pesquisar.Location = new Point(519, 74);
            botao_pesquisar.Margin = new Padding(3, 2, 3, 2);
            botao_pesquisar.Name = "botao_pesquisar";
            botao_pesquisar.Size = new Size(103, 28);
            botao_pesquisar.TabIndex = 23;
            botao_pesquisar.Text = "Pesquisar";
            botao_pesquisar.UseVisualStyleBackColor = true;
            botao_pesquisar.Click += botao_pesquisar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.pngtree_ship_caravel_png_png_image_13164751;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(513, 1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 77);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(676, 183);
            dataGridView1.TabIndex = 25;
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
            Column3.HeaderText = "Rum";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "MoedasOuro";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "MoedasPrata";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Mapas";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "BalasCanhao";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Comida";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Piratas";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Joias";
            Column10.Name = "Column10";
            // 
            // TelaVisualizarCaravelas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridView1);
            Controls.Add(botao_pesquisar);
            Controls.Add(texto_nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaVisualizarCaravelas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pesquisa de Caravelas";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox texto_nome;
        private PictureBox pictureBox2;
        private Button botao_pesquisar;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}