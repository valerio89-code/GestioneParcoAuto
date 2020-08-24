using GestioneParcoAuto.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneParcoAuto
{
    public partial class AggiungiMacchina : Form
    {
        public AutoAziendale MacchinaAggiunta { get; set; }
        public AggiungiMacchina()
        {
            InitializeComponent();
        }

        private void btn_aggiungiAuto_Click(object sender, EventArgs e)
        {
            MacchinaAggiunta = new AutoAziendale()
            {
                Marca = tbxMarca.Text,
                Modello = tbxModello.Text,
                Targa = tbxTarga.Text,
                Cilindrata = tbxCilindrata.Text,
                ScadenzaAssicurazione = dtpScadenza.Value
            };
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
