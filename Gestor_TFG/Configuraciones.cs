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
    public partial class Configuraciones : Form
    {


        public Configuraciones()
        {
            InitializeComponent();
        }


        public void menu() {

            Menu menu = new Menu();
            menu.Show();
    ;        
        
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu();


        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

           

            string new_user = textBox1.Text;
            string new_pass = textBox2.Text;

            if (new_user == "" || new_pass=="") {

                MessageBox.Show("new user o new pass no pueden estar vacíos");
                return;
            }

          /*  if (new_pass == "")
            {

                MessageBox.Show("Error deben ir datos en el ");
                return;
            }*/

            sqlControl sqlControl = new sqlControl();
            bool sucess = sqlControl.cambiar_usuario(new_user, new_pass);

            if (sucess)
            {

                MessageBox.Show("Datos actualizados");


            }

            else
            {

                MessageBox.Show("Error a la hora de cambiar los datos");

            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
