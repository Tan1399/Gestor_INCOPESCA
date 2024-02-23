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
    public partial class Login : Form
    {

        sqlControl sqlControl = new sqlControl();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {






        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //validación de si el usuario existe en la bd
            int result = sqlControl.Login(textBox1.Text, textBox2.Text);
            if (result == 1)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();


            }

            else if (result == 0)
            {

                MessageBox.Show("Error usuario o contraseña incorrecta");




            }

        }
    }
}
