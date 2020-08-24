using GestioneParcoAuto.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneParcoAuto
{
    public partial class Form1 : Form
    {
        public BindingList<AutoAziendale> _parcoAuto = new BindingList<AutoAziendale>();
        public List<Dipendente> _dipendenti = new List<Dipendente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _parcoAuto = Helpers.GetParcoAutoFromJson();
            _dipendenti = Helpers.GetDipendentiFromJson();
            grid_auto.DataSource = _parcoAuto;
            grid_auto.Columns["Dipendente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btnAggiungiMacchina_Click(object sender, EventArgs e)
        {
            var aggiungiMacchinaForm = new AggiungiMacchina();
            var dlgResult = aggiungiMacchinaForm.ShowDialog();
            if (dlgResult != DialogResult.OK) return;
            _parcoAuto.Add(aggiungiMacchinaForm.MacchinaAggiunta);
            Helpers.SaveParcoAutoInJson(_parcoAuto);
        }

        private void btnAssociaAuto_Click(object sender, EventArgs e)
        {
            var associaMacchinaForm = new AssociaMacchina(_parcoAuto, _dipendenti);
            var dlgResult = associaMacchinaForm.ShowDialog();
            if (dlgResult != DialogResult.OK) return;
            grid_auto.Refresh();
            Helpers.SaveParcoAutoInJson(_parcoAuto);
        }
    }
}
