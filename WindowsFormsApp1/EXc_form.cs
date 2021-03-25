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
    public partial class EXc_form : Form
    {
        public EXc_form()
        {
            InitializeComponent();
            entities ent = new entities();
            var i = (from it in ent.suppliers

                     select it);
            foreach (supplier e in i)
            {
                comboBox3.Items.Add(e.supplier_name);
            }
            var U = (from it in ent.warehouses

                     select it);
            foreach (warehouse e in U)
            {
                comboBox2.Items.Add(e.warehouse_id);
                comboBox5.Items.Add(e.warehouse_id);
            }
            var items = (from it in ent.Items

                         select it);
            foreach (Item e in items)
            {
                comboBox4.Items.Add(e.Item_name);
            }

            var permits = (from it in ent.exchang_permit

                           select it);
            foreach (exchang_permit e in permits)
            {
                comboBox1.Items.Add(e.exc_permit_id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entities ent = new entities();
                exchang_permit s = new exchang_permit();
                exchane_permit_items si = new exchane_permit_items();
                s.exc_permit_id = int.Parse(comboBox1.Text);
                si.exc_permit_id = int.Parse(comboBox1.Text);
                s.warehouse_in_id = int.Parse(comboBox2.Text);
                s.warehouse_out_id = int.Parse(comboBox5.Text);
                si.supplier_name = comboBox3.Text;
                si.item_name = comboBox4.Text;
                si.prod_date = dateTimePicker1.Value;
                si.amount = int.Parse(textBox3.Text);
                si.exp_date = dateTimePicker2.Value;
                ent.exchang_permit.Add(s);
                ent.exchane_permit_items.Add(si);
                ent.SaveChanges();
                comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = textBox3.Text = string.Empty;
                MessageBox.Show("permit added");
            }
            catch { MessageBox.Show("failed"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                exchang_permit s = new exchang_permit();
                int id = int.Parse(comboBox1.Text);
                entities ent = new entities();
                s = (from wa in ent.exchang_permit
                     where wa.exc_permit_id == id
                     select wa).First();
                s.warehouse_in_id = int.Parse(comboBox2.Text);
                s.warehouse_out_id = int.Parse(comboBox5.Text);
               exchane_permit_items si = new exchane_permit_items();
                string name = comboBox4.Text;
                si = (from wa in ent.exchane_permit_items
                      where wa.exc_permit_id == id && wa.item_name == name
                      select wa).First();
                si.supplier_name = comboBox3.Text;
                si.prod_date = dateTimePicker1.Value;
                si.amount = int.Parse(textBox3.Text);
                si.exp_date = dateTimePicker2.Value;
                ent.SaveChanges();


            }
            catch { MessageBox.Show("enter a valid data"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                exchang_permit s = new exchang_permit();
                int id = int.Parse(comboBox1.Text);
                entities ent = new entities();
                s = (from wa in ent.exchang_permit
                     where wa.exc_permit_id == id
                     select wa).First();
                exchane_permit_items si = new exchane_permit_items();
                si.exc_permit_id = id;
                si.supplier_name = comboBox3.Text;
                si.item_name = comboBox4.Text;
                si.prod_date = dateTimePicker1.Value;
                si.amount = int.Parse(textBox3.Text);
                si.exp_date = dateTimePicker2.Value;
                ent.exchane_permit_items.Add(si);
                ent.SaveChanges();
                comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = textBox3.Text = string.Empty;
                MessageBox.Show("item added");

            }
            catch { MessageBox.Show("enter a valid data"); }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            exchang_permit s = new exchang_permit();
            int id = int.Parse(comboBox1.Text);
            entities ent = new entities();
            s = (from wa in ent.exchang_permit
                 where wa.exc_permit_id == id
                 select wa).First();
           comboBox2.Text =s.warehouse_in_id .ToString();
           comboBox5.Text = s.warehouse_out_id .ToString();
            exchane_permit_items si = new exchane_permit_items();
           
            si = (from wa in ent.exchane_permit_items
                  where wa.exc_permit_id == id
                  select wa).First();
            comboBox4.Text = si.item_name;

            comboBox3.Text = si.supplier_name;
         dateTimePicker1.Value = (DateTime) si.prod_date ;
          textBox3.Text = si.amount.ToString();
            dateTimePicker2.Value = (DateTime)si.exp_date;
            

        }
    }
}
