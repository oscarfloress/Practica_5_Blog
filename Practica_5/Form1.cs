using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendarCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            this.almacenarDatos();
        }

        private void almacenarDatos()
        {
            Entradas entrada = new Entradas();
            string fecha;
            string autor;
            string titulo;
            string cuerpo;
            fecha = obtenerFecha();
            autor = textBoxAutor.Text.Trim();
            titulo = textBoxTitulo.Text.Trim();
            cuerpo = richTextBoxCuerpo.Text.Trim();
            if (autor.Length > 0 && titulo.Length > 0 && cuerpo.Length > 0)
            {
                entrada.insertarRegistroNuevo(fecha, autor, titulo, cuerpo);
                MessageBox.Show("Registro almacenado");
                this.limpiarComponentes();
            }
            else
                MessageBox.Show("Faltan datos");
        }

        private string obtenerFecha()
        {
            string anyo;
            string mes;
            string dia;
            anyo = monthCalendarCalendario.SelectionEnd.Year.ToString();
            mes = monthCalendarCalendario.SelectionEnd.Month.ToString();
            dia = monthCalendarCalendario.SelectionEnd.Day.ToString();
            return anyo + "-" + mes + "-" + dia;
        }

        private void limpiarComponentes()
        {
            monthCalendarCalendario.SelectionStart = monthCalendarCalendario.TodayDate;
            textBoxAutor.Text = "";
            textBoxTitulo.Text = "";
            richTextBoxCuerpo.Text = "";
        }
    }
}
