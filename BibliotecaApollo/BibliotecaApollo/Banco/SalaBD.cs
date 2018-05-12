using BibliotecaApollo.Basicas;
using BibliotecaApollo.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Banco
{
    class SalaBD : ConexaoSqlServer
    {
        public void InserirSalaNoBanco(SalaBasica sala)
        {
            try
            {
                //abrir a conexao com o Banco de Dados
                this.abrirConexao();

                string sql = "insert into sala (sal_valor, sal_nome, sal_descricao) ";
                sql += "values(@sal_valor, @sal_nome,@sal_descricao)";

                //Instrucao a ser executada no banco de dados.
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                //Substituindo as strings pelo valor recebido do usuario.
                cmd.Parameters.Add("@sal_valor", SqlDbType.Decimal);
                cmd.Parameters["@sal_valor"].Value = sala.Sal_valor;

                cmd.Parameters.Add("@sal_nome", SqlDbType.VarChar);
                cmd.Parameters["@sal_nome"].Value = sala.Sal_nome;

                cmd.Parameters.Add("@sal_descricao", SqlDbType.Text);
                cmd.Parameters["@sal_descricao"].Value = sala.Sal_descricao;

                //Executando instruçoes ao Banco.
                cmd.ExecuteNonQuery();
                //Liberando memoria.
                cmd.Dispose();
                //Fechando conexao com o banco.
                this.fecharConexao();.

            }
            catch (Exception ex)
            {

                throw ex = new Exception("Erro ao Cadastrar una Sala.");
            }
        }
    }
}
