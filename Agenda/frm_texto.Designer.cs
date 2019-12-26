namespace Agenda
{
    partial class frm_texto
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
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Texto_texto = new System.Windows.Forms.TextBox();
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(31, 109);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(75, 23);
            this.cmd_cancelar.TabIndex = 2;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Termo de pesquisa:";
            // 
            // Texto_texto
            // 
            this.Texto_texto.Location = new System.Drawing.Point(31, 65);
            this.Texto_texto.MaxLength = 30;
            this.Texto_texto.Name = "Texto_texto";
            this.Texto_texto.Size = new System.Drawing.Size(206, 20);
            this.Texto_texto.TabIndex = 0;
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Location = new System.Drawing.Point(162, 109);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.cmd_pesquisar.TabIndex = 1;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // frm_texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 163);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.Texto_texto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_texto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PESQUISA";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_texto_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Texto_texto;
        private System.Windows.Forms.Button cmd_pesquisar;
    }
}