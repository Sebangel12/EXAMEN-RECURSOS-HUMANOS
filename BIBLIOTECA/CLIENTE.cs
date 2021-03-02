using System;
using System.Collections.Generic;
using System.Text;

namespace BIBLIOTECA
{
    public  class CLIENTE : PERSONA 
    {
        public string CEDULA1;

        private string CATEGORIA;
        private string CODIGOPEDIDO;
        private string CEDULA;

        public string CATEGORIA1 
        { 
            get => CATEGORIA; 
            set => CATEGORIA = value; 
        }
        public string CODIGOPEDIDO1 
        { 
            get => CODIGOPEDIDO; 
            set => CODIGOPEDIDO = value;
        }
        public string CEDULA2 
        { 
            get => CEDULA; 
            set => CEDULA = value;
        }

        public void GENERARCODIGOPEDIDO ()
        {
            this.CODIGOPEDIDO1 = "C" + this.APPATERNO1.Substring(0, 3);
        }
    }

}
