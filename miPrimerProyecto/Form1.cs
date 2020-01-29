using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimerProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            sbyte num1 = sbyte.Parse(txtnum1.Text);
            sbyte num2 = sbyte.Parse(txtnum2.Text);
            lblrespuesta.Text = "Respuesta: " + (num1 + num2);
        }
    }
}
