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
    public partial class FormGestionGroupes : Form
    {
        public FormGestionGroupes()
        {
            InitializeComponent();
        }
        public void Actualiser()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = new GroupeTableAdapter().GetData();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormGroupe fg = new FormGroupe();
            fg.ShowDialog();
            this.Actualiser();
        }

        private void FormGestionGroupes_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
            FormUpdateGroupe fug = new FormUpdateGroupe();
            fug.Remplir(id);
            fug.ShowDialog();
            this.Actualiser();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
            if (MessageBox.Show(null, "Ete vous sur de vouloir suppimer ce groupe", "Confirmation de supprission", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet1.GroupeRow Gr = new GroupeTableAdapter().GetData().FindByIdG(id);
                Gr.Delete();
                new GroupeTableAdapter().Update(Gr);
                this.Actualiser();
            }
            else
            {

                MessageBox.Show(null, "Suppression a ete anuler", "Supprimer");
            }
        }
    }
}
