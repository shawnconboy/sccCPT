using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emailAddressBook_FinalStudyGuide
{
    public partial class Form2 : Form
    {
        PersonEntry PersonEntry;

        public Form2(PersonEntry person)
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nameTextbox.Text = PersonEntry.Name;
            emailTextbox.Text = PersonEntry.Email;
            phoneTextbox.Text = PersonEntry.Phone;
        }
    }
}
