﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class Trabajador
    {
        public int TrabajadorId { get; set; }
        public string Name { get; set; }
        private TipoTrabajador _TipoTrabajador;

        public Trabajador()
        {
            _TipoTrabajador = new TipoTrabajador();
        }
    }
}
