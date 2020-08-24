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
    public partial class AssociaMacchina : Form
    {
        public BindingList<AutoAziendale> parcoAuto;
        public readonly List<Dipendente> dipendenti;

        public AssociaMacchina(BindingList<AutoAziendale> parcoAuto, List<Dipendente> dipendenti)
        {
            InitializeComponent();
            this.parcoAuto = parcoAuto;
            this.dipendenti = dipendenti;
        }

        private void btnAssocia_Click(object sender, EventArgs e)
        {
            if (cbxAuto.SelectedItem != null && cbxDipendenti.SelectedItem != null)
            {
                var selectedAuto = cbxAuto.SelectedItem as AutoAziendale;
                var selectedDipendente= cbxDipendenti.SelectedItem as Dipendente;
                var auto = parcoAuto.FirstOrDefault(i => i.Targa == selectedAuto.Targa);
                var dipendente = dipendenti.FirstOrDefault(i => i.Matricola == selectedDipendente.Matricola);
                auto.Dipendente = dipendente;
            }
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void AssociaMacchina_Load(object sender, EventArgs e)
        {
            foreach (var item in parcoAuto.Where(a => a.IsDisponibile()).ToList())
            {
                cbxAuto.Items.Add(item);
            }
            foreach (var item in dipendenti)
            {
                cbxDipendenti.Items.Add(item);
            }
        }
    }
}
