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
    public partial class selling_form : Form
    {
        public selling_form()
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
            }
            var items = (from it in ent.Items

                         select it);
            foreach (Item e in items)
            {
                comboBox4.Items.Add(e.Item_name);
            }
            
            var permits = (from it in ent.selling_permit

                           select it);
            foreach (selling_permit e in permits)
            {
                comboBox1.Items.Add(e.sell_permit_id);
            }
        }

        private void selling_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entities ent = new entities();
                selling_permit s = new selling_permit();
                selling_permit_items si = new selling_permit_items();
                s.sell_permit_id = int.Parse(comboBox1.Text);
                si.sell_permit_id = int.Parse(comboBox1.Text);
                s.warehouse_id = int.Parse(comboBox2.Text);
                s.permit_date = dateTimePicker3.Value;
                si.item_name = comboBox4.Text;
                si.supplier_name = comboBox3.Text;
                
                si.amount = int.Parse(textBox3.Text);
                
                ent.selling_permit.Add(s);
                ent.selling_permit_items.Add(si);
                ent.SaveChanges();
                comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = textBox3.Text = string.Empty;
            }
            catch { MessageBox.Show("failed"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               selling_permit s = new selling_permit();
                int id = int.Parse(comboBox1.Text);
                entities ent = new entities();
                s = (from wa in ent.selling_permit
                     where wa.sell_permit_id == id
                     select wa).First();
                s.warehouse_id = int.Parse(comboBox2.Text);
                s.permit_date = dateTimePicker3.Value;
                selling_permit_items si = new selling_permit_items();
                string name = comboBox4.Text;
                si = (from wa in ent.selling_permit_items
                      where wa.sell_permit_id== id && wa.item_name == name
                      select wa).First();
               
                si.amount = int.Parse(textBox3.Text);
                 si.supplier_name = comboBox3.Text;
                ent.SaveChanges();


            }
            catch { MessageBox.Show("enter a valid data"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selling_permit s = new selling_permit();
            int id = int.Parse(comboBox1.Text);
            entities ent = new entities();
            s = (from wa in ent.selling_permit
                 where wa.sell_permit_id == id
                 select wa).First();
            selling_permit_items si = new selling_permit_items();
            si.sell_permit_id= id;
            si.item_name = comboBox4.Text;
            
            si.amount = int.Parse(textBox3.Text);
           
            ent.selling_permit_items.Add(si);
            ent.SaveChanges();
            comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = textBox3.Text = string.Empty;
            MessageBox.Show("item added");
        }
    }
}
