
using System.Drawing;
using System.Windows.Forms;

namespace ClinicaCompleta
{
    public class DashboardForm : Form
    {
        public DashboardForm()
        {
            Text = "Pantalla Principal";
            WindowState = FormWindowState.Maximized;
            BackColor = Color.White;

            Panel menu = new Panel();
            menu.Dock = DockStyle.Left;
            menu.Width = 200;
            menu.BackColor = Color.FromArgb(20, 40, 90);

            Button inicio = new Button();
            inicio.Text = "Inicio";
            inicio.Location = new Point(20, 80);
            inicio.Size = new Size(150, 40);

            Button perfil = new Button();
            perfil.Text = "Perfil Paciente";
            perfil.Location = new Point(20, 140);
            perfil.Size = new Size(150, 40);

            perfil.Click += (s, e) =>
            {
                PerfilPacienteForm p = new PerfilPacienteForm();
                p.Show();
            };

            Label bienvenido = new Label();
            bienvenido.Text = "Bienvenido Administrador";
            bienvenido.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            bienvenido.Location = new Point(240, 50);
            bienvenido.AutoSize = true;

            menu.Controls.Add(inicio);
            menu.Controls.Add(perfil);

            Controls.Add(menu);
            Controls.Add(bienvenido);
        }
    }
}
