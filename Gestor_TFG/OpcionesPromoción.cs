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
    public partial class OpcionesPromoción : Form
    {
        public OpcionesPromoción()
        {
            InitializeComponent();
        }

        public void promocion_registro()
        {

            AgregarPromocion ag = new AgregarPromocion();
            ag.Show();

        }

        public void borrar_promocion()
        {
            BorrarActivoPromoción br = new BorrarActivoPromoción();
            br.Show();

        }
        public void editar_promocion()
        {
            EditarPromocion ed = new EditarPromocion();
            ed.Show();

        }

        public void ver_promocion()
        {
            VerPromocion vr = new VerPromocion();
            vr.Show();

        }

        public void volver()
        {
            Menu mn = new Menu();
            mn.Show();


        }
        public void vertotal()
        {

           VerTotalPromocionMercados vt = new VerTotalPromocionMercados();

            vt.Show();



        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            promocion_registro();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            editar_promocion();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ver_promocion();
            this.Hide();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            borrar_promocion();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            vertotal();
            this.Hide();
        }
    }
}
