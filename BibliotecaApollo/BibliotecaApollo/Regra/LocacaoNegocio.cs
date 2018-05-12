,using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Regra
{
    class LocacaoNegocio
    {
        private DateTime vencimento;
        private DateTime pagamento;
        private int codLocacao;

        public DateTime Vencimento
        {
            get
            {
                return vencimento;
            }

            set
            {
                vencimento = value;
            }
        }

        public DateTime Pagamento
        {
            get
            {
                return pagamento;
            }

            set
            {
                pagamento = value;
            }
        }


        public DateTime CodLocacao
        {
            get
            {
                return codLocacao;
            }

            set
            {
                codLocacao = value;
            }
        }
    }
}
