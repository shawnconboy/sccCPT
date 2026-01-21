// Shawn Conboy
// CPT 185 A01H
// Lab 10 Database


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sConboyLab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cityBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.populationDBDataSet);

                // update on save
                updateTotalPopulation();
                updateAvgPopulation();
                getHighPop();
                getLowPop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
                this.cityTableAdapter.Fill(this.populationDBDataSet.City);

                // update data
                updateTotalPopulation();
                updateAvgPopulation();
                getHighPop();
                getLowPop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // methods to do arithmatic stuff
        private void getLowPop()
        {
            try
            {
                double low = cityTableAdapter.minPop().Value;
                lowestPopLabel.Text = low.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getHighPop()
        {
            try
            {
                double high = cityTableAdapter.maxPop().Value;
                highestPopLabel.Text = high.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateAvgPopulation()
        {
            try
            {
                double avg = cityTableAdapter.averagePopulation().Value;
                AveragePopLabel.Text = avg.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateTotalPopulation()
        {
            try
            {
                double total = cityTableAdapter.totalPopulation().Value;
                totalPopLabel.Text = total.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // methods to sort
        private void sortPopAscButton_Click(object sender, EventArgs e)
        {
            try
            {
                cityBindingSource.Sort = "Population ASC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sortPopDscButton_Click(object sender, EventArgs e)
        {
            try
            {
                cityBindingSource.Sort = "Population DESC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sortCitiesButton_Click(object sender, EventArgs e)
        {
            try
            {
                cityBindingSource.Sort = "City ASC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // exit, my dude
        private void exitButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
