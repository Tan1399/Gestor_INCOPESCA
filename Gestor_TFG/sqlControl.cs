using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.CodeDom;
using System.Security.AccessControl;

namespace Gestor_TFG
{
    public class sqlControl
    {


        private SqlConnection cnn = new SqlConnection(@"Server=DESKTOP-B40OA03\SQLEXPRESS;Database=practica;Integrated Security=True");




        public List<agregar> Listar()
        {

            List<agregar> lista = new List<agregar>();

            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("select p.id, p.Persona_Asignada,p.Fecha,p.Si_No from persona p");

                SqlCommand cmd = new SqlCommand(query.ToString(), cnn);
                cmd.CommandType = CommandType.Text;
                cnn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        lista.Add(new agregar()
                        {
                            Iduser = Convert.ToInt32(dr["id"]),
                            Username = Convert.ToString(dr["Persona_Asignada"]),
                            //Type = Convert.ToString(dr["tipo"]),
                            //Value = Convert.ToInt32(dr["valor"]),
                           // Trasfer_Date = Convert.ToDateTime(dr["fecha_agregado"]),
                           // Realice_Maintence = Convert.ToString(dr["SI_No"]),
                            //No_Serie = Convert.ToInt32(dr["noseries"]),
                            //Transfer = Convert.ToBoolean(dr["traslado"]),
                            //Transfer_Place = Convert.ToString(dr["transferplace"]),
                            last_maintence = Convert.ToDateTime(dr["Fecha"]),
                            //model = Convert.ToChar(dr["Modelo"]),
                            //brand = Convert.ToString(dr["Marca"])









                        });





                    }


                }


            }
            catch (Exception ex)
            {
                lista = new List<agregar>();



            }
            return lista;



        
        }


        public List<agregar> Listar2() {

            List<agregar> lista = new List<agregar>();

            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("select p.Persona_Asignada from persona p");

                SqlCommand cmd = new SqlCommand(query.ToString(), cnn);
                cmd.CommandType = CommandType.Text;
                cnn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        lista.Add(new agregar()
                        {
                           
                            Username = Convert.ToString(dr["Persona_Asiganda"])
                        








                        });





                    }


                }


            }
            catch (Exception ex)
            {
                lista = new List<agregar>();



            }
            return lista;




        }

        //Guardar los datos en la bd
        public int Registar(agregar obj, out string Mensaje) {
            int idnombreagregado = 0;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_Registrar", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

               idnombreagregado = Convert.ToInt32(cmd.Parameters["iDagregarResultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString()
;            

            }

            catch (Exception ex)
            {

                idnombreagregado = 0;

                MessageBox.Show(ex.Message);
                Mensaje = ex.Message;
             






            }
            return idnombreagregado;


           




        }





        //Cambiar contraseñas
        public bool cambiar_usuario(string new_user, string new_pass) {


            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("spChangeUserCredentials", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@newUsuario", new_user);
                cmd.Parameters.AddWithValue("newPass", new_pass);

                int result = cmd.ExecuteNonQuery();
                return result > 0;

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;






            }


            finally {



                cnn.Close();
            
            
            }





        }

        // Validar Login
        public int Login( string user, string pass) {

            try
            {

                cnn.Open();

                SqlCommand cmd = new SqlCommand("spLogin", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", user);
                cmd.Parameters.AddWithValue("@pass", pass);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {


                    return dr.GetInt32(0);

                }









            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             








            }

            finally {


                cnn.Close();
            
            }


            return -1;




        }


         




    }
}
