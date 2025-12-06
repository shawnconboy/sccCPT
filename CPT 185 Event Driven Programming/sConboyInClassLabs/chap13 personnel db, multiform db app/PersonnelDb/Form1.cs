using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personnelDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personnelDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.personnelDataSet.Table);

        }

        private void seeDetailViewButton_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                DetailView dv = new DetailView();
                dv.ShowDialog();

                this.tableTableAdapter.Fill(this.personnelDataSet.Table);
                this.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
