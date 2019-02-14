﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace UI
{
    public partial class FormularioContribucion : Form
    {
        public static string idPrestamo = "";
        public static string contratoPrestamo = "";

        public FormularioContribucion()
        {
            InitializeComponent();
            lblContrato.Text = contratoPrestamo;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string recibo = txtRecibo.Text;
            string cuota = txtCuota.Text;
            DateTime fecha = Convert.ToDateTime(dtFecha.Text);
            BLContribucion nuevaContribucion = new BLContribucion(recibo, cuota, fecha, Convert.ToInt32(idPrestamo));
            ManejadorContribucion manejCont = new ManejadorContribucion();
            if (manejCont.agregarContribucion(nuevaContribucion))
            {
                this.Owner.Dispose();
                this.Dispose();
                MessageBox.Show("Se ha guardado la contribución");
                new CuotasDonacion().Show();
            } else
            {
                MessageBox.Show("No se ha podido guardar la contribución. Intente de nuevo");
            }
        }

    }
}
