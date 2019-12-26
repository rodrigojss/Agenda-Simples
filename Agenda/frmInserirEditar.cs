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
    public partial class frmInserirEditar : Form
    {

        int indice;
//=========================================================================================

        public frmInserirEditar()
        {
            InitializeComponent();
            constroiLista();
        }
//=========================================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
//========================================================================================
        private void constroiLista()
        {
            //Adiciona a lista de contatos, os contatos registrados
            lista_contatos.Items.Clear();
            foreach (cl_contato contato in cl_geral.LISTA_CONTATO)
            {
                lista_contatos.Items.Add(contato.nome + " (" + contato.numero + ")");
            }

            //Atualizar o numero de registros
            label_numero_registros.Text = "Registros:" + lista_contatos.Items.Count;

            //Impedir eliminação e edição do registro

            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;

        }
//=========================================================================================
        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            //Insere um novo comando na lista

            //Verifica se todos os campos estão preenchidos

            if (text_nome.Text == "" || text_numero.Text == "")
            {
                MessageBox.Show("Os campos não estão preenchidos");
                return;
            }

            //Verifica se existe registro duplicado

            foreach (cl_contato contato in cl_geral.LISTA_CONTATO)
            {
                if (contato.nome == text_nome.Text &&
                     contato.numero == text_numero.Text)
                {
                    MessageBox.Show("ERRO! - REGISTRO JÁ EXISTENTE");
                    return;
                }
                }

            //Gravar novo registro

            cl_geral.gravarNovoRegistro(text_nome.Text, text_numero.Text);

            //Atualizar a lista de contatos

            constroiLista();

            //Prepara o quadro para novo registro

            text_nome.Text = "";
            text_numero.Text = "";
            text_nome.Focus();
        }
//=====================================================================================
        private void lista_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Selecionar um contato

            //verificar se indice = -1

            if (lista_contatos.SelectedIndex == -1) { return; }

            //pode ser usado o else ou o int indice = lista_contatos.SelectedIndex;
            //Dara o mesmo resultado
            //else
                //seleciona um indice da lista
                 indice = lista_contatos.SelectedIndex;
                cmd_editar.Enabled = true;
            cmd_apagar.Enabled = true;
        }
//====================================================================================
        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //Apaga o registro selecionado
            //1º Eliminar o registro da lista
            cl_geral.LISTA_CONTATO.RemoveAt(indice);



            //2º renovar o ficheiro
            cl_geral.GravarFicheiro();

            //3º reconstruir a lista de contatos
            constroiLista();
        }
    }
}
