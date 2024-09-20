namespace AtividadeProjetinhoPirata.View
{
    partial class TelaCadastroPiratas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroPiratas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            texto_nome = new TextBox();
            texto_pilhagens = new TextBox();
            texto_maldicao = new TextBox();
            texto_ouro = new TextBox();
            texto_sabres = new TextBox();
            texto_pistolas = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            botao_cadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 32);
            label1.Name = "label1";
            label1.Size = new Size(327, 46);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Piratas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(78, 163);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(78, 218);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 2;
            label3.Text = "Pilhagens Feitas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(78, 278);
            label4.Name = "label4";
            label4.Size = new Size(144, 23);
            label4.TabIndex = 3;
            label4.Text = "Possui Maldição?:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(432, 163);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 4;
            label5.Text = "Moedas de Ouro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(432, 218);
            label6.Name = "label6";
            label6.Size = new Size(71, 23);
            label6.TabIndex = 5;
            label6.Text = "Pistolas:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(432, 278);
            label7.Name = "label7";
            label7.Size = new Size(64, 23);
            label7.TabIndex = 6;
            label7.Text = "Sabres:";
            // 
            // texto_nome
            // 
            texto_nome.Location = new Point(248, 162);
            texto_nome.Name = "texto_nome";
            texto_nome.Size = new Size(156, 27);
            texto_nome.TabIndex = 7;
            // 
            // texto_pilhagens
            // 
            texto_pilhagens.Location = new Point(248, 217);
            texto_pilhagens.Name = "texto_pilhagens";
            texto_pilhagens.Size = new Size(156, 27);
            texto_pilhagens.TabIndex = 8;
            // 
            // texto_maldicao
            // 
            texto_maldicao.Location = new Point(248, 277);
            texto_maldicao.Name = "texto_maldicao";
            texto_maldicao.Size = new Size(156, 27);
            texto_maldicao.TabIndex = 9;
            // 
            // texto_ouro
            // 
            texto_ouro.Location = new Point(593, 162);
            texto_ouro.Name = "texto_ouro";
            texto_ouro.Size = new Size(156, 27);
            texto_ouro.TabIndex = 10;
            texto_ouro.TextChanged += textBox4_TextChanged;
            // 
            // texto_sabres
            // 
            texto_sabres.Location = new Point(593, 273);
            texto_sabres.Name = "texto_sabres";
            texto_sabres.Size = new Size(156, 27);
            texto_sabres.TabIndex = 15;
            // 
            // texto_pistolas
            // 
            texto_pistolas.Location = new Point(593, 217);
            texto_pistolas.Name = "texto_pistolas";
            texto_pistolas.Size = new Size(156, 27);
            texto_pistolas.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(98, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 99);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
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
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // botao_cadastrar
            // 
            botao_cadastrar.Location = new Point(605, 321);
            botao_cadastrar.Name = "botao_cadastrar";
            botao_cadastrar.Size = new Size(118, 37);
            botao_cadastrar.TabIndex = 16;
            botao_cadastrar.Text = "Cadastrar";
            botao_cadastrar.UseVisualStyleBackColor = true;
            botao_cadastrar.Click += botao_cadastrar_Click;
            // 
            // TelaCadastroPiratas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(botao_cadastrar);
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
            Name = "TelaCadastroPiratas";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Piratas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox texto_nome;
        private TextBox texto_pilhagens;
        private TextBox texto_maldicao;
        private TextBox texto_ouro;
        private TextBox texto_sabres;
        private TextBox texto_pistolas;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button botao_cadastrar;
    }
}