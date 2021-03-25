using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WG w = new WG();
            DialogResult dr = w.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

     

        private void arabicToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag){
                case "ar-EG":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    break;
                case "en-US":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-EG");
                    break;


            }
            this.Controls.Clear();
            
            InitializeComponent();
        }

        private void المخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WG w = new WG();
            w.MdiParent = this;
            w.Show();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Itemsssss i = new Itemsssss();
            i.MdiParent = this;
            i.Show();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sform s = new sform();
            s.MdiParent = this;
            s.Show();

            
            
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cus_form c = new cus_form();
            c.MdiParent = this;
            c.Show();
        }

        private void اذنالتوريدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplyingpermit_form s = new supplyingpermit_form();
            s.MdiParent = this;
            s.Show();
        }

        private void اذنصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selling_form s = new selling_form();
            s.MdiParent = this;
            s.Show();
        }

        private void exchangePermitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXc_form ei = new EXc_form();
            ei.MdiParent = this;
            ei.Show();


        }

        private void warehouseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WHreport w = new WHreport();
            w.MdiParent = this;
            w.Show();
        }

        private void reportWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report1 r = new report1();
            r.MdiParent = this;
            r.Show();
        }

        private void reportItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemsreport i = new itemsreport();
            i.MdiParent = this;
            i.Show();
        }

        private void expiryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report5 r = new report5();
            r.MdiParent = this;
            r.Show();

        }

        private void stayedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report4 r = new report4();
            r.MdiParent = this;
            r.Show();
        }
    }
}
