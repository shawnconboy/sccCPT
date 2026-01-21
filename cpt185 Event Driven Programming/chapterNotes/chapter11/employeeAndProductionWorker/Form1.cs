using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace employeeAndProductionWorker
{
    public partial class Form1 : Form
    {
        // List to hold all employee objects
        private List<Employee> employeeList = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        public class Employee
        {
            public string name;
            public string employeeID;
        }

        public class ProductionWorker : Employee
        {
            public int shiftNumber;
            public double hourlyPay;
        }

        public class Supervisor : Employee
        {
            public double annualSalary;
            public double bonus;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // on load
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // create new employee object
            ProductionWorker newEmployee = new ProductionWorker();

            // take data from textboxes
            newEmployee.name = employeeNameTextbox.Text;
            newEmployee.employeeID = employeeIDTextbox.Text;
            newEmployee.hourlyPay = double.Parse(employeeRateTextbox.Text);
            newEmployee.shiftNumber = int.Parse(employeeShiftTextbox.Text);

            // add object to list
            employeeList.Add(newEmployee);

            // show name in listbox
            employeeListbox.Items.Add(newEmployee.name);

            // clear form
            employeeNameTextbox.Clear();
            employeeIDTextbox.Clear();
            employeeRateTextbox.Clear();
            employeeShiftTextbox.Clear();

            employeeNameTextbox.Focus();
        }

        private void employeeListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int spot = employeeListbox.SelectedIndex;

            Employee selected = employeeList[spot];

            MessageBox.Show(
                $"Name: {selected.name}\n" +
                $"ID: {selected.employeeID}\n" +
                $"Shift: {selected.shiftNumber}\n" +
                $"Hourly Pay: {selected.hourlyPay:C}",
                "Employee Details"
            );
        }
    }
}
