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
    public partial class report1 : Form
    {
        entities ent;
        public report1()
        {
            InitializeComponent();
            ent = new entities();
            var U = (from it in ent.warehouses

                     select it);
            foreach (warehouse e in U)
            {
                comboBox1.Items.Add(e.warehouse_id);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            int whID = int.Parse(comboBox1.Text);
            warehouse wh = (from it in ent.warehouses
                      where it.warehouse_id == whID

                      select it).First();
           
            var supplying_permits = (from it in wh.supplying_permit
                                     select it);
            foreach(supplying_permit s in supplying_permits)
            {
                var items = (from it in s.supplying_permit_items
                                         select it);
                foreach(supplying_permit_items i in items)
                {
                    listBox1.Items.Add(" item " + i.item_name.Trim() + " supplied with amount " + i.amout);
                }

            }
            var sell_per = (from it in wh.selling_permit
                                     select it);
            foreach (selling_permit s in sell_per)
            {
                var items = (from it in s.selling_permit_items
                             select it);
                foreach (selling_permit_items i in items)
                {
                    listBox1.Items.Add(" item " + i.item_name.Trim() + " sold with amount " + i.amount);
                }

            }
            var ex_permit = (from it in wh.exchang_permit
                            select it);
            foreach (exchang_permit s in ex_permit)
            {
                var items = (from it in s.exchane_permit_items
                             select it);
                foreach (exchane_permit_items i in items)
                {
                    listBox1.Items.Add("item " + i.item_name.Trim() + "  exchanged into with amount " + i.amount);
                }

            }
            var ex_permit_out = (from it in wh.exchang_permit1
                             select it);
            foreach (exchang_permit s in ex_permit_out)
            {
                var items = (from it in s.exchane_permit_items
                             select it);
                foreach (exchane_permit_items i in items)
                {
                    listBox1.Items.Add("item " + i.item_name.Trim() + " exchanged from with amount  " + i.amount);
                }

            }

        }
    }
}
