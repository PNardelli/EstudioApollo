using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Basicas
{
    public class SalaBasica
    {
        private int sal_cod;
        private double sal_valor;
        private String sal_nome;
        private String sal_descricao;

        public double Sal_valor { get => sal_valor; set => sal_valor = value; }
        public string Sal_nome { get => sal_nome; set => sal_nome = value; }
        public string Sal_descricao { get => sal_descricao; set => sal_descricao = value; }
        public int Sal_cod { get => sal_cod; set => sal_cod = value; }
    }
}
