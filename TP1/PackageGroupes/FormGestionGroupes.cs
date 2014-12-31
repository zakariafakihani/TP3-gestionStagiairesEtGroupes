using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP1.PackageGroupes
{
    public partial class FormGestionGroupes : Form
    {
        public FormGestionGroupes()
        {
            InitializeComponent();
            Actualiser();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormGroupe Ajouter = new FormGroupe();
            Ajouter.ShowDialog();
            Actualiser();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            FormUpdateGroupe Update = new FormUpdateGroupe();
            Update.Update(index);
            Update.ShowDialog();
            Actualiser();
        }

        public void Actualiser()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new GestionGroupes().Afficher();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            Groupe g = new GestionGroupes().getGroupe(index);
            DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer le Groupe " + g.Nom ,"Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                new GestionGroupes().Supprimer(index);
                Actualiser();
            }
            else
                MessageBox.Show("Supression annuler");
        }
    }
}
