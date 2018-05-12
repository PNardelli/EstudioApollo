using BibliotecaApollo.Basicas;
using BibliotecaApollo.Fachada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApollo.Telas
{
    public partial class Form_Sala : Form
    {
        public Form_Sala()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            textBoxValor.Clear();
            richTextBoxDescricao.Clear();
            textBoxNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Chamando nova fachada da Sala.
            SalaFachada fachada = new SalaFachada();
            
            //Criando nova sala.
            SalaBasica sala = new SalaBasica();
            //Passando atributos recebidos do usuario.
            sala.Sal_nome = textBoxNome.Text;
            sala.Sal_valor = Convert.ToDouble(textBoxValor.Text);
            sala.Sal_descricao = richTextBoxDescricao.Text;

            //Validando a Sala.
            fachada.validarSala(sala);


        }
    }
}
