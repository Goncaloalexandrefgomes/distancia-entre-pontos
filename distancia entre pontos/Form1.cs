﻿using System;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            distancia.PontoX1 = X1.Text;
            distancia.PontoX2 = X2.Text;
            distancia.PontoY1 = Y1.Text;
            distancia.PontoY2 = Y2.Text;
            label4.Text = distancia.Pontos;
        }
    }
}
