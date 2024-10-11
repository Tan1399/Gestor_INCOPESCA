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
    public partial class VerTotalPesqueraAcuícola : Form
    {
        public VerTotalPesqueraAcuícola()
        {
            InitializeComponent();
        }
        private sqlControl baseDeDatos = new sqlControl();
        private sqlControl baseDeDatos1 = new sqlControl();
        private sqlControl baseDeDatos2 = new sqlControl();
        private sqlControl baseDeDatos3 = new sqlControl();
        private sqlControl baseDeDatos4 = new sqlControl();
        private sqlControl baseDeDatos5 = new sqlControl();
        private sqlControl baseDeDatos6 = new sqlControl();
        private sqlControl baseDeDatos7 = new sqlControl();
        private sqlControl baseDeDatos8 = new sqlControl();
        private sqlControl baseDeDatos9 = new sqlControl();
        private sqlControl baseDeDatos10 = new sqlControl();
        private sqlControl baseDeDatos11 = new sqlControl();

        public void volver()
        {

            OpcionesPesquera op = new OpcionesPesquera();
            op.Show();


        }

        private void VerTotalPesqueraAcuícola_Load(object sender, EventArgs e)
        {
            int totalPersonasAsignadas = baseDeDatos.ContarFilasPorColumna3("Persona_Asignada");
            int totaltipo = baseDeDatos1.ContarFilasPorColumna3("Tipo");
            int totalValor = baseDeDatos2.ContarFilasPorColumna3("Valor");
            int totalModelo = baseDeDatos3.ContarFilasPorColumna3("Modelo");
            int totalMarca = baseDeDatos4.ContarFilasPorColumna3("Marca");
            int totalserie = baseDeDatos5.ContarFilasPorColumna3("No_Serie");
            int totalfecha = baseDeDatos6.ContarFilasPorColumna3("Fecha_Agregado");
            int totaltraslado = baseDeDatos7.ContarFilasPorColumna3("Traslado");
            int totalFechaTraslado = baseDeDatos8.ContarFilasPorColumna3("Fecha_Traslado");
            int totalLugarTraslado = baseDeDatos9.ContarFilasPorColumna3("Lugar_Traslado");
            int totalMantenimiento = baseDeDatos10.ContarFilasPorColumna3("Mantenimiento");
            int totalultimomantenimiento = baseDeDatos11.ContarFilasPorColumna3("Ultimo_Mantenimiento");

            label13.Text = $"{totalPersonasAsignadas}";
            label14.Text = $"{totaltipo}";
            label15.Text = $"{totalValor}";
            label16.Text = $"{totalModelo}";
            label17.Text = $"{totalMarca}";
            label18.Text = $"{totalserie}";
            label19.Text = $"{totalfecha}";
            label20.Text = $"{totaltraslado}";
            label21.Text = $"{totalFechaTraslado}";
            label22.Text = $"{totalLugarTraslado}";
            label23.Text = $"{totalMantenimiento}";
            label24.Text = $"{totalultimomantenimiento}";


        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();

        }
    }
}
