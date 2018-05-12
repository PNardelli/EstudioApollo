using BibliotecaApollo.Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Interface
{
    /// Implementaçao do Horario.
    
    interface HorarioInterface
    {
        //Cadastrar um novo horario.
        void InserirHorario(HorarioBase horario);

        //Deleta um horario já cadastrado.
        void DeletarHorario(HorarioBase horario);

        //Altera um horario já cadastrado.
        void AlterarHorario(HorarioBase horario);

    }
}
