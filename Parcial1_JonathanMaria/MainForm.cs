﻿using Parcial1_JonathanMaria.UI.Consultas;
using Parcial1_JonathanMaria.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_JonathanMaria
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RProductos Rp = new RProductos();
            Rp.Show();
        }

        private void ValorDelInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CValorTotalInventario Cv = new CValorTotalInventario();
            Cv.Show();
        }
    }
}