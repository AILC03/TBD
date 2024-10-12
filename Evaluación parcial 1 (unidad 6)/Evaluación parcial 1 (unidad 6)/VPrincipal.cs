using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluación_parcial_1__unidad_6_
{
    public partial class VPrincipal : Form
    {
        public VPrincipal()
        {
            InitializeComponent();
        }

        private void B_REGRESAR_Click(object sender, EventArgs e)
        {
            Form1 LOGIN = new Form1();
            LOGIN.Show();
            this.Close();
        }
    }
}
