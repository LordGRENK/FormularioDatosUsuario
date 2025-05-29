using System.Windows.Forms;

namespace FormularioDatosUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbCiudad_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Edad_Click(object sender, EventArgs e)
        {

        }

        private void gpSexo_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cbTerminosyCondiciones.Checked)
                {
                    MessageBox.Show("Debe aceptar los términos y condiciones para continuar. ");
                    return;
                }
                
                var nombre = tbNombre.Text;
                var edad = NumUpDOwnEdad.Value;
                var sexo = rbMasculino.Checked ? "Masculino" : "Femenino";
                var ciudad = cbCiudad.SelectedItem?.ToString() ?? "No seleccionado";
                var error = "";
                var mostrar = true;
                if (nombre == string.Empty)
                {
                    error += "El nombre no puede estar vacío. \n \r";
                    mostrar = false;

                }
                if (edad == 0)
                {
                    error += "La edad no puede ser cero.\n \r";
                    mostrar = false;

                }
                if (!rbMasculino.Checked && !rbFemenino.Checked)
                {
                    error += "Porfavor seleccione un sexo. \n \r";
                    mostrar = false;


                }
                if (ciudad == "No seleccionado")
                {
                    error += "Debe seleccionar una ciudad.";
                    mostrar = false;
                }
                if (!mostrar)
                {
                    MessageBox.Show(error);
                    return;
                }else { 
                    string mensaje = $"Nombre: {nombre}\nEdad: {edad}\nSexo: {sexo}\nCiudad: {ciudad}";
                MessageBox.Show(mensaje, "Datos ingresados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }
    }
}
