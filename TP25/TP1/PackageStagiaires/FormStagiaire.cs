using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP1.PackageGroupes;
using TP1.DataSet1TableAdapters;



namespace TP1.PackageStagiaires
{
    public partial class FormStagiaire : Form
    {
        
        public FormStagiaire()
        {
            InitializeComponent();
        }
        public void charger()
        {
            this.CmbGroupe.DataSource = new GroupeTableAdapter().GetData();
            this.CmbGroupe.DisplayMember = "NomG";
            this.CmbGroupe.ValueMember = "IdG";
        }                                          
        private void FormStagiaire_Load(object sender, EventArgs e)
        {
            this.charger();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StagiaireTableAdapter sta = new StagiaireTableAdapter();
            sta.Insert(this.TxtNom.Text, this.TxtPrenom.Text,Convert.ToInt32(this.CmbGroupe.SelectedValue));
            this.Close();
        }
    }
}
