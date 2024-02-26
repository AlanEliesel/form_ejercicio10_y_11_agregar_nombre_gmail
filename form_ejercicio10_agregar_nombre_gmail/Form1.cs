using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_ejercicio10_agregar_nombre_gmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           

            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar el programa?",
            "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            string nombre, gmail;


            
            nombre = txt_nombre.Text;

            gmail = txt_correo.Text;



            if(nombre == ""  || gmail == "")
            {

                MessageBox.Show("!Debe llenar los campos!", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_nombre.Focus();

            }
            else
            {
                dgv_Datos.Rows.Add(nombre, gmail);
                txt_correo.Text = string.Empty;
                txt_nombre.Text = string.Empty;

                txt_nombre.Focus();
            }



        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            if (dgv_Datos.Rows.Count == 0)
            {

                MessageBox.Show("!no hay datos para eliminar!", "Tabla vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el registro?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int indice = dgv_Datos.CurrentRow.Index;
                    dgv_Datos.Rows.RemoveAt(indice);
                }

            }

            
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

            txt_correo.Text = string.Empty;
            txt_nombre.Text = string.Empty;

            dgv_Datos.Rows.Clear();


            txt_nombre.Focus();
        }

        private void dgv_Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
