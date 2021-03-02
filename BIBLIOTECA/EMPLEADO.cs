using System;
using System.Collections.Generic;
using System.Text;

namespace BIBLIOTECA
{
    public  class EMPLEADO : PERSONA
    {
        private string TIPODECONTRATO;
        private Double SUELDO;
        private string TIPO;
        private string CEDULA;

        public string TIPODECONTRATO1 { get => TIPODECONTRATO; set => TIPODECONTRATO = value; }
        public double SUELDO1 { get => SUELDO; set => SUELDO = value; }
        public string TIPO1 { get => TIPO; set => TIPO = value; }
        public string CEDULA1 { get => CEDULA; set => CEDULA = value; }
    
    public void CALCULARSUELDO(Double SUELDOBASICO)
        {
            if (this.TIPO1 == "GERENTE")
            {
                if (this.TIPODECONTRATO1 == "NUEVO")
                    SUELDO1 = 2 * SUELDOBASICO + 500;
                else if (this.TIPODECONTRATO1 == "LONGEVO")
                    SUELDO1 = 2 * SUELDOBASICO + 700;
            }
            else if (this.TIPO1 == "VENDEDOR")
            {
                if (this.TIPODECONTRATO1 == "NUEVO")
                    SUELDO1 = SUELDOBASICO + 500;
                else if (this.TIPODECONTRATO1 == "LONGEVO")
                    SUELDO1 = SUELDOBASICO + 700;
            }
            else
                this.SUELDO1 = 0;
        }
    }
        
}
