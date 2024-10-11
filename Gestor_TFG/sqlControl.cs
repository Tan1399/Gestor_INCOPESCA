using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestor_TFG
{
    public class sqlControl
    {


        private SqlConnection cnn = new SqlConnection(@"Server=DESKTOP-B40OA03\SQLEXPRESS;Database=practica;Integrated Security=True");

        public int ContarFilasPorColumna(string nombreColumna)
        {
            int totalFilas = 0;
            string query = $"SELECT COUNT(*) FROM Registro WHERE {nombreColumna} IS NOT NULL";

            //    Console.WriteLine("Query inicial: " + query);  // Debugging


         var columnasChequear = new HashSet<string> {
      "Persona_Asignada", "Tipo", "Valor", "Modelo", "Marca",
      "No_Serie", "Fecha_Agregado", "Traslado", "Fecha_Traslado",
      "Lugar_Traslado", "Mantenimiento", "Ultimo_Mantenimiento"
            };



            /*  if (nombreColumna == "Tipo")
              {

                  query += $" AND {nombreColumna} <> ''";

              }*/

            // string query2= $"SELECT COUNT(*) FROM Registro WHERE {nombreColumna2} IS NOT NULL";

            // Si la columna es de tipo string, añade una condición adicional para excluir cadenas vacías
              if (columnasChequear.Contains(nombreColumna)) // Añade aquí cualquier otra columna de tipo string
              {
                  query += $" AND {nombreColumna} <> ''";
        //   MessageBox.Show("Query modificado: " + query);  // Debugging
              }




            /*  switch (nombreColumna)
              {
                  case "Persona Asignada":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Tipo":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Valor":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Modelo":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Marca":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "No_Serie":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Fecha_Agregado":
                      query += $" AND {nombreColumna} <> ''";
                      break;

                  case "Traslado":
                      query += $" AND {nombreColumna} <> ''";
                      break;

                  case "Fecha_Traslado":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Lugar_Traslado":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Mantenimiento":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Ultimo_Mantenimiento":
                      query += $" AND {nombreColumna} <> ''";
                      break;
              }*/
            using (cnn)
            {




                using (SqlCommand cmd = new SqlCommand(query, cnn)) { 

                try
                {
                    cnn.Open();
                    totalFilas = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al contar filas para {nombreColumna}: {ex.Message}");
                }
            }

            return totalFilas;
        }
        }

        public int ContarFilasPorColumna1(string nombreColumna)
        {
              
        int totalFilas = 0;
            string query = $"SELECT COUNT(*) FROM Registro WHERE {nombreColumna} IS NOT NULL";
            var columnasChequear = new HashSet<string> {
      "Persona_Asignada", "Tipo", "Valor", "Modelo", "Marca",
      "No_Serie", "Fecha_Agregado", "Traslado", "Fecha_Traslado",
      "Lugar_Traslado", "Mantenimiento", "Ultimo_Mantenimiento"
  };

            //    Console.WriteLine("Query inicial: " + query);  // Debugging


            /*  var columnasChequear = new HashSet<string> {
      "Persona_Asignada", "Tipo", "Valor", "Modelo", "Marca",
      "No_Serie", "Fecha_Agregado", "Traslado", "Fecha_Traslado",
      "Lugar_Traslado", "Mantenimiento", "Ultimo_Mantenimiento"
  };*/



            /*  if (nombreColumna == "Tipo")
              {

                  query += $" AND {nombreColumna} <> ''";

              }*/

            // string query2= $"SELECT COUNT(*) FROM Registro WHERE {nombreColumna2} IS NOT NULL";

            // Si la columna es de tipo string, añade una condición adicional para excluir cadenas vacías
            /*  if (columnasChequear.Contains(nombreColumna)) // Añade aquí cualquier otra columna de tipo string
              {
                  query += $" AND {nombreColumna} <> ''";
        //   MessageBox.Show("Query modificado: " + query);  // Debugging
              }*/




            /*  switch (nombreColumna)
              {
                  case "Persona Asignada":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Tipo":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Valor":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Modelo":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Marca":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "No_Serie":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Fecha_Agregado":
                      query += $" AND {nombreColumna} <> ''";
                      break;

                  case "Traslado":
                      query += $" AND {nombreColumna} <> ''";
                      break;

                  case "Fecha_Traslado":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Lugar_Traslado":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Mantenimiento":
                      query += $" AND {nombreColumna} <> ''";
                      break;
                  case "Ultimo_Mantenimiento":
                      query += $" AND {nombreColumna} <> ''";
                      break;
              }*/
            using (cnn)
            {

               


                SqlCommand cmd = new SqlCommand(query, cnn);

                try
                {
                    cnn.Open();
                    totalFilas = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al contar filas para {nombreColumna}: {ex.Message}");
                }
            }

            return totalFilas;
        }
        public int ContarFilasPorColumna2(string nombreColumna)
        {
            int totalFilas = 0;
            string query = $"SELECT COUNT(*) FROM RegistroContabilidad WHERE {nombreColumna} IS NOT NULL";
            var columnasChequear = new HashSet<string> {
      "Persona_Asignada", "Tipo", "Valor", "Modelo", "Marca",
      "No_Serie", "Fecha_Agregado", "Traslado", "Fecha_Traslado",
      "Lugar_Traslado", "Mantenimiento", "Ultimo_Mantenimiento"
  };

            // Si la columna es de tipo string, añade una condición adicional para excluir cadenas vacías
            if (columnasChequear.Contains(nombreColumna))// Añade aquí cualquier otra columna de tipo string
            {
                query += $" AND {nombreColumna} <> ''";
            }

            using (cnn)
            {
                SqlCommand cmd = new SqlCommand(query, cnn);

                try
                {
                    cnn.Open();
                    totalFilas = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al contar filas para {nombreColumna}: {ex.Message}");
                }
            }

            return totalFilas;
        }

        public int ContarFilasPorColumna3(string nombreColumna)
        {
            int totalFilas = 0;
            string query = $"SELECT COUNT(*) FROM Pesquera_Acuícola WHERE {nombreColumna} IS NOT NULL";

            // Si la columna es de tipo string, añade una condición adicional para excluir cadenas vacías
            if (nombreColumna == "Persona_Asignada") // Añade aquí cualquier otra columna de tipo string
            {
                query += $" AND {nombreColumna} <> ''";
            }

            using (cnn)
            {
                SqlCommand cmd = new SqlCommand(query, cnn);

                try
                {
                    cnn.Open();
                    totalFilas = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al contar filas para {nombreColumna}: {ex.Message}");
                }
            }

            return totalFilas;
        }
        public int ContarFilasPorColumna4(string nombreColumna)
        {
            int totalFilas = 0;
            string query = $"SELECT COUNT(*) FROM Registro_Recursos_Humanos WHERE {nombreColumna} IS NOT NULL";
            var columnasChequear = new HashSet<string> {
      "Persona_Asignada", "Tipo", "Valor", "Modelo", "Marca",
      "No_Serie", "Fecha_Agregado", "Traslado", "Fecha_Traslado",
      "Lugar_Traslado", "Mantenimiento", "Ultimo_Mantenimiento"
  };

            // Si la columna es de tipo string, añade una condición adicional para excluir cadenas vacías
            if (columnasChequear.Contains(nombreColumna)) // Añade aquí cualquier otra columna de tipo string
            {
                query += $" AND {nombreColumna} <> ''";
            }

            using (cnn)
            {
                SqlCommand cmd = new SqlCommand(query, cnn);

                try
                {
                    cnn.Open();
                    totalFilas = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al contar filas para {nombreColumna}: {ex.Message}");
                }
            }

            return totalFilas;
        }

        public int ContarFilasPorColumna5(string nombreColumna)
        {
            int totalFilas = 0;
            string query = $"SELECT COUNT(*) FROM Registro_Promoción_Mercados WHERE {nombreColumna} IS NOT NULL";
            var columnasChequear = new HashSet<string> {
      "Persona_Asignada", "Tipo", "Valor", "Modelo", "Marca",
      "No_Serie", "Fecha_Agregado", "Traslado", "Fecha_Traslado",
      "Lugar_Traslado", "Mantenimiento", "Ultimo_Mantenimiento"
  };

            // Si la columna es de tipo string, se añade una condición adicional para excluir cadenas vacías
            if (columnasChequear.Contains(nombreColumna)) // Añade aquí cualquier otra columna de tipo string
            {
                query += $" AND {nombreColumna} <> ''";
            }

            using (cnn)
            {
                SqlCommand cmd = new SqlCommand(query, cnn);

                try
                {
                    cnn.Open();
                    totalFilas = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al contar filas para {nombreColumna}: {ex.Message}");
                }
            }

            return totalFilas;
        }
        public int ContarFilasPorColumna6(string nombreColumna)
        {
            int totalFilas = 0;
            string query = $"SELECT COUNT(*) FROM Area_Registro WHERE {nombreColumna} IS NOT NULL";
            var columnasChequear = new HashSet<string> {
      "Persona_Asignada", "Tipo", "Valor", "Modelo", "Marca",
      "No_Serie", "Fecha_Agregado", "Traslado", "Fecha_Traslado",
      "Lugar_Traslado", "Mantenimiento", "Ultimo_Mantenimiento"
  };

            // Si la columna es de tipo string, añade una condición adicional para excluir cadenas vacías
            if (columnasChequear.Contains(nombreColumna)) // Añade aquí cualquier otra columna de tipo string
            {
                query += $" AND {nombreColumna} <> ''";
            }

            using (cnn)
            {
                SqlCommand cmd = new SqlCommand(query, cnn);

                try
                {
                    cnn.Open();
                    totalFilas = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al contar filas para {nombreColumna}: {ex.Message}");
                }
            }

            return totalFilas;
        }

        public int ContarFilasPorColumna7(string nombreColumna)
        {
            int totalFilas = 0;
            string query = $"SELECT COUNT(*) FROM Registro_Departamento_Fiscal WHERE {nombreColumna} IS NOT NULL";
            var columnasChequear = new HashSet<string> {
      "Persona_Asignada", "Tipo", "Valor", "Modelo", "Marca",
      "No_Serie", "Fecha_Agregado", "Traslado", "Fecha_Traslado",
      "Lugar_Traslado", "Mantenimiento", "Ultimo_Mantenimiento"
  };

            // Si la columna es de tipo string, añade una condición adicional para excluir cadenas vacías
            if (columnasChequear.Contains(nombreColumna)) // Añade aquí cualquier otra columna de tipo string
            {
                query += $" AND {nombreColumna} <> ''";
            }

            using (cnn)
            {
                SqlCommand cmd = new SqlCommand(query, cnn);

                try
                {
                    cnn.Open();
                    totalFilas = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al contar filas para {nombreColumna}: {ex.Message}");
                }
            }

            return totalFilas;
        }








        public List<agregar> Listar()
        {

            List<agregar> lista = new List<agregar>();

            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("select r.Id,r.Persona_Asignada,r.Tipo,r.Valor,r.Modelo,r.Marca,r.No_Serie,r.Fecha_Agregado,r.Traslado,r.Fecha_Traslado,r.Lugar_Traslado,r.Mantenimiento,r.Ultimo_Mantenimiento from Registro r");

                SqlCommand cmd = new SqlCommand(query.ToString(), cnn);
                cmd.CommandType = CommandType.Text;
                cnn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        lista.Add(new agregar()
                        {
                            Iduser = Convert.ToInt32(dr["Id"]),
                            Username = Convert.ToString(dr["Persona_Asignada"]),
                            Type = Convert.ToString(dr["Tipo"]),
                            Value = Convert.ToInt32(dr["Valor"]),
                            Trasfer_Date = Convert.ToDateTime(dr["Fecha_Traslado"]),
                            Realice_Maintence = Convert.ToBoolean(dr["Mantenimiento"]),
                            No_Serie = Convert.ToInt32(dr["No_Serie"]),
                            Transfer = Convert.ToBoolean(dr["Traslado"]),
                            Transfer_Place = Convert.ToString(dr["Lugar_Traslado"]),
                            last_maintence = Convert.ToDateTime(dr["Ultimo_Mantenimiento"]),
                            model = Convert.ToString(dr["Modelo"]),
                            brand = Convert.ToString(dr["Marca"]),
                            Agregate_Date=Convert.ToDateTime(dr["Fecha_Agregado"])









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
        public List<agregar> ListarConta()
        {

            List<agregar> lista = new List<agregar>();

            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("select r.Id,r.Persona_Asignada,r.Tipo,r.Valor,r.Modelo,r.Marca,r.No_Serie,r.Fecha_Agregado,r.Traslado,r.Fecha_Traslado,r.Lugar_Traslado,r.Mantenimiento,r.Ultimo_Mantenimiento from RegistroContabilidad r");

                SqlCommand cmd = new SqlCommand(query.ToString(), cnn);
                cmd.CommandType = CommandType.Text;
                cnn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        lista.Add(new agregar()
                        {
                            Iduser = Convert.ToInt32(dr["Id"]),
                            Username = Convert.ToString(dr["Persona_Asignada"]),
                            Type = Convert.ToString(dr["Tipo"]),
                            Value = Convert.ToInt32(dr["Valor"]),
                            Trasfer_Date = Convert.ToDateTime(dr["Fecha_Traslado"]),
                            Realice_Maintence = Convert.ToBoolean(dr["Mantenimiento"]),
                            No_Serie = Convert.ToInt32(dr["No_Serie"]),
                            Transfer = Convert.ToBoolean(dr["Traslado"]),
                            Transfer_Place = Convert.ToString(dr["Lugar_Traslado"]),
                            last_maintence = Convert.ToDateTime(dr["Ultimo_Mantenimiento"]),
                            model = Convert.ToString(dr["Modelo"]),
                            brand = Convert.ToString(dr["Marca"]),
                            Agregate_Date = Convert.ToDateTime(dr["Fecha_Agregado"])









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

        public List<agregar> ListarRecursos()
        {

            List<agregar> lista = new List<agregar>();

            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("select r.Id,r.Persona_Asignada,r.Tipo,r.Valor,r.Modelo,r.Marca,r.No_Serie,r.Fecha_Agregado,r.Traslado,r.Fecha_Traslado,r.Lugar_Traslado,r.Mantenimiento,r.Ultimo_Mantenimiento from Registro_Recursos_Humanos r");

                SqlCommand cmd = new SqlCommand(query.ToString(), cnn);
                cmd.CommandType = CommandType.Text;
                cnn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        lista.Add(new agregar()
                        {
                            Iduser = Convert.ToInt32(dr["Id"]),
                            Username = Convert.ToString(dr["Persona_Asignada"]),
                            Type = Convert.ToString(dr["Tipo"]),
                            Value = Convert.ToInt32(dr["Valor"]),
                            Trasfer_Date = Convert.ToDateTime(dr["Fecha_Traslado"]),
                            Realice_Maintence = Convert.ToBoolean(dr["Mantenimiento"]),
                            No_Serie = Convert.ToInt32(dr["No_Serie"]),
                            Transfer = Convert.ToBoolean(dr["Traslado"]),
                            Transfer_Place = Convert.ToString(dr["Lugar_Traslado"]),
                            last_maintence = Convert.ToDateTime(dr["Ultimo_Mantenimiento"]),
                            model = Convert.ToString(dr["Modelo"]),
                            brand = Convert.ToString(dr["Marca"]),
                            Agregate_Date = Convert.ToDateTime(dr["Fecha_Agregado"])









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

        public List<agregar> ListarPesquero()
        {

            List<agregar> lista = new List<agregar>();

            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("select r.Id,r.Persona_Asignada,r.Tipo,r.Valor,r.Modelo,r.Marca,r.No_Serie,r.Fecha_Agregado,r.Traslado,r.Fecha_Traslado,r.Lugar_Traslado,r.Mantenimiento,r.Ultimo_Mantenimiento from Pesquera_Acuícola r");

                SqlCommand cmd = new SqlCommand(query.ToString(), cnn);
                cmd.CommandType = CommandType.Text;
                cnn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        lista.Add(new agregar()
                        {
                            Iduser = Convert.ToInt32(dr["Id"]),
                            Username = Convert.ToString(dr["Persona_Asignada"]),
                            Type = Convert.ToString(dr["Tipo"]),
                            Value = Convert.ToInt32(dr["Valor"]),
                            Trasfer_Date = Convert.ToDateTime(dr["Fecha_Traslado"]),
                            Realice_Maintence = Convert.ToBoolean(dr["Mantenimiento"]),
                            No_Serie = Convert.ToInt32(dr["No_Serie"]),
                            Transfer = Convert.ToBoolean(dr["Traslado"]),
                            Transfer_Place = Convert.ToString(dr["Lugar_Traslado"]),
                            last_maintence = Convert.ToDateTime(dr["Ultimo_Mantenimiento"]),
                            model = Convert.ToString(dr["Modelo"]),
                            brand = Convert.ToString(dr["Marca"]),
                            Agregate_Date = Convert.ToDateTime(dr["Fecha_Agregado"])









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
        public List<agregar> ListarPromoción()
        {

            List<agregar> lista = new List<agregar>();

            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("select r.Id,r.Persona_Asignada,r.Tipo,r.Valor,r.Modelo,r.Marca,r.No_Serie,r.Fecha_Agregado,r.Traslado,r.Fecha_Traslado,r.Lugar_Traslado,r.Mantenimiento,r.Ultimo_Mantenimiento from Registro_Promoción_Mercados r");

                SqlCommand cmd = new SqlCommand(query.ToString(), cnn);
                cmd.CommandType = CommandType.Text;
                cnn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        lista.Add(new agregar()
                        {
                            Iduser = Convert.ToInt32(dr["Id"]),
                            Username = Convert.ToString(dr["Persona_Asignada"]),
                            Type = Convert.ToString(dr["Tipo"]),
                            Value = Convert.ToInt32(dr["Valor"]),
                            Trasfer_Date = Convert.ToDateTime(dr["Fecha_Traslado"]),
                            Realice_Maintence = Convert.ToBoolean(dr["Mantenimiento"]),
                            No_Serie = Convert.ToInt32(dr["No_Serie"]),
                            Transfer = Convert.ToBoolean(dr["Traslado"]),
                            Transfer_Place = Convert.ToString(dr["Lugar_Traslado"]),
                            last_maintence = Convert.ToDateTime(dr["Ultimo_Mantenimiento"]),
                            model = Convert.ToString(dr["Modelo"]),
                            brand = Convert.ToString(dr["Marca"]),
                            Agregate_Date = Convert.ToDateTime(dr["Fecha_Agregado"])









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

        public List<agregar> ListarAreaRegistro()
        {

            List<agregar> lista = new List<agregar>();

            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("select r.Id,r.Persona_Asignada,r.Tipo,r.Valor,r.Modelo,r.Marca,r.No_Serie,r.Fecha_Agregado,r.Traslado,r.Fecha_Traslado,r.Lugar_Traslado,r.Mantenimiento,r.Ultimo_Mantenimiento from Area_Registro r");

                SqlCommand cmd = new SqlCommand(query.ToString(), cnn);
                cmd.CommandType = CommandType.Text;
                cnn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        lista.Add(new agregar()
                        {
                            Iduser = Convert.ToInt32(dr["Id"]),
                            Username = Convert.ToString(dr["Persona_Asignada"]),
                            Type = Convert.ToString(dr["Tipo"]),
                            Value = Convert.ToInt32(dr["Valor"]),
                            Trasfer_Date = Convert.ToDateTime(dr["Fecha_Traslado"]),
                            Realice_Maintence = Convert.ToBoolean(dr["Mantenimiento"]),
                            No_Serie = Convert.ToInt32(dr["No_Serie"]),
                            Transfer = Convert.ToBoolean(dr["Traslado"]),
                            Transfer_Place = Convert.ToString(dr["Lugar_Traslado"]),
                            last_maintence = Convert.ToDateTime(dr["Ultimo_Mantenimiento"]),
                            model = Convert.ToString(dr["Modelo"]),
                            brand = Convert.ToString(dr["Marca"]),
                            Agregate_Date = Convert.ToDateTime(dr["Fecha_Agregado"])









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
        public List<agregar> ListarDEPFiscal()
        {

            List<agregar> lista = new List<agregar>();

            try
            {
                StringBuilder query = new StringBuilder();

                query.AppendLine("select r.Id,r.Persona_Asignada,r.Tipo,r.Valor,r.Modelo,r.Marca,r.No_Serie,r.Fecha_Agregado,r.Traslado,r.Fecha_Traslado,r.Lugar_Traslado,r.Mantenimiento,r.Ultimo_Mantenimiento from Registro_Departamento_Fiscal r");

                SqlCommand cmd = new SqlCommand(query.ToString(), cnn);
                cmd.CommandType = CommandType.Text;
                cnn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    while (dr.Read())
                    {
                        lista.Add(new agregar()
                        {
                            Iduser = Convert.ToInt32(dr["Id"]),
                            Username = Convert.ToString(dr["Persona_Asignada"]),
                            Type = Convert.ToString(dr["Tipo"]),
                            Value = Convert.ToInt32(dr["Valor"]),
                            Trasfer_Date = Convert.ToDateTime(dr["Fecha_Traslado"]),
                            Realice_Maintence = Convert.ToBoolean(dr["Mantenimiento"]),
                            No_Serie = Convert.ToInt32(dr["No_Serie"]),
                            Transfer = Convert.ToBoolean(dr["Traslado"]),
                            Transfer_Place = Convert.ToString(dr["Lugar_Traslado"]),
                            last_maintence = Convert.ToDateTime(dr["Ultimo_Mantenimiento"]),
                            model = Convert.ToString(dr["Modelo"]),
                            brand = Convert.ToString(dr["Marca"]),
                            Agregate_Date = Convert.ToDateTime(dr["Fecha_Agregado"])









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

        public bool EditarTi(agregar obj, out string Mensaje) {

            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_EditarTI", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString()
;

            }

            catch (Exception ex)
            {



                respuesta = false;
                Mensaje = ex.Message;







            }
            return respuesta;



        }

        public bool EditarConta(agregar obj, out string Mensaje)
        {

            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_EditarConta", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString()
;

            }

            catch (Exception ex)
            {



                respuesta = false;
                Mensaje = ex.Message;







            }
            return respuesta;



        }

        public bool EditarRecursos(agregar obj, out string Mensaje)
        {

            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_EditarRecursos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString()
;

            }

            catch (Exception ex)
            {



                respuesta = false;
                Mensaje = ex.Message;







            }
            return respuesta;



        }

        public bool EditarPesquero(agregar obj, out string Mensaje)
        {

            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_EditarPesquera", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString()
;

            }

            catch (Exception ex)
            {



                respuesta = false;
                Mensaje = ex.Message;







            }
            return respuesta;



        }

        public bool EditarPromoción(agregar obj, out string Mensaje)
        {

            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_PromocionMerch", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString()
;

            }

            catch (Exception ex)
            {



                respuesta = false;
                Mensaje = ex.Message;







            }
            return respuesta;



        }
        public bool EditarAreaRegistro(agregar obj, out string Mensaje)
        {

            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_EditarArea", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString()
;

            }

            catch (Exception ex)
            {



                respuesta = false;
                Mensaje = ex.Message;







            }
            return respuesta;



        }
        public bool EditarDEPFiscal(agregar obj, out string Mensaje)
        {

            bool respuesta = false;
            Mensaje = string.Empty;


            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_EditarDepFiscal", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString()
;

            }

            catch (Exception ex)
            {



                respuesta = false;
                Mensaje = ex.Message;







            }
            return respuesta;



        }




        public bool EliminarTI(agregar obj) {

            bool respuesta=false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_TI", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);

              
;

            }

            catch (Exception ex)
            {

                respuesta = false;

             






            }

            return respuesta;




        }


        public bool EliminarRecursos(agregar obj)
        {

            bool respuesta = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_Recursos", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);


                ;

            }

            catch (Exception ex)
            {

                respuesta = false;








            }

            return respuesta;




        }
        public bool EliminarConta(agregar obj)
        {

            bool respuesta = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_Conta", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);


                ;

            }

            catch (Exception ex)
            {

                respuesta = false;








            }

            return respuesta;




        }

        public bool EliminarPesquero(agregar obj)
        {

            bool respuesta = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_Pesquera", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);


                ;

            }

            catch (Exception ex)
            {

                respuesta = false;








            }

            return respuesta;




        }

        public bool EliminarPromoción(agregar obj)
        {

            bool respuesta = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_Promocionmerch", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);


                ;

            }

            catch (Exception ex)
            {

                respuesta = false;








            }

            return respuesta;




        }

        public bool EliminarArea(agregar obj)
        {

            bool respuesta = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_Area", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);


                ;

            }

            catch (Exception ex)
            {

                respuesta = false;








            }

            return respuesta;




        }
        public bool EliminarDEPFiscal(agregar obj)
        {

            bool respuesta = false;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_ELIMINAR_Departamento", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);


                ;

            }

            catch (Exception ex)
            {

                respuesta = false;








            }

            return respuesta;




        }


        public bool editarnombre(agregar obj, out string Mensaje) {

            bool respuesta = false;
            Mensaje = string.Empty;
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("sp_Editarnombre", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id", obj.Iduser);
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username); // cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString()
;

            }

            catch (Exception ex)
            {



                respuesta = false;
                Mensaje = ex.Message;







            }
            return respuesta;


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
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

               idnombreagregado = Convert.ToInt32(cmd.Parameters["idResultado"].Value);
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

        public int RegistarRecursos(agregar obj, out string Mensaje)
        {
            int idnombreagregado = 0;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_RegistrarDEPRH", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                idnombreagregado = Convert.ToInt32(cmd.Parameters["idResultado"].Value);
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

        public int Registarconta(agregar obj, out string Mensaje)
        {
            int idnombreagregado = 0;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_RegistrarDEPcontable", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                idnombreagregado = Convert.ToInt32(cmd.Parameters["idResultado"].Value);
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

        public int RegistarPesquero(agregar obj, out string Mensaje)
        {
            int idnombreagregado = 0;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_Registrarpesqueraacuícola", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                idnombreagregado = Convert.ToInt32(cmd.Parameters["idResultado"].Value);
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

        public int RegistarPromoción(agregar obj, out string Mensaje)
        {
            int idnombreagregado = 0;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_RegistrarDEPPromocionmerch", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                idnombreagregado = Convert.ToInt32(cmd.Parameters["idResultado"].Value);
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

        public int RegistarArea(agregar obj, out string Mensaje)
        {
            int idnombreagregado = 0;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_RegistrarAreaRegi", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                idnombreagregado = Convert.ToInt32(cmd.Parameters["idResultado"].Value);
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
        public int RegistarDEPFiscal(agregar obj, out string Mensaje)
        {
            int idnombreagregado = 0;

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_RegistrarDEPfiscal", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("Tipo", obj.Type);
                cmd.Parameters.AddWithValue("Valor", obj.Value);
                cmd.Parameters.AddWithValue("Modelo", obj.model);
                cmd.Parameters.AddWithValue("Marca", obj.brand);
                cmd.Parameters.AddWithValue("No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("Mantenimiento", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("Ultimo_Mantenimiento", obj.last_maintence);
                cmd.Parameters.Add("idResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;



                cmd.ExecuteNonQuery();

                idnombreagregado = Convert.ToInt32(cmd.Parameters["idResultado"].Value);
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
      /*  public bool DeTIacontable(agregar obj, out string mensaje)
        {

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("InsertOrUpdateRegistroContabilidad", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                cmd.Parameters.AddWithValue("@Id", obj.Iduser);
                cmd.Parameters.AddWithValue("@Persona_Asignada", obj.Username);
                cmd.Parameters.AddWithValue("@Tipo", obj.Type);
                cmd.Parameters.AddWithValue("@Valor", obj.Value);
                cmd.Parameters.AddWithValue("@Modelo", obj.model);
                cmd.Parameters.AddWithValue("@Marca", obj.brand);
                cmd.Parameters.AddWithValue("@No_Serie", obj.No_Serie);
                cmd.Parameters.AddWithValue("@Fecha_Agregado", obj.Agregate_Date);
                cmd.Parameters.AddWithValue("@Traslado", obj.Transfer);
                cmd.Parameters.AddWithValue("@Fecha_Traslado", obj.Trasfer_Date);
                cmd.Parameters.AddWithValue("@Lugar_Traslado", obj.Transfer_Place);
                cmd.Parameters.AddWithValue("@MantenimientoTI", obj.Realice_Maintence);
                cmd.Parameters.AddWithValue("@Ultimo_Mantenimiento", obj.last_maintence);

                // Parámetro de salida para el mensaje
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 4000).Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                // Obtener el mensaje del procedimiento almacenado
                mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                return !mensaje.Contains("Error");
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }*/


    }


    }


