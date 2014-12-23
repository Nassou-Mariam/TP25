using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP1.DataSet1TableAdapters;

namespace TP1.PackageGroupes
{
    public partial class FormGroupe : Form
    {
        public FormGroupe()
        {
            InitializeComponent();
        }
        private void FormGroupe_Load(object sender, EventArgs e)
        {
            FormGroupe fg = new FormGroupe();
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            new GroupeTableAdapter().Insert(this.TxtNom.Text);
            this.Close();
        }
    }
}
