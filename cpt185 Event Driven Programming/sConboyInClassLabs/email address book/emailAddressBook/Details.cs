using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emailAddressBook
{
    public partial class Details : Form
    {
        Person Person;

        public Details(Person person)
        {
            InitializeComponent();
            Person = person;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            emailTextbox.Text = Person.Email;
            phoneTextbox.Text = Person.Phone;
            nameTextbox.Text = Person.Name;
        }
    }
}
