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
    public partial class VerTotalPromocionMercados : Form
    {
        public VerTotalPromocionMercados()
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

           OpcionesPromoción op = new OpcionesPromoción();
            op.Show();
        }

        private void VerTotalPromocionMercados_Load(object sender, EventArgs e)
        {
            int totalPersonasAsignadas = baseDeDatos.ContarFilasPorColumna5("Persona_Asignada");
            int totaltipo = baseDeDatos1.ContarFilasPorColumna5("Tipo");
            int totalValor = baseDeDatos2.ContarFilasPorColumna5("Valor");
            int totalModelo = baseDeDatos3.ContarFilasPorColumna5("Modelo");
            int totalMarca = baseDeDatos4.ContarFilasPorColumna5("Marca");
            int totalserie = baseDeDatos5.ContarFilasPorColumna5("No_Serie");
            int totalfecha = baseDeDatos6.ContarFilasPorColumna5("Fecha_Agregado");
            int totaltraslado = baseDeDatos7.ContarFilasPorColumna5("Traslado");
            int totalFechaTraslado = baseDeDatos8.ContarFilasPorColumna5("Fecha_Traslado");
            int totalLugarTraslado = baseDeDatos9.ContarFilasPorColumna5("Lugar_Traslado");
            int totalMantenimiento = baseDeDatos10.ContarFilasPorColumna5("Mantenimiento");
            int totalultimomantenimiento = baseDeDatos11.ContarFilasPorColumna5("Ultimo_Mantenimiento");

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
