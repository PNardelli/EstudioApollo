using BibliotecaApollo.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Interface
{
    interface ClienteInterface
    {
        //Cadastrar um novo cliente.
        void InserirCliente(ClienteBasica cliente);

        //Deleta um cliente já cadastrado.
        void DeletarHorario(ClienteBasica cliente);

        //Altera um cliente já cadastrado.
        void AlterarHorario(ClienteBasica cliente);
    }
}
