﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApollo.Basicas
{
    public class TipoBasica
    {
        private int codTipo;
        private string nome;

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
