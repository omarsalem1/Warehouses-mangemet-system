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
    public partial class WG : Form
    {
        public WG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {try { 
            entities ent = new entities();
            warehouse w = new warehouse();
            w.warehouse_id = int.Parse(textBox1.Text);
            w.warehouse_name = textBox2.Text;
            w.mgr_id = int.Parse(textBox4.Text);
            w.address = textBox3.Text;
            ent.warehouses.Add(w);
            ent.SaveChanges();
            MessageBox.Show("warehouse added");
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;}
            catch
            {
                MessageBox.Show("ID can't take this value");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                warehouse w = new warehouse();
                int id = int.Parse(textBox1.Text);
                entities ent = new entities();
                w = (from wa in ent.warehouses
                     where wa.warehouse_id == id
                     select wa).First();
                w.warehouse_name = textBox2.Text;
                w.address = textBox3.Text;
                w.mgr_id = int.Parse(textBox4.Text);
                ent.SaveChanges();
                MessageBox.Show("warehouse updated");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = string.Empty;


            }
            catch { MessageBox.Show("no warehouse with this id"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
