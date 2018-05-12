-using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Basicas
{
    public class InstrumentoBasica
    {
        private int codInstrumento;
        private int valor;
        private string nome;

        public int CodInstrumento
        {
            get
            {
                return codInstrumento;
            }

            set
            {
                codInstrumento = value;
            }
        }

        public int Valor
        {
            get
            {
                return Valor;
            }

            set
            {
                Valor = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

    }
}
