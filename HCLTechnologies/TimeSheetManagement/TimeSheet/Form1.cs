using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TimeSheet
{
    public partial class Form1 : Form
    {
        int MDIChildIndex;
        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayAsMDIChild(Form frm)
        {
            if (ContainsChildForm(frm))
            {
                this.MdiChildren[MDIChildIndex].BringToFront();
            }
            else
            {
                Form newMDIChild = frm;
                // Set the Parent Form of the Child window.
                newMDIChild.Top = this.pictureBox1.Height;
                newMDIChild.Left = 0;
                newMDIChild.Height = this.Height - this.pictureBox1.Height - 45;
                newMDIChild.Width = this.Width - 30;
                newMDIChild.MdiParent = this;
                // Display the new form.
                newMDIChild.TopMost = true;
                newMDIChild.Show();
                this.pictureBox3.SendToBack();
            }
            

        }
        //private void cmdExit_Click(object sender, EventArgs e)
        //{

        //    int i = this.MdiChildren.Length;
        //    if (i > 0)
        //    {
        //        this.MdiChildren[i - 1].Close();
        //    }
        //    else
        //    {
        //        Application.Exit();
        //    }
             
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    MdiClient ctlMDI;
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = this.BackColor;
               }
                catch
                {
                    // Catch and ignore the error if casting failed.
                }
            }
            //this.pictureBox1.Left = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new frmUser();
            DisplayAsMDIChild(frm);
         }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserMapping();
            DisplayAsMDIChild(frm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new frmActivity();
            DisplayAsMDIChild(frm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new frmProject();
            DisplayAsMDIChild(frm);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true; 
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false; 
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true; 
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }
        private bool ContainsChildForm(Form t)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (t.Name == this.MdiChildren[i].Name)
                {
                    MDIChildIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("MM:dd:yyyy hh:mm:ss");
        }

       //private void CloseActiveChild(Type t)
        //{
        //    for (int i = 0; i < this.MdiChildren.Length; i++)
        //    {
        //        if (t.IsInstanceOfType(this.MdiChildren[i]))
        //        {
        //            this.MdiChildren[i].Close();
        //        }
        //    }
        //}
        
       
        
        
       
    
      
        
        void Label5Click(object sender, EventArgs e)
        {
        	
        }
        
       
       private void Button1_MouseEnter(object sender, EventArgs e)
    
       {
       	 label6.Visible = true;
       	 
       }
    
       private void Button1_Mouseleave(object sender, EventArgs e)
       	
       {
       	 label6.Visible = false ;
       	 
       }
    
        
       private void Button1Click(object sender, EventArgs e)
        {   
        	Form frm = new Transaction();
        	DisplayAsMDIChild(frm);
        	
        }
    }
}
