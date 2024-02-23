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
    public partial class opciones : Form
    {


        public void agregar() {

            AgregarForm agr = new AgregarForm();
            agr.Show();
        
        
        }

        public void ver() {


            Ver ver = new Ver();
            ver.Show();
        
        }


        
        public opciones()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*agregarname agrn = new agregarname();
            agrn.Show();*/
            agregar();





        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ver();



        }
    }
}
