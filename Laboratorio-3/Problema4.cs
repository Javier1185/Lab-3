using System;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class Problema4 : Form
    {


        public Problema4()
        {
            InitializeComponent();

          
            password.Validating += password_Validating;
            password.KeyPress += password_KeyPress;
            password.KeyDown += password_KeyDown;
            password.KeyUp += password_KeyUp;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string nombre = name.Text.Trim();
            string apellido = lastName.Text.Trim();
            string correo = correo1.Text.Trim();
            string contraseña = password.Text;
            string mensaje;

           
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                mensaje = "Por favor ingrese su nombre y apellido.";
            }
            else
            {
              
                int arrobas = 0;
                foreach (char c in correo)
                {
                    if (c == '@') arrobas++;
                }
                bool tieneArroba = arrobas == 1;
                int posicionArroba = correo.IndexOf('@');
                bool tieneAntes = posicionArroba > 0;
                bool terminacionValida =
                    correo.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) ||
                    correo.EndsWith("@hotmail.com", StringComparison.OrdinalIgnoreCase) ||
                    correo.EndsWith("@utp.ac.pa", StringComparison.OrdinalIgnoreCase);

                if (tieneArroba && tieneAntes && terminacionValida)
                {
                    bool largoValido = contraseña.Length >= 12;
                    bool tieneMayuscula = contraseña.Any(char.IsUpper);
                    bool tieneDigito = contraseña.Any(char.IsDigit);
                    bool tieneEspecial = contraseña.Any(ch => "!@#$%^&*".Contains(ch));

                    if (largoValido && tieneMayuscula && tieneDigito && tieneEspecial)
                    {
                        mensaje = $"Bienvenido {nombre} {apellido}";
                    }
                    else
                    {
                        mensaje = "La contraseña NO es válida.\n\n" +
                            "Criterios:\n" +
                            "- Al menos 12 caracteres\n" +
                            "- Al menos una mayúscula\n" +
                            "- Al menos un dígito\n" +
                            "- Al menos un carácter especial (!, @, #, $, %, ^, &, *)";
                    }
                }
                else
                {
                    mensaje = "El correo electrónico NO es válido.\n\n" +
                        "Criterios:\n" +
                        "- Solo un carácter '@'\n" +
                        "- Al menos un carácter antes del '@'\n" +
                        "- Terminación: @gmail.com, @hotmail.com, @utp.ac.pa";
                }
            }

            MessageBox.Show(mensaje, "Validación de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0)
            {
                string valor = ((TextBox)sender).Text;
                string error = "";

                if (valor.Length < 12)
                    error += "- Al menos 12 caracteres\n";
                if (!valor.Any(char.IsUpper))
                    error += "- Al menos una mayúscula\n";
                if (!valor.Any(char.IsDigit))
                    error += "- Al menos un dígito\n";
                if (!valor.Any(ch => "!@#$%^&*".Contains(ch)))
                    error += "- Al menos un carácter especial (!, @, #, $, %, ^, &, *)\n";

                if (error.Length > 0)
                    this.erpError.SetError((Control)sender, "Criterios:\n" + error);
                else
                    this.erpError.SetError((Control)sender, "");
            }
            else
            {
                this.erpError.SetError((Control)sender, "No puede dejar el campo en blanco");
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                MessageBox.Show("Frase secreta: ¡La seguridad es lo primero!", "Secreto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                password.Text = "Digite la clave";
            }
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || "!@#$%^&*".Contains(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void password_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
