using BibliotecaApollo.Basicas;
using BibliotecaApollo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApollo.Fachada
{
    class SalaFachada
    {
        public void validarSala(SalaBasica sala)
        {
            if (sala.Sal_nome.Length == 0 || sala.Sal_valor == 0)
            {
                MessageBox.Show("Preencher Campos");
            }

            else
            {
                try
                {
                    SalaDAO salaChamada = new SalaDAO();
                    salaChamada.InserirSala(sala);
                }
                catch (Exception ex)
                {

                    throw ex = new Exception("Erro ao Cadastrar Sala");
                }
                
            }
            
        }

    }
}
