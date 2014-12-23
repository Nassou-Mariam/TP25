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
    public partial class FormUpdateGroupe : Form
    {
        public FormUpdateGroupe()
        {
            InitializeComponent();
        }
        public void Remplir(int id)
        {
            DataSet1.GroupeRow gr = new GroupeTableAdapter().GetData().FindByIdG(id);
            this.TxtId.Text = gr.IdG.ToString();
            this.TxtNom.Text = gr.NomG;
        }
        private void FormUpdateGroupe_Load(object sender, EventArgs e)
        {
            this.TxtId.Enabled = false;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            DataSet1.GroupeRow gr = new GroupeTableAdapter().GetData().FindByIdG(Convert.ToInt32(this.TxtId.Text));
            gr.NomG = this.TxtNom.Text;
            new GroupeTableAdapter().Update(gr);
            this.Close();
           
        }
    }
}
