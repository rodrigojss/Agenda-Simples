namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_inserir = new System.Windows.Forms.Button();
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda ";
            // 
            // cmd_inserir
            // 
            this.cmd_inserir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmd_inserir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_inserir.Location = new System.Drawing.Point(109, 91);
            this.cmd_inserir.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_inserir.Name = "cmd_inserir";
            this.cmd_inserir.Size = new System.Drawing.Size(133, 35);
            this.cmd_inserir.TabIndex = 1;
            this.cmd_inserir.Text = "Inserir/Editar";
            this.cmd_inserir.UseVisualStyleBackColor = true;
            this.cmd_inserir.Click += new System.EventHandler(this.cmd_inserir_Click);
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Location = new System.Drawing.Point(109, 139);
            this.cmd_pesquisar.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(133, 36);
            this.cmd_pesquisar.TabIndex = 2;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(109, 185);
            this.cmd_sair.Margin = new System.Windows.Forms.Padding(2);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(133, 36);
            this.cmd_sair.TabIndex = 3;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // label_versao
            // 
            this.label_versao.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_versao.Location = new System.Drawing.Point(12, 413);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(321, 15);
            this.label_versao.TabIndex = 4;
            this.label_versao.Text = "Apresenta versão do programa";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 437);
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.cmd_inserir);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_inserir;
        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Label label_versao;
    }
}

