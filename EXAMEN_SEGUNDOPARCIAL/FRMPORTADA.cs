using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMEN_SEGUNDOPARCIAL
{
    public partial class PORTADA : Form
    {
        public PORTADA()
        {
            InitializeComponent();
        }

        public static void Main ()
        {
            EXAMEN_SEGUNDOPARCIAL.PORTADA INICIO = new EXAMEN_SEGUNDOPARCIAL.PORTADA();
                INICIO.ShowDialog();
        }
             
        private void BTNCLIENTE_Click(object sender, EventArgs e)
        {
            EXAMEN_SEGUNDOPARCIAL.FRMCLIENTE CLIENTE = new EXAMEN_SEGUNDOPARCIAL.FRMCLIENTE();
            CLIENTE.Show();
        }

        private void BTNEMPLEADO_Click(object sender, EventArgs e)
        {
            EXAMEN_SEGUNDOPARCIAL.FRMEMPLEADO EMPLEADO = new EXAMEN_SEGUNDOPARCIAL.FRMEMPLEADO();
            EMPLEADO.Show();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
