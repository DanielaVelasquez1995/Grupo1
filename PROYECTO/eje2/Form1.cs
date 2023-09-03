using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Autores: Alvarado Méndez Oscar Eduardo - am22043
        ///          Martínez Hernández Wendy Beatriz - mh22052
        ///          Orellana Velasquez Daniela Estefany - ov22002
        ///          Ventura Munguia Daniel Enrique - vm23024
        /// Grupo 1
        /// Hora:2:30 p.m
        /// Dia:28/08/2023
        /// Problema:cree un formulario que solicite el nombre de un empleado y su sueldo y 
        /// que calcule su Impuesto Sobre la Renta (ISR) .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //Declaracion de variables y asignacion de valores
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sueldo = Double.Parse(txtSueldo.Text);
            double renta;
            txtRenta.Text = "";

            //Evaluacion de renta
            if (sueldo <= 325)
            {
                renta = 0;
            }
            else if (sueldo <= 700)
            {
                renta = sueldo * 0.15;
            }
            else if (sueldo <= 1100)
            {
                renta = sueldo * 0.21;
            }
            else if (sueldo <= 2000)
            {
                renta = sueldo * 0.25;
            }
            else if (sueldo <= 2900)
            {
                renta = sueldo * 0.29;
            }
            else
            {
                renta = sueldo * 0.29;
            }

         //Mensaje del total a pagar de renta
         txtRenta.Text = renta.ToString();
         MessageBox.Show("Total a pagar Renta: " + renta, "Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Boton De Limpieza para los textboxs del formulario
        private void btnlimpiar_Click(object sender, EventArgs e)
        { 
            txtEmpleado.Text = "";
            txtSueldo.Text = "";
            txtRenta.Text = "";
        }
          
        //Validar la caja de texto Empleado
        private void txtEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }

        }

        //Validar la caja de texto Sueldo
        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }

        }

        //Boton de salida
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierre del formulario
            this.Close();
        }
    }
}
 //Hola como estas
// Muy bien
