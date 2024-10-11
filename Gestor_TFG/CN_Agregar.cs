using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gestor_TFG
{
    public class CN_Agregar
    {
        sqlControl agr = new sqlControl();





       public List<agregar> Listar()
        {



            return agr.Listar();
        }

        public List<agregar> ListarConta() {

            return agr.ListarConta();
        
        }

        public List<agregar> ListarRecursos()
        {

            return agr.ListarRecursos();

        }

        public List<agregar> ListarPesquero()
        {

            return agr.ListarPesquero();

        }

        public List<agregar> ListarPromoción()
        {

            return agr.ListarPromoción();


        }

        public List<agregar> ListarAreaRegistro()
        {

            return agr.ListarAreaRegistro();


        }

        public List<agregar> ListarDEPFiscal() {

            return agr.ListarDEPFiscal();
        
        }

      





        public List<agregar> Listar2()
        {

            return agr.Listar2();


        }


        public int agregar(agregar obj, out string Message)
        {

           

         

            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand=="") {
                Message += "El nombre de la marca es necesario";
            
            
            
            }

            if (Model_String == "") {
                Message += "El nombre de la versión es necesario ";



            }
              

            return agr.Registar(obj,out Message);





        }


        public int agregar2(agregar obj, out string Message)
        {





            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }


            return agr.Registarconta(obj, out Message);





        }

        public int agregar3(agregar obj, out string Message)
        {





            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }


            return agr.RegistarRecursos(obj, out Message);





        }

        public int agregar4(agregar obj, out string Message)
        {





            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }


            return agr.RegistarPesquero(obj, out Message);





        }

        public int agregar5(agregar obj, out string Message)
        {





            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }


            return agr.RegistarPromoción(obj, out Message);





        }

        public int agregar6(agregar obj, out string Message)
        {





            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }


            return agr.RegistarArea(obj, out Message);





        }

        public int agregar7(agregar obj, out string Message)
        {





            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }


            return agr.RegistarDEPFiscal(obj, out Message);





        }




        public bool EditarTI(agregar obj, out string Message) {

            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }
            if (Message != string.Empty)
            {

                return false;

            }

            else {

                return agr.EditarTi(obj, out Message);
            
            
            }



        }

        public bool EditarConta(agregar obj, out string Message)
        {

            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }
            if (Message != string.Empty)
            {

                return false;

            }

            else
            {

                return agr.EditarConta(obj, out Message);


            }



        }

        public bool EditarRecursos(agregar obj, out string Message)
        {

            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }
            if (Message != string.Empty)
            {

                return false;

            }

            else
            {

                return agr.EditarRecursos(obj, out Message);


            }



        }

        public bool EditarPesquero(agregar obj, out string Message)
        {

            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }
            if (Message != string.Empty)
            {

                return false;

            }

            else
            {

                return agr.EditarPesquero(obj, out Message);


            }



        }

        public bool EditarPromoción(agregar obj, out string Message)
        {

            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }
            if (Message != string.Empty)
            {

                return false;

            }

            else
            {

                return agr.EditarPromoción(obj, out Message);


            }



        }

        public bool EditarAreaRegistro(agregar obj, out string Message)
        {

            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }
            if (Message != string.Empty)
            {

                return false;

            }

            else
            {

                return agr.EditarAreaRegistro(obj, out Message);


            }



        }
        public bool EditarDEPFiscal(agregar obj, out string Message)
        {

            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }
            if (Message != string.Empty)
            {

                return false;

            }

            else
            {

                return agr.EditarDEPFiscal(obj, out Message);


            }



        }



        public bool Editarnombre(agregar obj, out string Message)
        {

            string Model_String = obj.model.ToString();
            Message = string.Empty;

            if (obj.brand == "")
            {
                Message += "El nombre de la marca es necesario";



            }

            if (Model_String == "")
            {
                Message += "El nombre de la versión es necesario ";



            }
            if (Message != string.Empty)
            {

                return false;

            }

            else
            {

                return agr.editarnombre(obj, out Message);


            }



        }

        public bool ELiminarTI(agregar obj) {

            return agr.EliminarTI(obj);
        }

        public bool EliminarRecursos(agregar obj)
        {

            return agr.EliminarRecursos(obj);
        }
        public bool EliminarConta(agregar obj)
        {

            return agr.EliminarConta(obj);
        }
        public bool EliminarPesquero(agregar obj)
        {

            return agr.EliminarPesquero(obj);
        }
        public bool EliminarPromoción(agregar obj)
        {

            return agr.EliminarPromoción(obj);
        }
        public bool EliminarArea(agregar obj)
        {

            return agr.EliminarArea(obj);
        }
        public bool EliminarDEPFiscal(agregar obj)
        {

            return agr.EliminarDEPFiscal(obj);
        }

       /* public int Detiacontable( out string Message) {

            return agr.DeTIacontable( out Message);
        }*/



    }

}
