using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<agregar> Listar2()
        {

            return agr.Listar2();


        }


        public int agregar(agregar obj, out string Message)
        {

           

            Message = string.Empty;

            string Model_String = obj.model.ToString();

            if (obj.brand=="") {
                Message += "El nombre de la marca es necesario";
            
            
            
            }

            if (Model_String == "") {
                Message += "El nombre de la versión es necesario ";



            }
              

            return agr.Registar(obj,out Message);





        }
    }

}
