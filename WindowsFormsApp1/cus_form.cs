using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class cus_form : Form
    {
        public cus_form()
        {
            InitializeComponent();
           
            entities ent = new entities();
            var i = (from it in ent.customers

                     select it);
            foreach (customer e in i)
            {
                comboBox1.Items.Add(e.customer_name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entities ent = new entities();
                customer s = new customer();
                s.customer_name = comboBox1.Text;
                s.fax = textBox1.Text;
                s.telephone = textBox2.Text;
                s.mobile = textBox3.Text;
                s.email = textBox4.Text;
                s.website = textBox5.Text;
                ent.customers.Add(s);
                ent.SaveChanges();
                MessageBox.Show("customer added");
                comboBox1.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                customer s = new customer();
                String name = comboBox1.Text;
                entities ent = new entities();
                s = (from wa in ent.customers
                     where wa.customer_name == name
                     select wa).First();



                s.fax = textBox1.Text;
                s.telephone = textBox2.Text;
                s.mobile = textBox3.Text;
                s.email = textBox4.Text;
                s.website = textBox5.Text;

                ent.SaveChanges();
                MessageBox.Show("customer updated");
                comboBox1.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("failed");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer s = new customer();
            String name = comboBox1.Text;
            entities ent = new entities();
            s = (from wa in ent.customers
                 where wa.customer_name== name
                 select wa).First();



            textBox1.Text = s.fax;
            textBox2.Text = s.telephone;
            textBox3.Text = s.mobile;
            textBox4.Text = s.email;
            textBox5.Text = s.website;
        }
    }
}
