namespace Talleres
    //Cesar San Miguel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Autor: Cesar San Miguel\n Curso: SOF-S-MA-5-2");
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            string nom = Txtnom.Text;
            string ape = Txtape.Text;
            string car = Txtcar.Text;
            if ((nom == "") || (ape == "") || (car == "") || (Txtced.Text == ""))
            {
                MessageBox.Show("Ingresar datos faltantes...");
            }
            else
            {
                int ced = Txtced.Text.Length;
                if ((ced == 10))
                {
                    DialogResult dr = MessageBox.Show(this, "Desea agregar estos datos?", "Sistema de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        AgregarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Cedula no valida...");
                }
            }
        }

        public void AgregarDatos()
        {
            Estudiante objEstudiante = new Estudiante();
            objEstudiante.Cedula = Int32.Parse(Txtced.Text);
            objEstudiante.Nombre = Txtnom.Text.Trim();
            objEstudiante.Apellido = Txtape.Text.Trim();
            objEstudiante.Carrera = Txtcar.Text.Trim();

            ListViewItem itemAlumno = new ListViewItem();
            itemAlumno = listView.Items.Add(objEstudiante.Cedula.ToString());
            itemAlumno.SubItems.Add(objEstudiante.Nombre);
            itemAlumno.SubItems.Add(objEstudiante.Apellido);
            itemAlumno.SubItems.Add(objEstudiante.Carrera);

        }

        private void Txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras...");
                e.Handled = true;
                return;
            }
        }

        private void Txtape_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras...");
                e.Handled = true;
                return;
            }
        }

        private void txtcar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras...");
                e.Handled = true;
                return;
            }
        }

        private void Txtced_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros...");
                e.Handled = true;
                return;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
