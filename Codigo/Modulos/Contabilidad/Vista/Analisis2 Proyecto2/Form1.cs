﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis2_Proyecto2
{
    public partial class ContenedorCF : MetroFramework.Forms.MetroForm
    {
        public ContenedorCF()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiscales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fiscales fiscales = new Fiscales();
            fiscales.Show();
        }
    }
}
