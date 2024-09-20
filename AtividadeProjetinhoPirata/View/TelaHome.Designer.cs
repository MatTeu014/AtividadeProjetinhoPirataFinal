namespace AtividadeProjetinhoPirata.View
{
    partial class TelaHome
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
            menuStrip1 = new MenuStrip();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            caravelasToolStripMenuItem = new ToolStripMenuItem();
            piratasToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            caravelasToolStripMenuItem1 = new ToolStripMenuItem();
            piratasToolStripMenuItem1 = new ToolStripMenuItem();
            alterarDadosToolStripMenuItem = new ToolStripMenuItem();
            caravelasToolStripMenuItem2 = new ToolStripMenuItem();
            piratasToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.BackgroundImageLayout = ImageLayout.None;
            menuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem, cadastrarToolStripMenuItem, pesquisarToolStripMenuItem, alterarDadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(205, 2, 0, 2);
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(800, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(59, 32);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caravelasToolStripMenuItem, piratasToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(110, 32);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // caravelasToolStripMenuItem
            // 
            caravelasToolStripMenuItem.Name = "caravelasToolStripMenuItem";
            caravelasToolStripMenuItem.Size = new Size(182, 32);
            caravelasToolStripMenuItem.Text = "Caravelas";
            caravelasToolStripMenuItem.Click += caravelasToolStripMenuItem_Click;
            // 
            // piratasToolStripMenuItem
            // 
            piratasToolStripMenuItem.Name = "piratasToolStripMenuItem";
            piratasToolStripMenuItem.Size = new Size(182, 32);
            piratasToolStripMenuItem.Text = "Piratas";
            piratasToolStripMenuItem.Click += piratasToolStripMenuItem_Click;
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caravelasToolStripMenuItem1, piratasToolStripMenuItem1 });
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(112, 32);
            pesquisarToolStripMenuItem.Text = "Pesquisar";
            // 
            // caravelasToolStripMenuItem1
            // 
            caravelasToolStripMenuItem1.Name = "caravelasToolStripMenuItem1";
            caravelasToolStripMenuItem1.Size = new Size(182, 32);
            caravelasToolStripMenuItem1.Text = "Caravelas";
            caravelasToolStripMenuItem1.Click += caravelasToolStripMenuItem1_Click;
            // 
            // piratasToolStripMenuItem1
            // 
            piratasToolStripMenuItem1.Name = "piratasToolStripMenuItem1";
            piratasToolStripMenuItem1.Size = new Size(182, 32);
            piratasToolStripMenuItem1.Text = "Piratas";
            piratasToolStripMenuItem1.Click += piratasToolStripMenuItem1_Click;
            // 
            // alterarDadosToolStripMenuItem
            // 
            alterarDadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caravelasToolStripMenuItem2, piratasToolStripMenuItem2 });
            alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            alterarDadosToolStripMenuItem.Size = new Size(149, 32);
            alterarDadosToolStripMenuItem.Text = "Alterar Dados";
            // 
            // caravelasToolStripMenuItem2
            // 
            caravelasToolStripMenuItem2.Name = "caravelasToolStripMenuItem2";
            caravelasToolStripMenuItem2.Size = new Size(224, 32);
            caravelasToolStripMenuItem2.Text = "Caravelas";
            caravelasToolStripMenuItem2.Click += caravelasToolStripMenuItem2_Click;
            // 
            // piratasToolStripMenuItem2
            // 
            piratasToolStripMenuItem2.Name = "piratasToolStripMenuItem2";
            piratasToolStripMenuItem2.Size = new Size(224, 32);
            piratasToolStripMenuItem2.Text = "Piratas";
            piratasToolStripMenuItem2.Click += piratasToolStripMenuItem2_Click;
            // 
            // TelaHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources._360_F_613207306_astnM8S0t2JyrEomvxXjo1Lez8eNbuZM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaHome";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem caravelasToolStripMenuItem;
        private ToolStripMenuItem piratasToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem caravelasToolStripMenuItem1;
        private ToolStripMenuItem piratasToolStripMenuItem1;
        private ToolStripMenuItem alterarDadosToolStripMenuItem;
        private ToolStripMenuItem caravelasToolStripMenuItem2;
        private ToolStripMenuItem piratasToolStripMenuItem2;
    }
}