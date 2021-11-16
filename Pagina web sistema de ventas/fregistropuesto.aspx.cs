﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pagina_web_sistema_de_ventas
{
    public partial class fregistropuesto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Sistema de ventas;Integrated Security=True");
                string Id_de_Empleado;
                Id_de_Empleado = (TextBox2.Text);

                SqlCommand consulta_comprobar = new SqlCommand("  Select count(*) From Puestos WHERE Id_de_Empleado=@Id_de_Empleado  ", conexion);

                conexion.Open();
                consulta_comprobar.Parameters.AddWithValue("@Id_de_Empleado", Id_de_Empleado);
                int i;
                i = Convert.ToInt32(consulta_comprobar.ExecuteScalar());

                if (i > 0)
                {
                    MessageBox.Show("El empleado ya esta registro en un puesto");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    
                    
                    conexion.Close();
                }
                else
                {

                    string cadenaconsulta;

                    cadenaconsulta = "Insert into Puestos (Id_de_Puesto,Id_de_Empleado,Puesto)values(@Id_de_puesto,@Id_de_Empleado,@Puesto)";

                    SqlCommand consulta_agregar = new SqlCommand(cadenaconsulta, conexion);
                    consulta_agregar.Parameters.AddWithValue("@Id_de_puesto", TextBox1.Text);
                    consulta_agregar.Parameters.AddWithValue("@id_de_empleado", TextBox2.Text);
                    consulta_agregar.Parameters.AddWithValue("@puesto", TextBox3.Text);
                    
                    

                    if (i >= 0)
                    {
                        try
                        {



                            consulta_agregar.ExecuteNonQuery();
                            conexion.Close();

                            MessageBox.Show("Se agrego el puesto correspondiente al empleado");

                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            TextBox3.Text = "";
                        }



                        catch (SqlException j)
                        {
                            MessageBox.Show(j.ToString());
                        }


                    }
                }



            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Sistema de ventas;Integrated Security=True");

            conexion.Open();
            string eliminar;

            eliminar = "DELETE FROM Puestos WHERE ID_de_EMPLEADO=@ID_de_EMPLEADO";

            SqlCommand cmd = new SqlCommand(eliminar, conexion);

            cmd.Parameters.AddWithValue("@Id_de_Empleado", TextBox2.Text);
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show(" El empleado fue eliminado del puesto con exito");
        }
    }
}