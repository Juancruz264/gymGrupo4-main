using clasesGYM_;

namespace frontGYM_
{
    public partial class Inicio : Form
    {
        private readonly Administrador admin = new()
        {
            mail = "admin@gmail.com",
            contrase�a = "admin123"
        };

        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ingreso.Enabled = false;
        }

        private void Verificar()
        {
            bool emailValido = !string.IsNullOrWhiteSpace(Email.Text) && Email.Text == admin.mail;
            bool contrase�aValida = !string.IsNullOrWhiteSpace(Contrase�a.Text) && Contrase�a.Text == admin.contrase�a;
            Ingreso.Enabled = emailValido && contrase�aValida;
            if (!emailValido)
            {
                errorProvider1.SetError(Email, "Correo electr�nico inv�lido.");
            }
            else
            {
                errorProvider1.SetError(Email, string.Empty);
            }
            if (!contrase�aValida)
            {
                errorProvider1.SetError(Contrase�a, "Contrase�a inv�lida.");
            }
            else
            {
                errorProvider1.SetError(Contrase�a, string.Empty);
            }
        }
        private void Email_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void Contrase�a_TextChanged(object sender, EventArgs e)
        {
            Verificar();
        }

        private void Ingreso_Click(object sender, EventArgs e)
        {
            

        }

        private void Ingreso_Click_1(object sender, EventArgs e)
        {
            using (Menu menu = new Menu(Email.Text, Contrase�a.Text)) { menu.ShowDialog(); }
        }
    }
}
