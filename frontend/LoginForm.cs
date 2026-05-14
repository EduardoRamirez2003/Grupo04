
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicaCompleta
{
    public class LoginForm : Form
    {
        public LoginForm()
        {
            Text = "Login Clínica";
            Size = new Size(400, 450);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;

            Label titulo = new Label();
            titulo.Text = "Clínica";
            titulo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            titulo.Location = new Point(130, 60);
            titulo.AutoSize = true;

            TextBox txtUser = new TextBox();
            txtUser.PlaceholderText = "Usuario";
            txtUser.Location = new Point(90, 150);
            txtUser.Size = new Size(220, 30);

            TextBox txtPass = new TextBox();
            txtPass.PlaceholderText = "Contraseña";
            txtPass.Location = new Point(90, 200);
            txtPass.Size = new Size(220, 30);

            Button btn = new Button();
            btn.Text = "Iniciar sesión";
            btn.BackColor = Color.RoyalBlue;
            btn.ForeColor = Color.White;
            btn.Location = new Point(90, 270);
            btn.Size = new Size(220, 40);

            btn.Click += (s, e) =>
            {
                DashboardForm d = new DashboardForm();
                d.Show();
                Hide();
            };

            Controls.Add(titulo);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(btn);
        }
    }
}
