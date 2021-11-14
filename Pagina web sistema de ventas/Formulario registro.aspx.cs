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
    public partial class Formulario_registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-QM112JVD\MSSQLSERVER01;Initial Catalog=Login;Integrated Security=True");
                string usuario;
                usuario = (TextBox1.Text);

                SqlCommand consulta_comprobar = new SqlCommand("  Select count(*) From Usuarios1 WHERE Usuario=@Usuario  ", conexion);
                
                conexion.Open();
                consulta_comprobar.Parameters.AddWithValue("@Usuario", usuario);
                int i;
                i= Convert.ToInt32(consulta_comprobar.ExecuteScalar());

                if (i > 0)
                {
                    MessageBox.Show ("El Nombre de usuario ingresado ya esta en uso");
                conexion.Close();
                }
                else
                {
                    
                    string cadenaconsulta;
                   
                    cadenaconsulta = "Insert into usuarios1 (Id_usuario,Usuario,Contraseña,Nivel) values (@Id_usuario,@usuario,@contraseña,@nivel)";

                    SqlCommand consulta_agregar = new SqlCommand(cadenaconsulta, conexion);
                    consulta_agregar.Parameters.AddWithValue("@Id_usuario", TextBox4.Text);
                    consulta_agregar.Parameters.AddWithValue("@usuario", TextBox1.Text);
                    consulta_agregar.Parameters.AddWithValue("@contraseña", TextBox2.Text);
                    consulta_agregar.Parameters.AddWithValue("@nivel",Convert.ToInt32( TextBox3.Text));

                    if (i >= 0)
                    {
                        try
                        {



                            consulta_agregar.ExecuteNonQuery();
                            conexion.Close();

                            MessageBox.Show("Se agrego el nuevo usuario correctamente");
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