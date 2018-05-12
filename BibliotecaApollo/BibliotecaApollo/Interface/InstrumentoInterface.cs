using BibliotecaApollo.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Interface
{
    interface InstrumentoInterface
    {
        //Cadastrar um novo instrumento.
        void InserirInstrumento(InstrumentoBasica instrumento);

        //Deletar um instrumento ja cadastrado.
        void DeletarInstrumento(InstrumentoBasica instrumento);

        //Alterar um instrumento cadastrado.
        void AlterarInstrumento(InstrumentoBasica instrumento);
    }
}
