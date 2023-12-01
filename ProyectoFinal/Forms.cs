using ProyectoFinal.Logica;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Animal ani = new Animal();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int r,codigo, idHabitat = 0;
            string especie, nombre, tipo, habitat;
            char genero = 'M';
            codigo = int.Parse(txtCodigo.Text);
            especie = txtEspecie.Text;
            nombre = txtNombre.Text;
            tipo = cbxTipo.SelectedItem.ToString();
            habitat = cbxHabitat.SelectedItem.ToString();

            if (rbFemenino.Checked)
            {
                genero = 'F';
            }else if (rbMasculino.Checked) 
            { 
                genero = 'M'; 
            }

            if (habitat == "Africa")
            {
                idHabitat = 11;
            }
            if (habitat == "Asia")
            {
                idHabitat = 12;
            }
            if (habitat == "Acuario")
            {
                idHabitat = 13;
            }
            if (habitat == "America")
            {
                idHabitat = 14;
            }

            r = ani.ingresarAnimal(codigo, especie, nombre, tipo, idHabitat, genero);

            if (r > 0)
            {
                MessageBox.Show("Animal Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Animal NO Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();
            dsResultado = ani.consultarAnimales();
            dvgDatos.DataSource = dsResultado;
            dvgDatos.DataMember = "ResultadoDatos";
        }

        private void btnBuscarXId_Click(object sender, EventArgs e)
        {
            DataSet miDs = new DataSet();
            int id;
            id = int.Parse(txtBuscarXId.Text);
            miDs = ani.consultarAnimalXId(id);

            if (miDs.Tables[0].Rows.Count > 0)
            {
                lbResNombre.Text = miDs.Tables[0].Rows[0]["nombreAnimal"].ToString();
                lbResEspecie.Text = miDs.Tables[0].Rows[0]["nombreEspAnimal"].ToString();
                lbResGenero.Text = miDs.Tables[0].Rows[0]["generoAnimal"].ToString();
                lbResTipo.Text = miDs.Tables[0].Rows[0]["tipoAnimal"].ToString();
                lbResHabitat.Text = miDs.Tables[0].Rows[0]["nombreHabitat"].ToString();
            }
            else
            {
                MessageBox.Show("Persona no encontrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCronograma_Click(object sender, EventArgs e)
        {
            DataSet dsResultado = new DataSet();
            dsResultado = ani.consultarCronograma();
            dvgCronograma.DataSource = dsResultado;
            dvgCronograma.DataMember = "ResultadoDatos";
        }

        private void tpRegistro_Click(object sender, EventArgs e)
        {

        }
    }
}
