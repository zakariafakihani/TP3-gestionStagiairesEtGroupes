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
    public partial class FormUpdateGroupe : Form
    {
        public FormUpdateGroupe()
        {
            InitializeComponent();
        }

        public void Update(int index)
        {
            Groupe g = new GestionGroupes().getGroupe(index);
            lblId.Text = g.Id.ToString();
            txtNom.Text = g.Nom;
        }

        private void bntEnregistrer_Click(object sender, EventArgs e)
        {
            Groupe g = new Groupe(int.Parse(lblId.Text), txtNom.Text);
            new GestionGroupes().Modifier(g);
        }
    }
}
