﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DB_CONNECTION
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_passager_Click(object sender, EventArgs e)
        {
            InsertPassager insertPassager = new InsertPassager();
            insertPassager.Show();
        }
    }
}