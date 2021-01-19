using Autodesk.Revit.DB;
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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ShowForm(List<Form1.Elems> elems)
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.AutoGenerateColumns = true;
            this.Controls.Add(dataGridView);
            
            dataGridView.DataSource = (object)elems;
            dataGridView.MinimumSize = new Size()
            {
                Width = 200,
                Height = 200
            };
            //dataGridView.Show();
            ShowDialog();
        }


        public class Elems
        {
            public ElementId ID { get; set; }
            public string name { get; set; }
        }
    }
}
