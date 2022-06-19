namespace Talleres
    //Cesar San Miguel
{
    public partial class Form2 : Form
    {
        List<Estudiante> addes = new List<Estudiante>();
        List<Estudiante> elimes = new List<Estudiante>();
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

                        this.Txtced.Text = "";
                        this.Txtnom.Text = "";
                        this.Txtape.Text = "";
                        this.Txtcar.Text = "";
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
            addes.Add(objEstudiante);

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
            try
            {
                if (listView.SelectedItems.Count > 0)
                {
                    ListViewItem val = listView.SelectedItems[0];
                    DialogResult dr2 = MessageBox.Show(this, "Quiere eliminar este ingreso \n" + val.Text + " / " +
                        val.SubItems[1].Text + " / " + val.SubItems[2].Text + " / " + val.SubItems[3].Text,
                        "Sistema de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.Yes)
                    {
                        Geliminado(val.SubItems[0].Text, val.SubItems[1].Text, val.SubItems[2].Text,val.SubItems[3].Text);
                        deleteFromAddeds(val.SubItems[0].Text);
                        val.Remove();
                    }
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No existe elementos en este programa...");
                throw;
            }
        }

        public void deleteFromAddeds(String text)
        {
            int e = -1;
            foreach (Estudiante est in addes)
            {
                if (text.Equals(est.Cedula))
                {
                    e = addes.IndexOf(est);
                }
            }
            addes.Remove(addes[e]);
        }

        private void Geliminado(string text1, string text2, string text3, string text4)
        {
            Estudiante esteli = new Estudiante();
            esteli.Cedula = Int32.Parse(text1);
            esteli.Apellido = text2;
            esteli.Nombre = text3;
            esteli.Carrera = text4;
            elimes.Add(esteli);
        }

        private void Mnve_Click(object sender, EventArgs e)
        {
            vereliminado();
        }

        private void vereliminado()
        {
            listView.Items.Clear();
            foreach (Estudiante stdo2 in elimes)
            {
                ListViewItem itemEst = new ListViewItem();
                itemEst = listView.Items.Add(stdo2.Cedula.ToString());
                itemEst.SubItems.Add(stdo2.Apellido);
                itemEst.SubItems.Add(stdo2.Nombre);
                itemEst.SubItems.Add(stdo2.Carrera);
            }
        }

        private void Mnvg_Click(object sender, EventArgs e)
        {
            verguardados();
        }

        private void verguardados()
        {
            listView.Items.Clear();
            foreach (Estudiante stdo in addes)
            {
                ListViewItem itemEst = new ListViewItem();
                itemEst = listView.Items.Add(stdo.Cedula.ToString());
                itemEst.SubItems.Add(stdo.Apellido);
                itemEst.SubItems.Add(stdo.Nombre);
                itemEst.SubItems.Add(stdo.Carrera);
            }
        }
    }
}
