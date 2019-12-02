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

        dist P1 = new dist();
        dist P2 = new dist();

        private void Button1_Click(object sender, EventArgs e)
        {
            P1.X = Convert.ToDouble(X1.Text);
            P1.Y = Convert.ToDouble(Y1.Text);
            P2.X = Convert.ToDouble(X1.Text);
            P2.Y = Convert.ToDouble(Y2.Text);
            label4.Text = (Math.Sqrt(Math.Pow(P2.X-P1.X,2)+ Math.Pow(P2.Y - P1.Y, 2))).ToString();
        }
    }
}
