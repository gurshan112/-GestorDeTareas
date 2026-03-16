using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GestorTareasGUI1.Class1;


namespace GestorTareasGUI1
{

    public partial class Form1 : Form
    {
        List<Tarea> tareas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();
   

            cmbCategoria.Items.Add("Trabajo");
            cmbCategoria.Items.Add("Personal");
            cmbCategoria.Items.Add("Estudios");
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstTareas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Tarea t = new Tarea()
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Fecha = dtFecha.Value,
                Completada = false
            };

            tareas.Add(t);
            lstTareas.Items.Add(t);
            ActualizarContador();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                tareas.Remove((Tarea)lstTareas.SelectedItem);
                lstTareas.Items.Remove(lstTareas.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecciona una tarea primero");
            }
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                Tarea t = (Tarea)lstTareas.SelectedItem;
                t.Completada = true;

                int index = lstTareas.SelectedIndex;
                lstTareas.Items[index] = t; // Actualiza el ListBox
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblContadorTareas_Click(object sender, EventArgs e)
        {
           
        }
        void ActualizarContador()
        {
            lblContadorTareas.Text = "Total tareas: " + tareas.Count;
        }

       
            private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            cmbCategoria.SelectedIndex = -1;
            chkPrioridadAlta.Checked = false;
        }
    }
    }

