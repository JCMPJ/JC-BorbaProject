namespace ProjetoBreno
{
    partial class Form_EditarAcompanhante
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
            this.lb_EditarAcompanhante = new System.Windows.Forms.Label();
            this.tb_EditarAcompanhante = new System.Windows.Forms.TextBox();
            this.btn_EditarAcompanhante = new System.Windows.Forms.Button();
            this.btn_CancelAcompanhante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_EditarAcompanhante
            // 
            this.lb_EditarAcompanhante.AutoSize = true;
            this.lb_EditarAcompanhante.Location = new System.Drawing.Point(20, 10);
            this.lb_EditarAcompanhante.Name = "lb_EditarAcompanhante";
            this.lb_EditarAcompanhante.Size = new System.Drawing.Size(65, 13);
            this.lb_EditarAcompanhante.TabIndex = 0;
            this.lb_EditarAcompanhante.Text = "Editar Nome";
            // 
            // tb_EditarAcompanhante
            // 
            this.tb_EditarAcompanhante.Location = new System.Drawing.Point(20, 40);
            this.tb_EditarAcompanhante.Name = "tb_EditarAcompanhante";
            this.tb_EditarAcompanhante.Size = new System.Drawing.Size(200, 20);
            this.tb_EditarAcompanhante.TabIndex = 1;
            // 
            // btn_EditarAcompanhante
            // 
            this.btn_EditarAcompanhante.Location = new System.Drawing.Point(20, 80);
            this.btn_EditarAcompanhante.Name = "btn_EditarAcompanhante";
            this.btn_EditarAcompanhante.Size = new System.Drawing.Size(80, 20);
            this.btn_EditarAcompanhante.TabIndex = 2;
            this.btn_EditarAcompanhante.Text = "Editar";
            this.btn_EditarAcompanhante.UseVisualStyleBackColor = true;
            this.btn_EditarAcompanhante.Click += new System.EventHandler(this.BTN_EditarAcompanhante_Click);
            // 
            // btn_CancelAcompanhante
            // 
            this.btn_CancelAcompanhante.Location = new System.Drawing.Point(140, 80);
            this.btn_CancelAcompanhante.Name = "btn_CancelAcompanhante";
            this.btn_CancelAcompanhante.Size = new System.Drawing.Size(80, 20);
            this.btn_CancelAcompanhante.TabIndex = 3;
            this.btn_CancelAcompanhante.Text = "Cancelar";
            this.btn_CancelAcompanhante.UseVisualStyleBackColor = true;
            this.btn_CancelAcompanhante.Click += new System.EventHandler(this.BTN_CancelAcompanhante_Click);
            // 
            // Form_EditarAcompanhante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 116);
            this.Controls.Add(this.btn_CancelAcompanhante);
            this.Controls.Add(this.btn_EditarAcompanhante);
            this.Controls.Add(this.tb_EditarAcompanhante);
            this.Controls.Add(this.lb_EditarAcompanhante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_EditarAcompanhante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Acompanhante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_EditarAcompanhante_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_EditarAcompanhante;
        private System.Windows.Forms.TextBox tb_EditarAcompanhante;
        private System.Windows.Forms.Button btn_EditarAcompanhante;
        private System.Windows.Forms.Button btn_CancelAcompanhante;
    }
}