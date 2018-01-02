using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Izbornik : Form
    {
        public Izbornik()
        {
            InitializeComponent();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            if (rbAktiva.Checked)
            {
                Aktiva novaAktiva = new Aktiva();
                novaAktiva.Show();
            }
            else if (rbNT.Checked)
            {
                IzvjestajONovcanomTijeku noviNT = new IzvjestajONovcanomTijeku();
                noviNT.Show();
            }
            else if (rbPasiva.Checked)
            {
                Pasiva novaPasiva = new Pasiva();
                novaPasiva.Show();
            }
            else if (rbRDG.Checked)
            {
                FormIzvjestajODobiti noviIzvjestajODobiti = new FormIzvjestajODobiti();
                noviIzvjestajODobiti.Show();
            }
            else
            {
                MessageBox.Show("Odaberite dokument za koji želide dodati informacije");
            }
        }

        private void btnVidi_Click(object sender, EventArgs e)
        {
            if (rbAktiva.Checked)
            {
                Aktiva novaAktiva = new Aktiva(cmbGodina.SelectedText, cmbPoduzece.SelectedText);
                novaAktiva.Show();
            }
            else if (rbNT.Checked)
            {
                IzvjestajONovcanomTijeku noviNT = new IzvjestajONovcanomTijeku(cmbGodina.SelectedText, cmbPoduzece.SelectedText);
                noviNT.Show();
            }
            else if (rbPasiva.Checked)
            {
                Pasiva novaPasiva = new Pasiva(cmbGodina.SelectedText, cmbPoduzece.SelectedText);
                novaPasiva.Show();
            }
            else if (rbRDG.Checked)
            {
                FormIzvjestajODobiti noviIzvjestajODobiti = new FormIzvjestajODobiti(cmbGodina.SelectedText, cmbPoduzece.SelectedText);
                noviIzvjestajODobiti.Show();
            }
            else
            {
                MessageBox.Show("Odaberite dokument za koji želide dodati informacije");
            }
        }
    }
}
