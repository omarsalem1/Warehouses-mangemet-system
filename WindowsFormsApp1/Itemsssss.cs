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
    public partial class Itemsssss : Form
    {
        public Itemsssss()
        {
            InitializeComponent();
            entities ent = new entities();
            var i = (from it in ent.Items
                     
                     select it);
            foreach(Item e in i)
            {
                comboBox1.Items.Add(e.Item_name);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                entities ent = new entities();
                Item  i= new Item();
                item_units i_u = new item_units();

               i.Item_name= comboBox1.Text;
                i_u.item_name = comboBox1.Text;
                i.Item_code = int.Parse(textBox2.Text);
            i_u.Item_unit = textBox3.Text;
                ent.Items.Add(i);
                ent.item_units.Add(i_u);
                ent.SaveChanges();
                MessageBox.Show("item added");
                comboBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            item_units i_u = new item_units();
            entities ent = new entities();

            i_u.item_name = comboBox1.Text;
            i_u.Item_unit = textBox3.Text;


            ent.item_units.Add(i_u);
            ent.SaveChanges();
            MessageBox.Show("item unit added");
            comboBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            Item i = new Item();
            
            String name = comboBox1.Text;
            entities ent = new entities();
            i = (from wa in ent.Items
                 where wa.Item_name == name
                 select wa).First();
                i.Item_code =int.Parse (textBox2.Text);
            ent.SaveChanges();
            MessageBox.Show("warehouse updated");
            comboBox1.Text = textBox2.Text = textBox3.Text= string.Empty;}
            catch
            {
                MessageBox.Show("there's no item with this name");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item i = new Item();

            String name = comboBox1.Text;
            entities ent = new entities();
            i = (from wa in ent.Items
                 where wa.Item_name == name
                 select wa).First();
         textBox2.Text =  i.Item_code .ToString();
            comboBox1.Text = i.Item_name;

        }
    }
}
