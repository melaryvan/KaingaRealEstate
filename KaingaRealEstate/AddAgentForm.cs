﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaingaRealEstate
{
    public partial class AddAgentForm : Form
    {
        private DataController DC;
        private AssistantAdministratorMainForm frmMenu;
        public AddAgentForm(DataController dc, AssistantAdministratorMainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }
    }
}
