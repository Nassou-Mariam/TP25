using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TP1.PackageGroupes
{
    public partial class GroupeRow : Component
    {
        public GroupeRow()
        {
            InitializeComponent();
        }

        public GroupeRow(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
