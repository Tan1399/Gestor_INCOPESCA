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
    public partial class OpcionesPesquera : Form
    {
        public OpcionesPesquera()
        {
            InitializeComponent();
        }


        public void Menu()
        {

            Menu men = new Menu();
            men.Show();
        }
        public void agregarPesquera()
        {

            AgregarPesquero agr = new AgregarPesquero();
            agr.Show();


        }

        public void verPesquera()
        {


            VerPesquero ver = new VerPesquero();
            ver.Show();

        }

        public void editarPesquera()
        {

            EditarPesquero edi = new EditarPesquero();

            edi.Show();


        }

        public void borrarPesquera()
        {

            BorrarActivoPesquero borr = new BorrarActivoPesquero();

            borr.Show();



        }

        public void vertotal()
        {

          VerTotalPesqueraAcuícola vt = new VerTotalPesqueraAcuícola();

            vt.Show();



        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            agregarPesquera();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            editarPesquera();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            vertotal();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            verPesquera();
            this.Hide();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu();
            this.Hide();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            borrarPesquera();
            this.Hide();
        }

        private void OpcionesPesquera_Load(object sender, EventArgs e)
        {
           
        }
    }
}
