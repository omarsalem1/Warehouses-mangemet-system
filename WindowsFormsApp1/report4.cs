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
    public partial class report4 : Form
    {
        public report4()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            entities ent = new entities();
            var U = (from it in ent.Items


                     select it);
            foreach (Item it in U)
            {
                var supply = (from exp in it.supplying_permit_items
                              where exp.prod_date <= (dateTimePicker1.Value)
                              select exp);

                var sold = (from exp in it.selling_permit_items
                            where exp.selling_permit.permit_date <= dateTimePicker1.Value
                            select exp);


                var exc = (from exp in it.exchane_permit_items
                           where exp.prod_date <= dateTimePicker1.Value
                           select exp);
                foreach (supplying_permit_items i in supply)
                {
                    listBox1.Items.Add(i.item_name.Trim() + " in " + i.supplying_permit.warehouse.warehouse_name.Trim() + " supplied by " + i.supplying_permit.supplier_name.Trim() + " stayed for " + (dateTimePicker1.Value - i.prod_date.Value).TotalDays + " days");
                }
                foreach (selling_permit_items i in sold)
                {
                   listBox1.Items.Add(i.item_name.Trim() + " in " + i.selling_permit.warehouse.warehouse_name.Trim() + " supplied by " + i.supplier_name.Trim() + " sold from " + (dateTimePicker1.Value - i.selling_permit.permit_date.Value).TotalDays + " days");
                }
                foreach (exchane_permit_items i in exc)
                {
                    listBox1.Items.Add(i.item_name.Trim() + " in " + i.exchang_permit.warehouse1.warehouse_name.Trim() + " supplied by " + i.supplier_name.Trim() + " exchanged from " + (dateTimePicker1.Value - i.prod_date.Value).TotalDays + " days");
                }




            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //entities ent = new entities();
            //var U = (from it in ent.Items


            //         select it);
            //foreach (Item it in U)
            //{
            //    var supply = (from exp in it.supplying_permit_items
            //                  where exp.prod_date <= (dateTimePicker1.Value)
            //                  select exp);

            //    var sold = (from exp in it.selling_permit_items
            //               where exp.selling_permit.permit_date <= dateTimePicker1.Value
            //               select exp);


            //    var exc = (from exp in it.exchane_permit_items
            //               where exp.prod_date <= dateTimePicker1.Value
            //               select exp);
            //    foreach (supplying_permit_items i in supply)
            //    {
            //        listBox1.Items.Add(i.item_name.Trim() + " in " + i.supplying_permit.warehouse.warehouse_name.Trim() + " supplied by " + i.supplying_permit.supplier_name.Trim() + " stayed for " + (dateTimePicker1.Value-i.prod_date.Value  ).TotalDays+" days");
            //    }
            //    foreach (selling_permit_items i in sold) {
            //        listBox1.Items.Add(i.item_name.Trim() + " in " + i.selling_permit.warehouse.warehouse_name.Trim() + " supplied by " + i.supplier_name.Trim() + " sold from " + (dateTimePicker1.Value - i.selling_permit.permit_date.Value).TotalDays + " days");
            //    }
            //    foreach (exchane_permit_items i in exc)
            //    {
            //        listBox1.Items.Add(i.item_name.Trim() + " in " + i.exchang_permit.warehouse1.warehouse_name.Trim() + " supplied by " + i.supplier_name.Trim() + " exchanged from " + (dateTimePicker1.Value-i.prod_date.Value).TotalDays + " days");
            //    }
                



            //}

        }
    }
}
