namespace ProjetoDocx
{
    partial class AbrirDocumento
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
            this.btnAbrirDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirDoc
            // 
            this.btnAbrirDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirDoc.Location = new System.Drawing.Point(277, 15);
            this.btnAbrirDoc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAbrirDoc.Name = "btnAbrirDoc";
            this.btnAbrirDoc.Size = new System.Drawing.Size(352, 96);
            this.btnAbrirDoc.TabIndex = 0;
            this.btnAbrirDoc.Text = "Abrir Documento";
            this.btnAbrirDoc.UseVisualStyleBackColor = true;
            this.btnAbrirDoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // AbrirDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 481);
            this.Controls.Add(this.btnAbrirDoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AbrirDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbrirDocumento";
            this.Load += new System.EventHandler(this.AbrirDocumento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirDoc;
    }
}