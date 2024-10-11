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
    public partial class OpcionesRegistro : Form
    {
        public OpcionesRegistro()
        {
            InitializeComponent();
        }
        public void vertotal()
        {

            VerTotalArea vt = new VerTotalArea();

            vt.Show();



        }



        private void iconButton4_Click(object sender, EventArgs e)
        {
            vertotal();
            this.Hide();

        }



        public void area_registro() {

            AgregarArea ag = new AgregarArea();
            ag.Show();

        }

        public void borrar_area() {
            BorrarArea br = new BorrarArea();
            br.Show();

        }
        public void editar_registro()
        {
            EditarArea ed = new EditarArea();
            ed.Show();

        }

        public void ver_area() {
            VerArea vr = new VerArea();
            vr.Show();
        
        }

        public void volver() {
            Menu mn = new Menu();
            mn.Show();
        
        
        }

      



        private void iconButton1_Click(object sender, EventArgs e)
        {
            area_registro();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            editar_registro();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ver_area();
            this.Hide();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            borrar_area();
            this.Hide();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
