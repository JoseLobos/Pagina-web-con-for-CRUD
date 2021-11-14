using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;

namespace Pagina_web_sistema_de_ventas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Login;Integrated Security=True");
            SqlCommand comando = new SqlCommand("  Select count(*) From Usuarios where Id_usuario=@Usuario  ", conexion);
            conexion.Open();



            if (TextBox1.Text == "" & TextBox2.Text == "")
            {
                MessageBox.Show("Hay campos vacios");



            }
            else
            {
                comando.Parameters.AddWithValue("@Usuario", Convert.ToInt32(TextBox1.Text));
                int i = Convert.ToInt32(comando.ExecuteScalar());
                if (i > 0)
                {
                    try
                    {



                        MessageBox.Show("Sesion Iniciada");
                        Response.Redirect("~/Default");
                    }



                    catch (SqlException k)
                    {
                        MessageBox.Show(k.ToString());
                    }

                   
                }
            }
    }
}
}