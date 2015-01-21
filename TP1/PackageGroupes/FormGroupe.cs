using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PackageGroupes;

namespace TP1.PackageGroupes
{
    public partial class FormGroupe : Form
    {
        public FormGroupe()
        {
            InitializeComponent();
        }

        private void bntEnregistrer_Click(object sender, EventArgs e)
        {
            Groupe g = new Groupe(int.Parse(txtId.Text), txtNom.Text);
            new GestionGroupes().Ajouter(g);
            this.Hide();
        }
    }
}
