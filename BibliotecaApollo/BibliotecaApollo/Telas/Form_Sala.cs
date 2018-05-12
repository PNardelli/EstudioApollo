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
    }
}
