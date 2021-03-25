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
    public partial class WHreport : Form
    {
        entities ent;
        public WHreport()
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
            var wh = (from it in ent.warehouses
                      where it.warehouse_id == whID

                      select it);
            foreach (warehouse w in wh)
            {
                var supp_p = (from it in w.supplying_permit
                              select it);
                foreach (supplying_permit s in supp_p)
                {
                    var supp_p_item = (from it in s.supplying_permit_items
                                  select it);
                    foreach (supplying_permit_items si in supp_p_item)
                    {
                        listBox1.Items.Add("supplying permit : " + s.supp_permit_id + "  " + s.supplier_name + " " + si.amout + "   " + si.item_name );
                    }


                    }
                var sell_p = (from it in w.selling_permit
                              select it);
                foreach (selling_permit s in sell_p)
                {
                    var supp_p_item = (from it in s.selling_permit_items
                                       select it);
                    foreach (selling_permit_items si in supp_p_item)
                    {
                        listBox1.Items.Add("selling permit : " + s.sell_permit_id + "  " + s.permit_date + "  " + si.amount + "   " + si.item_name);
                    }


                }
                var exc_p = (from it in w.exchang_permit
                              select it);
                foreach (exchang_permit s in exc_p)
                {
                    var exc_p_item = (from it in s.exchane_permit_items
                                       select it);
                    foreach (exchane_permit_items si in exc_p_item)
                    {
                        listBox1.Items.Add("exchange permit in : " + s.exc_permit_id + "  " + si.supplier_name + "  " + si.amount + "   " + si.item_name );
                    }


                }
                var exc_p_o = (from it in w.exchang_permit1
                             select it);
                foreach (exchang_permit s in exc_p_o)
                {
                    var exc_p_item = (from it in s.exchane_permit_items
                                      select it);
                    foreach (exchane_permit_items si in exc_p_item)
                    {
                        listBox1.Items.Add("exchange permit out : " + s.exc_permit_id + "  " + si.supplier_name + "  " + si.amount + "   " + si.item_name) ;
                    }


                }


            }


        }
    }
}
