﻿namespace Agenda
{
    partial class frmInserirEditar
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_gravar = new System.Windows.Forms.Button();
            this.lista_contatos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_numero_registros = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(64, 12);
            this.text_nome.MaxLength = 50;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(304, 20);
            this.text_nome.TabIndex = 0;
            // 
            // text_numero
            // 
            this.text_numero.Location = new System.Drawing.Point(64, 38);
            this.text_numero.MaxLength = 20;
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(182, 20);
            this.text_numero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmd_gravar
            // 
            this.cmd_gravar.Location = new System.Drawing.Point(64, 64);
            this.cmd_gravar.Name = "cmd_gravar";
            this.cmd_gravar.Size = new System.Drawing.Size(75, 23);
            this.cmd_gravar.TabIndex = 2;
            this.cmd_gravar.Text = "Gravar";
            this.cmd_gravar.UseVisualStyleBackColor = true;
            this.cmd_gravar.Click += new System.EventHandler(this.cmd_gravar_Click);
            // 
            // lista_contatos
            // 
            this.lista_contatos.FormattingEnabled = true;
            this.lista_contatos.Location = new System.Drawing.Point(16, 146);
            this.lista_contatos.Name = "lista_contatos";
            this.lista_contatos.Size = new System.Drawing.Size(428, 264);
            this.lista_contatos.TabIndex = 9;
            this.lista_contatos.SelectedIndexChanged += new System.EventHandler(this.lista_contatos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lista de contatos registrados:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_numero_registros
            // 
            this.label_numero_registros.Location = new System.Drawing.Point(12, 416);
            this.label_numero_registros.Name = "label_numero_registros";
            this.label_numero_registros.Size = new System.Drawing.Size(134, 23);
            this.label_numero_registros.TabIndex = 10;
            this.label_numero_registros.Text = "Registros: 0";
            this.label_numero_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.Location = new System.Drawing.Point(288, 416);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(75, 23);
            this.cmd_apagar.TabIndex = 4;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = true;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.Location = new System.Drawing.Point(207, 416);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(75, 23);
            this.cmd_editar.TabIndex = 5;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = true;
            // 
            // frmInserirEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 466);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.label_numero_registros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lista_contatos);
            this.Controls.Add(this.cmd_gravar);
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInserirEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA - INSERIR / EDITAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.ListBox lista_contatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_numero_registros;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
    }
}