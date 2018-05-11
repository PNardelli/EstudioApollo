using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Basicas
{
    class HorarioBase
    {
        private string descricao;
        private string valor;

        public int CodTipo
        {
            get
            {
                return codTipo;
            }

            set
            {
                codTipo = value;
            }
        }

        public string Nome
        {
            get
            {
                return Nome;
            }

            set
            {
                Nome = value;
            }
        }
    }
}
