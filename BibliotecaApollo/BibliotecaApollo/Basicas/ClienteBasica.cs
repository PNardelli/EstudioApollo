using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Basicas
{
    class ClienteBasica
    {
        private string texto;
        private int telefone;
        private string email;
        private int codCli;

        public string Texto
        {
            get
            {
                return texto;
            }

            set
            {
                texto = value;
            }
        }


        public int Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }


        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }


        public int CodCli
        {
            get
            {
                return codCli;
            }

            set
            {
                codCli = value;
            }
        }
    }
}
