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
    public partial class REGISTRO : Form
    {
        public REGISTRO()
        {
            InitializeComponent();
        }

        private void BTN_REGIST_Click(object sender, EventArgs e)
        {
            string usuario = TB_CORREO.Text;
            string contraseña = TB_CONTRA.Text;

            // Asegúrate de reemplazar los valores en la cadena de conexión
            string connectionString = "Server=ANGEL\\SQLEXPRESS;Database=EV_6;Integrated Security=True;";


            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                L_Alerta.Text = "Por favor, ingresa un nombre de usuario y contraseña.";
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Consulta para insertar un nuevo usuario
                    string query = "INSERT INTO Login.Usuario (Correo, Contrasena) VALUES (@Usuario, @Contraseña)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);  // O aplicar un hash para mayor seguridad

                    int result = cmd.ExecuteNonQuery(); // Devuelve el número de filas afectadas

                    if (result > 0)
                    {
                        L_Alerta.Text = "Usuario registrado con éxito.";
                        // Limpiar los campos después de insertar
                        TB_CORREO.Clear();
                        TB_CONTRA.Clear();
                    }
                    else
                    {
                        L_Alerta.Text = "Hubo un error al registrar el usuario.";
                    }
                }
                catch (Exception ex)
                {
                    L_Alerta.Text = "Error: " + ex.Message;
                }
            }
        }

        private void REGISTRO_Load(object sender, EventArgs e)
        {
            L_Alerta.Text = null;
        }

        private void BTN_REGRESAR_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
