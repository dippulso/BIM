using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bim
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        private object lol;
        public Form2()
        {
            InitializeComponent();
        }
        public void ShowForm(List<Form2.Elems> elems)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = (object)elems;
            lol = (object)elems;
            ShowDialog();
        }

        public class Elems
        {
            public ElementId ID { get; set; }
            public string name { get; set; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", textBox1.Text);
            List<Elems>  lol1 = (List<Elems>)lol;
            var result = lol1.Where(x =>
            x.name.Contains(textBox1.Text)).ToList();
            dataGridView1.DataSource = result;
        }
    }
}
