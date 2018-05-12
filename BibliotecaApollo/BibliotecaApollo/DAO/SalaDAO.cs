using BibliotecaApollo.Banco;
using BibliotecaApollo.Basicas;
using BibliotecaApollo.Conexao;
using BibliotecaApollo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.DAO
{
    class SalaDAO : ConexaoSqlServer, SalaInterface
    {
        public void AlterarSala(SalaBasica sala)
        {
            throw new NotImplementedException();
        }

        public void DeletarSala(SalaBasica sala)
        {
            throw new NotImplementedException();
        }

        public void InserirSala(SalaBasica sala)
        {
            try
            {
                //Criando uma nova sala.
                SalaBD InserirSala = new SalaBD();

                //Inserindo uma nova sala no Banco de Dados.
                InserirSala.InserirSalaNoBanco(sala);
            }
            catch (Exception ex)
            {

                throw (ex);
            }
            
        }

        
    }
}
