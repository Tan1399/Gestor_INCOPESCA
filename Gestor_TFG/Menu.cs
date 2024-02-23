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
    public partial class Menu : Form
    {


        public void opciones() {



            opciones op = new opciones();
            op.Show();
        
        
        
        }
        public Menu()
        {
            InitializeComponent();
        }

        private void Dep_info_Click(object sender, EventArgs e)
        {

            this.Hide();
            opciones();

        }
    }
}
