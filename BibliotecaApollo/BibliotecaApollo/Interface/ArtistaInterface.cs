using BibliotecaApollo.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Interface
{
    interface ArtistaInterface
    {
        //Cadastrar um novo Artista.
        void InserirArtista(ArtistaBasica artista);

        //Deleta um Artista já cadastrado.
        void DeletarArtista(ArtistaBasica artista);

        //Altera um Artista já cadastrado.
        void AlterarArtista(ArtistaBasica artista);
    }
}
