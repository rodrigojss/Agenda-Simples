using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Agenda
{
    class cl_geral
    {
        public static string versao = "v 1.0.0";

        //Lista de contatos
        //A lista do tipo <cl_contato> foi criada, mas não inicializada
        public static List<cl_contato> LISTA_CONTATO;

 //==========================================================================================
        public static void ControiListaContatos()
        {
            //Lista inicializada
            LISTA_CONTATO = new List<cl_contato>();

            //Metodo para carregamento da lista de contatos

            //Verificar se o ficheiro existe
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\Ficheiro_contatos.txt";
            
            if (File.Exists(nome_ficheiro))
            {
                //Será preciso criar o ficheiro
                 
            //Criado um objeto do tipo SreamReader
                StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
               while (!ficheiro.EndOfStream) //Esse comando diz, enquanto a linha do 
                                              //ficheiro não tiver chegado ao fim.                  
                {
                    //Carrega nome
                    string nome = ficheiro.ReadLine();

                    //Carrega numero
                    string numero = ficheiro.ReadLine();

                    
                    //Adicionar a linha de contatos o contato carregado
                    cl_contato novo_contato = new cl_contato();
                    novo_contato.nome = nome;
                    novo_contato.numero = numero;
                    LISTA_CONTATO.Add(novo_contato);
                }

                ficheiro.Dispose();
            }


        }

//==========================================================================================

        public static void GravarFicheiro()
        {
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\Ficheiro_contatos.txt";

            StreamWriter ficheiro = new StreamWriter(nome_ficheiro, false, Encoding.Default);
            foreach (cl_contato contato in LISTA_CONTATO)
            {
                ficheiro.WriteLine(contato.nome);
                ficheiro.WriteLine(contato.numero);
            }


            ficheiro.Dispose();

        }

//=========================================================================================

        public static void gravarNovoRegistro(string _nome, string _numero)
        {
            //Vai gravar um novo registro na lista e no ficheiro

            //cl_contato novo = new cl_contato();
            //novo.nome = _nome;
            //novo.numero = _numero;
            //LISTA_CONTATO.Add(novo);

            //Gravar na lista
            LISTA_CONTATO.Add(new cl_contato() { nome = _nome, numero = _numero });

            //Atualiza o ficheiro
            GravarFicheiro();
        }

       
    }
}
