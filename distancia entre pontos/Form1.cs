using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace distancia_entre_pontos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        dist distancia = new dist();

        dist P1 = new dist();
        dist P2 = new dist();

        private void Button1_Click(object sender, EventArgs e)
        {
            P1.X = Convert.ToDouble("X1.Text");
            P2.X = Convert.ToDouble("");
        }
    }
}
