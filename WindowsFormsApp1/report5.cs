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
    public partial class report5 : Form
    {
        public report5()
        {
            InitializeComponent();
        }

        private void report5_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            entities ent = new entities();
            var U = (from it in ent.Items


                     select it);
            foreach (Item it in U)
            {
                var supply = (from exp in it.supplying_permit_items
                              where exp.exp_date >= (dateTimePicker1.Value.AddDays(-5))
                              select exp);


                var exc = (from exp in it.exchane_permit_items
                           where exp.exp_date >= (dateTimePicker1.Value.AddDays(-5))
                           select exp);
                foreach (supplying_permit_items i in supply)
                {
                    listBox1.Items.Add(i.item_name.Trim() + " in " + i.supplying_permit.warehouse.warehouse_name.Trim() + " supplied by " + i.supplying_permit.supplier_name.Trim() +" days  to expire "+(i.exp_date.Value-dateTimePicker1.Value).TotalDays );
                }
                foreach (exchane_permit_items i in exc)
                {
                    listBox1.Items.Add(i.item_name.Trim() + " in " + i.exchang_permit.warehouse.warehouse_name.Trim() + " supplied by " + i.supplier_name.Trim() + " days  to expire " + (i.exp_date.Value - dateTimePicker1.Value ).TotalDays);
                }



            }
        }
    }
}
