
using System.Drawing;
using System.Windows.Forms;

namespace ClinicaCompleta
{
    public class PerfilPacienteForm : Form
    {
        public PerfilPacienteForm()
        {
            Text = "Perfil del Paciente";
            Size = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;

            Label titulo = new Label();
            titulo.Text = "Perfil de Paciente";
            titulo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            titulo.Location = new Point(40, 30);
            titulo.AutoSize = true;

            Label nombre = new Label();
            nombre.Text = "Nombre: Ismenia Mendez";
            nombre.Location = new Point(50, 120);
            nombre.Font = new Font("Segoe UI", 12);

            Label edad = new Label();
            edad.Text = "Edad: 47 años";
            edad.Location = new Point(50, 170);
            edad.Font = new Font("Segoe UI", 12);

            Label doctor = new Label();
            doctor.Text = "Doctor: Dr. Morales";
            doctor.Location = new Point(50, 220);
            doctor.Font = new Font("Segoe UI", 12);

            Button cita = new Button();
            cita.Text = "Nueva cita";
            cita.Location = new Point(50, 300);
            cita.Size = new Size(150, 40);
            cita.BackColor = Color.Navy;
            cita.ForeColor = Color.White;

            Controls.Add(titulo);
            Controls.Add(nombre);
            Controls.Add(edad);
            Controls.Add(doctor);
            Controls.Add(cita);
        }
    }
}
