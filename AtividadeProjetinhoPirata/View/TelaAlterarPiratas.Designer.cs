namespace AtividadeProjetinhoPirata.View
{
    partial class TelaAlterarPiratas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarPiratas));
            botao_alterar = new Button();
            pictureBox1 = new PictureBox();
            texto_pistolas = new TextBox();
            texto_sabres = new TextBox();
            texto_ouro = new TextBox();
            texto_maldicao = new TextBox();
            texto_pilhagens = new TextBox();
            texto_nome = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            botao_excluir = new Button();
            label8 = new Label();
            texto_codigo = new TextBox();
            botao_pesquisar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // botao_alterar
            // 
            botao_alterar.Location = new Point(605, 315);
            botao_alterar.Name = "botao_alterar";
            botao_alterar.Size = new Size(118, 37);
            botao_alterar.TabIndex = 32;
            botao_alterar.Text = "Alterar";
            botao_alterar.UseVisualStyleBackColor = true;
            botao_alterar.Click += botao_alterar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(60, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 99);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // texto_pistolas
            // 
            texto_pistolas.Location = new Point(593, 211);
            texto_pistolas.Name = "texto_pistolas";
            texto_pistolas.Size = new Size(156, 27);
            texto_pistolas.TabIndex = 29;
            // 
            // texto_sabres
            // 
            texto_sabres.Location = new Point(593, 267);
            texto_sabres.Name = "texto_sabres";
            texto_sabres.Size = new Size(156, 27);
            texto_sabres.TabIndex = 31;
            // 
            // texto_ouro
            // 
            texto_ouro.Location = new Point(593, 156);
            texto_ouro.Name = "texto_ouro";
            texto_ouro.Size = new Size(156, 27);
            texto_ouro.TabIndex = 27;
            // 
            // texto_maldicao
            // 
            texto_maldicao.Location = new Point(248, 271);
            texto_maldicao.Name = "texto_maldicao";
            texto_maldicao.Size = new Size(156, 27);
            texto_maldicao.TabIndex = 26;
            // 
            // texto_pilhagens
            // 
            texto_pilhagens.Location = new Point(248, 211);
            texto_pilhagens.Name = "texto_pilhagens";
            texto_pilhagens.Size = new Size(156, 27);
            texto_pilhagens.TabIndex = 25;
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(248, 156);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(156, 27);
            texto_nome.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(432, 272);
            label7.Name = "label7";
            label7.Size = new Size(64, 23);
            label7.TabIndex = 23;
            label7.Text = "Sabres:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(432, 212);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 22;
            label6.Text = "Pistolas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(432, 157);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 21;
            label5.Text = "Moedas de Ouro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(78, 272);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 20;
            label4.Text = "Possui Maldição?:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(78, 212);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 19;
            label3.Text = "Pilhagens Feitas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(78, 157);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 18;
            label2.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 32);
            label1.Name = "label1";
            label1.Size = new Size(424, 46);
            label1.TabIndex = 17;
            label1.Text = "Alterar Dados dos Piratas";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.InactiveCaption;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Location = new Point(0, 321);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 129);
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // botao_excluir
            // 
            botao_excluir.Location = new Point(96, 315);
            botao_excluir.Name = "botao_excluir";
            botao_excluir.Size = new Size(118, 37);
            botao_excluir.TabIndex = 33;
            botao_excluir.Text = "Excluir";
            botao_excluir.UseVisualStyleBackColor = true;
            botao_excluir.Click += botao_excluir_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(236, 110);
            label8.Name = "label8";
            label8.Size = new Size(143, 23);
            label8.TabIndex = 34;
            label8.Text = "Código do Pirata:";
            // 
            // texto_codigo
            // 
            texto_codigo.Location = new Point(400, 108);
            texto_codigo.Name = "texto_codigo";
            texto_codigo.Size = new Size(175, 27);
            texto_codigo.TabIndex = 35;
            // 
            // botao_pesquisar
            // 
            botao_pesquisar.Location = new Point(616, 104);
            botao_pesquisar.Name = "botao_pesquisar";
            botao_pesquisar.Size = new Size(118, 37);
            botao_pesquisar.TabIndex = 36;
            botao_pesquisar.Text = "Pesquisar";
            botao_pesquisar.UseVisualStyleBackColor = true;
            botao_pesquisar.Click += botao_pesquisar_Click;
            // 
            // TelaAlterarPiratas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(botao_pesquisar);
            Controls.Add(texto_codigo);
            Controls.Add(label8);
            Controls.Add(botao_excluir);
            Controls.Add(botao_alterar);
            Controls.Add(pictureBox1);
            Controls.Add(texto_pistolas);
            Controls.Add(texto_sabres);
            Controls.Add(texto_ouro);
            Controls.Add(texto_maldicao);
            Controls.Add(texto_pilhagens);
            Controls.Add(texto_nome);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "TelaAlterarPiratas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Dados dos Piratas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao_alterar;
        private PictureBox pictureBox1;
        private TextBox texto_pistolas;
        private TextBox texto_sabres;
        private TextBox texto_ouro;
        private TextBox texto_maldicao;
        private TextBox texto_pilhagens;
        private TextBox texto_nome;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Button botao_excluir;
        private Label label8;
        private TextBox texto_codigo;
        private Button botao_pesquisar;
    }
}