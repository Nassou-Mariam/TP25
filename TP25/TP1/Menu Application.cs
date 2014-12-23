using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP1.PackageStagiaires;
using TP1.PackageGroupes;

namespace TP1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void gestionDesStagiairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionStagiaires fgs = new FormGestionStagiaires();
            fgs.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void gestionDesGroupesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionGroupes fgg = new FormGestionGroupes();
            fgg.ShowDialog();
        }
    }
}
