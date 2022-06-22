namespace ProjetoDocx
{
    partial class StartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoLaudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Gerenciamento de\r\nLaudos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.novoLaudoToolStripMenuItem,
            this.pesquizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirDocumentoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // novoLaudoToolStripMenuItem
            // 
            this.novoLaudoToolStripMenuItem.Name = "novoLaudoToolStripMenuItem";
            this.novoLaudoToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.novoLaudoToolStripMenuItem.Text = "Novo Laudo";
            this.novoLaudoToolStripMenuItem.Click += new System.EventHandler(this.novoLaudoToolStripMenuItem_Click);
            // 
            // pesquizarToolStripMenuItem
            // 
            this.pesquizarToolStripMenuItem.Name = "pesquizarToolStripMenuItem";
            this.pesquizarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquizarToolStripMenuItem.Text = "Pesquizar";
            this.pesquizarToolStripMenuItem.Click += new System.EventHandler(this.pesquizarToolStripMenuItem_Click);
            // 
            // abrirDocumentoToolStripMenuItem
            // 
            this.abrirDocumentoToolStripMenuItem.Name = "abrirDocumentoToolStripMenuItem";
            this.abrirDocumentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirDocumentoToolStripMenuItem.Text = "Abrir Documento";
            this.abrirDocumentoToolStripMenuItem.Click += new System.EventHandler(this.abrirDocumentoToolStripMenuItem_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gerenciamento de laudos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoLaudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirDocumentoToolStripMenuItem;
    }
}