using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP1.PackageGroupes;
using TP1.DataSet1TableAdapters;

namespace TP1.PackageStagiaires

{
    public partial class FormUpdateStagiaire : Form
    {
      
        public FormUpdateStagiaire()
        {
            InitializeComponent();
        }
        public void charger()
        {
            this.CmbGroupe.DataSource = new GroupeTableAdapter().GetData();
            this.CmbGroupe.DisplayMember = "NomG";
            this.CmbGroupe.ValueMember = "IdG";
        }                             
        public void remplir(int id)
        {
            DataSet1.StagiaireRow sr = new StagiaireTableAdapter().GetData().FindByIdS(id);
            this.TxtId.Text = sr.IdS.ToString();
            this.TxtNom.Text = sr.NomS;
            this.TxtPrenom.Text = sr.PrenomS;
            this.CmbGroupe.SelectedValue = sr.__IdG;
        }
       
        private void FormUpdateStagiaire_Load(object sender, EventArgs e)
        {
            this.TxtId.Enabled = false;
            this.charger();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1.StagiaireRow sr = new StagiaireTableAdapter().GetData().FindByIdS(int.Parse(this.TxtId.Text));
            sr.NomS = this.TxtNom.Text;
            sr.PrenomS = this.TxtPrenom.Text;
            sr.__IdG = (int)this.CmbGroupe.SelectedValue;
            new StagiaireTableAdapter().Update(sr);
            this.Close();
        }
    }
}
