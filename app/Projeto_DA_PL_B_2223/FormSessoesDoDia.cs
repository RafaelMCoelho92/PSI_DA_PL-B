﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA_PL_B_2223
{
    public partial class FormSessoesDoDia : Form
    {
        public FormSessoesDoDia()
        {
            InitializeComponent();
        }

        public TabPage getPage()
        {
            return tabControl1.TabPages[0];
        }
    }
}
