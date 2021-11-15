using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pagina_web_sistema_de_ventas
{
    public partial class formulario_registro_empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Sistema de ventas;Integrated Security=True");
                string nombres;
                nombres = (TextBox2.Text);

                SqlCommand consulta_comprobar = new SqlCommand("  Select count(*) From Empleados WHERE  Nombres=@Nombres  ", conexion);

                conexion.Open();
                consulta_comprobar.Parameters.AddWithValue("@Nombres", nombres);
                int i;
                i = Convert.ToInt32(consulta_comprobar.ExecuteScalar());

                if (i > 0)
                {
                    MessageBox.Show("El Nombre de empleado ingresado ya esta en uso");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox8.Text = "";
                    TextBox9.Text = "";
                    TextBox10.Text = "";
                    TextBox11.Text = "";
                    TextBox12.Text = "";
                    TextBox13.Text = "";
                    TextBox14.Text = "";
                    TextBox15.Text = "";
                    TextBox16.Text = "";
                    TextBox17.Text = "";
                    conexion.Close();
                }
                else
                {

                    string cadenaconsulta;

                    cadenaconsulta = "Insert into Empleados (Id_Empleado,Nombres,Apellidos,Fecha_de_Nacimiento,Telefono,Direccion,Genero,Departamento,Nivel_laboral,Sueldo,Observaciones,Correo,Numero_de_Dui,Numero_de_Nit,Numero_de_Afp,Fecha_de_Ingreso,Jefatura)values(@Id_Empleado,@Nombres,@Apellidos,@Fecha_de_Nacimiento,@Telefono,@Direccion,@Genero,@Departamento,@Nivel_laboral,@Sueldo,@Observaciones,@Correo,@Numero_de_Dui,@Numero_de_Nit,@Numero_de_Afp,@Fecha_de_Ingreso,@Jefatura)";

                    SqlCommand consulta_agregar = new SqlCommand(cadenaconsulta, conexion);
                    consulta_agregar.Parameters.AddWithValue("@Id_Empleado", TextBox1.Text);
                    consulta_agregar.Parameters.AddWithValue("@Nombres", TextBox2.Text);
                    consulta_agregar.Parameters.AddWithValue("@Apellidos", TextBox3.Text);
                    consulta_agregar.Parameters.AddWithValue("@Fecha_de_Nacimiento", TextBox4.Text);
                    consulta_agregar.Parameters.AddWithValue("@Telefono", TextBox5.Text);
                    consulta_agregar.Parameters.AddWithValue("@Direccion", TextBox6.Text);
                    consulta_agregar.Parameters.AddWithValue("@Genero", TextBox7.Text);
                    consulta_agregar.Parameters.AddWithValue("@Departamento", TextBox8.Text);
                    consulta_agregar.Parameters.AddWithValue("@Nivel_laboral", TextBox17.Text);
                    consulta_agregar.Parameters.AddWithValue("@Sueldo", TextBox9.Text);
                    consulta_agregar.Parameters.AddWithValue("@Observaciones", TextBox10.Text);
                    consulta_agregar.Parameters.AddWithValue("@Correo", TextBox11.Text);
                    consulta_agregar.Parameters.AddWithValue("@Numero_de_Dui", TextBox12.Text);
                    consulta_agregar.Parameters.AddWithValue("@Numero_de_Nit", TextBox13.Text);
                    consulta_agregar.Parameters.AddWithValue("@Numero_de_Afp", TextBox14.Text);
                    consulta_agregar.Parameters.AddWithValue("@Fecha_de_Ingreso", TextBox15.Text);
                    consulta_agregar.Parameters.AddWithValue("@Jefatura", TextBox16.Text);
                    

                    if (i >= 0)
                    {
                        try
                        {



                            consulta_agregar.ExecuteNonQuery();
                            conexion.Close();

                            MessageBox.Show("Se agrego el nuevo empleado correctamente");

                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                            TextBox4.Text = "";
                            TextBox5.Text = "";
                            TextBox6.Text = "";
                            TextBox7.Text = "";
                            TextBox8.Text = "";
                            TextBox9.Text = "";
                            TextBox10.Text = "";
                            TextBox11.Text = "";
                            TextBox12.Text = "";
                            TextBox13.Text = "";
                            TextBox14.Text = "";
                            TextBox15.Text = "";
                            TextBox16.Text = "";
                            TextBox17.Text = "";
                        }



                        catch (SqlException j)
                        {
                            MessageBox.Show(j.ToString());
                        }


                    }
                }



            }

        }
    }
}