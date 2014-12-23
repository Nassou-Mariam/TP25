using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP1.DataSet1TableAdapters;


namespace TP1.PackageStagiaires
{
    public partial class FormGestionStagiaires : Form
    {
       
        public FormGestionStagiaires()
        {
            InitializeComponent();
        }
       
        private void FormGestionStagiaires_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStagiaire fs = new FormStagiaire();
            fs.ShowDialog();
            this.Actualiser();
        }
        public void Actualiser()
        {
            this.dataGridView1.DataSource = null;
            DataSet1 ds = new DataSet1();
            new GroupeTableAdapter().Fill(ds.Groupe);
            new StagiaireTableAdapter().Fill(ds.Stagiaire);
            this.dataGridView1.DataSource = ds.Stagiaire.ToList<DataSet1.StagiaireRow>();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
            FormUpdateStagiaire fus = new FormUpdateStagiaire();
            fus.remplir(id);
            fus.ShowDialog();
            this.Actualiser();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
            if (MessageBox.Show(null, "Ete vous sur de vouloir suppimer ce stagiere", "Confirmation de supprission", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataSet1.StagiaireRow Str = new StagiaireTableAdapter().GetData().FindByIdS(id);
                Str.Delete();
                new StagiaireTableAdapter().Update(Str);
                this.Actualiser();
            }
            else
            {

                MessageBox.Show(null, "Suppression a ete anuler", "Supprimer");
            }
        }
    }
}
