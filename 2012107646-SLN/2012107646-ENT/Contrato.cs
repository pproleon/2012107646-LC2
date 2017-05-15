using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012107646_ENT
{
    public class Contrato
    {
        //Id que se usa para las relaciones en la base de datos 
        public int ContratoId { get; set; }

        //Numero de contrato de refiere al numero o letras que lleva cada contrato como documento en si 
        public string NroContrato { get; set; }

        //NO ESTOY TOMANDO EL CASO EN QUE EL "ID" QUE TENDRA EL CONTRATO EN LA TABLA SERA IGUAL AL "NUMERO" DE CONTRATO

    }
}
