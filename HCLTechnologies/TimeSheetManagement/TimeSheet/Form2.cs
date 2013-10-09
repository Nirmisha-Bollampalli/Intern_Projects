using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimeSheet
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Form frmMDI = new Form1();
            frmMDI.Enabled = false; 
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            Form frmMDI = new Form1();
            frmMDI.Enabled = true; 
        }
    }
}