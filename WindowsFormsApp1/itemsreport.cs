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
    public partial class itemsreport : Form
    {  entities ent;
        public itemsreport()
        {
            InitializeComponent();
            ent = new entities();
            var U = (from it in ent.Items

                     select it);
            foreach (Item e in U)
            {
                comboBox1.Items.Add(e.Item_name);

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string name = comboBox1.Text;
            Item it = (from ite in ent.Items
                       where ite.Item_name == name
                       select ite).First();
            var supplying_permits = (from Supp in it.supplying_permit_items
                                     select Supp);
            foreach (supplying_permit_items s in supplying_permits)
            {
                supplying_permit s_p = (from sp in ent.supplying_permit
                             where sp.supp_permit_id==s.supp_permit_id
                             select sp).First();
                listBox1.Items.Add(it.Item_name.Trim() + " has been supplied to warehouse : " + s_p.warehouse.warehouse_name.Trim() + " with amount of " + s.amout +" by : "+s_p.supplier_name);

            }
            var item_sell = it.selling_permit_items;
            foreach (selling_permit_items sell in item_sell) {
                selling_permit sell_permit = sell.selling_permit;
                listBox1.Items.Add(it.Item_name.Trim() + " has been sold to warehouse : " + sell_permit.warehouse.warehouse_name.Trim() + " with amount of " + sell.amount);
            }
            var item_exc = it.exchane_permit_items;
            foreach (exchane_permit_items ex in item_exc)
            {
                exchang_permit ex_permit = ex.exchang_permit;
                listBox1.Items.Add(it.Item_name.Trim() + " has been exchanged from : " +ex_permit.warehouse1.warehouse_name.Trim() + " to "+ex_permit.warehouse.warehouse_name.Trim()+ " with amount of " + ex.amount);
            }


        }
    }
}
