using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_TFG
{
    public partial class Ver : Form
    {
        public Ver()
        {
            InitializeComponent();
        }

        private void Ver_Load(object sender, EventArgs e)
        {




            List<agregar> agregars = new CN_Agregar().Listar();

            foreach (agregar item in agregars)
            {

                dgvdata.Rows.Add(new object[] { item.Iduser, item.Username,item.last_maintence,item.Realice_Maintence });



            }

        }
    }
}
