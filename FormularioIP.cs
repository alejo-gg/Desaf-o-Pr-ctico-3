using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_3
{
    public partial class FormularioIP : Form
    {
        public string DireccionIP { get; set; }
        public string DireccionRed { get; set; }

        private string tipoDispositivo;

        public FormularioIP()
        {
            InitializeComponent();
            this.tipoDispositivo = tipoDispositivo;
            lblTipo.Text = $"Tipo: {tipoDispositivo}";

            if (tipoDispositivo == "PC")
            {
                lblRed.Visible = false;
                txtDireccionRed.Visible = false;
            }
        }

        public FormularioIP(string tipoDispositivo) : this()
        {
            lblTipo.Text = $"Tipo: {tipoDispositivo}";

            if (tipoDispositivo == "PC")
            {
                lblRed.Visible = false;
                txtDireccionRed.Visible = false;
            }
        }

        private void btnGuardarIP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccionIP.Text))
            {
                MessageBox.Show("Debe ingresar una dirección IP válida.");
                return;
            }

            DireccionIP = txtDireccionIP.Text;
            DireccionRed = txtDireccionRed.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarIP_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
