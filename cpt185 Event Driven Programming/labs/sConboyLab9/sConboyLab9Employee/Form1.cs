//Shawn Conboy
//CPT 185 A01H
//LAB 9 EMPLOYEE


namespace sConboyLab9Employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Employee fullConstructor = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");

            Employee halfConstructor = new Employee("Mark Jones", 39119);
            halfConstructor.Department = "IT";
            halfConstructor.Position = "Programmer";

            Employee emptyConstructor = new Employee();
            emptyConstructor.Name = "Joy Rogers";
            emptyConstructor.IdNumber = 81774;
            emptyConstructor.Department = "Manufacturing";
            emptyConstructor.Position = "Engineer";

            employeeListbox.Items.Add("Name\t\tID\tDepartment\tPosition");
            employeeListbox.Items.Add("                                                    ");

            employeeListbox.Items.Add($"{fullConstructor.Name}\t{fullConstructor.IdNumber}\t{fullConstructor.Department}\t{fullConstructor.Position}");
            employeeListbox.Items.Add($"{halfConstructor.Name}\t{halfConstructor.IdNumber}\t{halfConstructor.Department}\t\t{halfConstructor.Position}");
            employeeListbox.Items.Add($"{emptyConstructor.Name}\t{emptyConstructor.IdNumber}\t{emptyConstructor.Department}\t{emptyConstructor.Position}");



        }

        public class Employee
        {
            public string Name { get; set; }
            public int IdNumber { get; set; }
            public string Department { get; set; }
            public string Position { get; set; }

            public Employee(string name, int idNumber, string department, string position)
            {
                Name = name;
                IdNumber = idNumber;
                Department = department;
                Position = position;
            }

            public Employee(string name, int idNumber)
            {
                Name = name;
                IdNumber = idNumber;
                Department = "";
                Position = "";
            }

            public Employee()
            {
                Name = "";
                IdNumber = 0;
                Department = "";
                Position = "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            employeeListbox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
