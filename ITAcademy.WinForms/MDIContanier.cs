﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITAcademy.WinForms
{
    public partial class MDIContanier : Form
    {
        public MDIContanier()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chqngePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblLogoText.Visible = false;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblLogoText.Visible = false;
            Admission_WinForm _child = new Admission_WinForm();
            _child.MdiParent = this;
            _child.Show();

        }
        //private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Student_WinForm _child = new Student_WinForm();
        //    _child.MdiParent = this;
        //    _child.Show();

        //}

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblLogoText.Visible = false;
            Search_WinForm _child = new Search_WinForm();
            _child.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void attendenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblLogoText.Visible = false;
            ShowAllStudents _child = new ShowAllStudents();
            _child.MdiParent = this;
            _child.Show();

        }

        private void testExaminationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblLogoText.Visible = false;
            TestAndExam_WinForm _child = new TestAndExam_WinForm();
            _child.MdiParent = this;
            _child.Show();
        }

        private void MDIContanier_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.FloralWhite;
                    // 4#
                    break;
                }
            }

            //for change background image
          //  Image img = Bitmap.FromFile(@"D:\Mehtab\c#\ITAcademy\ITAcademy.WinForms\Images\bg.jpg");
            Image img = Bitmap.FromFile(@"D:\Mehtab\c#\ITAcademy\ITAcademy.WinForms\Images\ItAcademy2.png");
            this.BackgroundImage = img;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void attendenceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblLogoText.Visible = false;
            Attendence_WinForm _child = new Attendence_WinForm();
            _child.Show();
        }

        private void feeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblLogoText.Visible = false;
        }

        private void salarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblLogoText.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblLogoText.Visible = false;
            TestAndExam_WinForm _child = new TestAndExam_WinForm();
            _child.Show();
        
        }
     
    }
}
