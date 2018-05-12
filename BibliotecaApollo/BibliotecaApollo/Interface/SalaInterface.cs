using BibliotecaApollo.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Interface
{
    //Implementaçao da Sala.
    interface SalaInterface
    {   
        //Inserir uma nova sala.
        void InserirSala(SalaBasica sala);

        //Deletar uma sala existente.
        void DeletarSala(SalaBasica sala);

        //Alterar uma sala existente.
        void AlterarSala(SalaBasica sala);
    }
}
