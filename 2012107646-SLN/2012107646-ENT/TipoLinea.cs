﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public  class TipoLinea
    {
        public int TipoLineaId { get; set; }
        public string Name { get; set; }
        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }


        public TipoLinea(string descripcion)
        {
            Descripcion = descripcion;
        }

        public TipoLinea()
        {
            Descripcion = "";
        }
    }
}
