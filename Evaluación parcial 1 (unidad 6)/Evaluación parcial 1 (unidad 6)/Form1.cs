using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluación_parcial_1__unidad_6_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TB_CONTRA.Text = null;
            TB_CORREO.Text = null;
            L_alerta.Text = null;
        }

        private void BTN_REG_Click(object sender, EventArgs e)
        {
            TB_CONTRA.Text = null;
            TB_CORREO.Text = null;
            L_alerta.Text = null;
            REGISTRO reg = new REGISTRO();
            reg.Show();
            this.Hide();
        }

        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {

            string usuario = TB_CORREO.Text;
            string contraseña = TB_CONTRA.Text;

            // Asegúrate de reemplazar la cadena de conexión con los valores adecuados
            string connectionString = "Server=ANGEL\\SQLEXPRESS;Database=EV_6;Integrated Security=True;";

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                L_alerta.Text = "Por favor, ingresa un nombre de usuario y contraseña.";
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Consulta SQL para verificar si el usuario existe y si la contraseña es correcta
                    string query = "SELECT COUNT(1) FROM Login.Usuario WHERE Correo = @Usuario AND Contrasena = @Contraseña";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);  // En un sistema real, la contraseña debe estar hasheada

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        this.Hide();
                        VPrincipal vPrincipal = new VPrincipal();   
                        vPrincipal.Show();
                        
                    }
                    else
                    {
                        L_alerta.Text = "Usuario o contraseña incorrectos.";
                    }
                }
                catch (Exception ex)
                {
                    L_alerta.Text = "Error: " + ex.Message;
                }

            }
            TB_CONTRA.Text = null;
            TB_CORREO.Text = null;
            L_alerta.Text = null;
        }
    }
}
