using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : System.Windows.Forms.Form
    {
//=======================================================================================
        public Form1()
        {
            
            InitializeComponent();
            label_versao.Text = cl_geral.versao;

            //Carrega os contatos
            cl_geral.ControiListaContatos();
        }
//=======================================================================================
        private void cmd_sair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair da aplicação","SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
                return;
            
            Application.Exit();
        }
//=======================================================================================
        private void cmd_inserir_Click(object sender, EventArgs e)
        {
            //Abre o quadro para gestao dos contatos
            frmInserirEditar formulario = new frmInserirEditar();
            formulario.ShowDialog();
        }
//=======================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {

        }
//=========================================================================================
        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {

            //Abrir o quadro de pesquisa
            frm_texto f = new frm_texto();
            f.ShowDialog();

            //quando fechar o quadro, verifica se foi cancelado
            if(f.cancelado)
               return;

            //Abrir o quadro com resultados da pesquisa

            frmResultados ff = new frmResultados(f.texto);
            ff.ShowDialog();

        }
    }
}
