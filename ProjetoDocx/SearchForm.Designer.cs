﻿namespace ProjetoDocx
{
    partial class SearchForm
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
            this.rbtnReclamada = new System.Windows.Forms.RadioButton();
            this.rbtnReclamante = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomeProcurado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numProcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeReclamante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeReclamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnReclamada
            // 
            this.rbtnReclamada.AutoSize = true;
            this.rbtnReclamada.Location = new System.Drawing.Point(110, 0);
            this.rbtnReclamada.Name = "rbtnReclamada";
            this.rbtnReclamada.Size = new System.Drawing.Size(97, 21);
            this.rbtnReclamada.TabIndex = 11;
            this.rbtnReclamada.TabStop = true;
            this.rbtnReclamada.Text = "Reclamada";
            this.rbtnReclamada.UseVisualStyleBackColor = true;
            // 
            // rbtnReclamante
            // 
            this.rbtnReclamante.AutoSize = true;
            this.rbtnReclamante.Location = new System.Drawing.Point(0, 2);
            this.rbtnReclamante.Name = "rbtnReclamante";
            this.rbtnReclamante.Size = new System.Drawing.Size(101, 21);
            this.rbtnReclamante.TabIndex = 10;
            this.rbtnReclamante.TabStop = true;
            this.rbtnReclamante.Text = "Reclamante";
            this.rbtnReclamante.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Procura por:";
            // 
            // tbNomeProcurado
            // 
            this.tbNomeProcurado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeProcurado.Location = new System.Drawing.Point(65, 90);
            this.tbNomeProcurado.Name = "tbNomeProcurado";
            this.tbNomeProcurado.Size = new System.Drawing.Size(240, 23);
            this.tbNomeProcurado.TabIndex = 8;
            this.tbNomeProcurado.TextChanged += new System.EventHandler(this.Searchdb);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnReclamada);
            this.groupBox1.Controls.Add(this.rbtnReclamante);
            this.groupBox1.Location = new System.Drawing.Point(100, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 29);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numProcesso,
            this.nomeReclamante,
            this.nomeReclamada,
            this.dataEmissao});
            this.dataGridView2.Location = new System.Drawing.Point(319, 60);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(623, 354);
            this.dataGridView2.TabIndex = 15;
            // 
            // numProcesso
            // 
            this.numProcesso.DataPropertyName = "numProcesso";
            this.numProcesso.HeaderText = "Nº Processo";
            this.numProcesso.Name = "numProcesso";
            this.numProcesso.ReadOnly = true;
            this.numProcesso.Width = 150;
            // 
            // nomeReclamante
            // 
            this.nomeReclamante.DataPropertyName = "nomeReclamante";
            this.nomeReclamante.HeaderText = "Reclamante";
            this.nomeReclamante.Name = "nomeReclamante";
            this.nomeReclamante.ReadOnly = true;
            this.nomeReclamante.Width = 200;
            // 
            // nomeReclamada
            // 
            this.nomeReclamada.DataPropertyName = "nomeReclamada";
            this.nomeReclamada.HeaderText = "Reclamada";
            this.nomeReclamada.Name = "nomeReclamada";
            this.nomeReclamada.ReadOnly = true;
            this.nomeReclamada.Width = 200;
            // 
            // dataEmissao
            // 
            this.dataEmissao.DataPropertyName = "dataEmissao";
            this.dataEmissao.HeaderText = "Emissão";
            this.dataEmissao.Name = "dataEmissao";
            this.dataEmissao.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(449, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Editar Laudo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNomeProcurado);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laudo Pericial - Pesquizar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnReclamada;
        private System.Windows.Forms.RadioButton rbtnReclamante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomeProcurado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numProcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeReclamante;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeReclamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissao;
        private System.Windows.Forms.Button button1;
    }
}