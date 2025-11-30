
//Create an application with a class named PersonEntry.
//The PersonEntry class should have properties for a person’s name, e-mail address, and phone number.
//Also, create a text file that contains the names, e-mail addresses, and phone numbers for at least five people.
//When the application starts, it should read the data from the file and create a object for each person’s data.
//The objects should be added to a List, and each person’s name should be displayed in a list box on the application’s main form.
//When the user selects a name from the list box, a second form should appear displaying that person’s name, e-mail address, and phone number.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace emailAddressBook_FinalStudyGuide
{
    

    public partial class Form1 : Form
    {

        PersonEntry[] people;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] entries = File.ReadAllLines("People.txt");

            people = new PersonEntry[entries.Length];

            for(int i = 0; i < entries.Length; i++)
            {
                // tokenize entries
                string[] data = entries[i].Split('#');

                people[i] = new PersonEntry(data[0], data[1], data[2]);

                personListbox.Items.Add(people[i].Name);
            }
        }

        private void personListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(personListbox.SelectedItem.ToString());

            Form2 form2 = new Form2(people[personListbox.SelectedIndex]);
            form2.ShowDialog();
        }
    }

    //
    public class PersonEntry
    {
        public string Name { get; set; }
        
        public string Email { get; set; }

        public string Phone { get; set; }


        // default constructor
        public PersonEntry()
        {
            Name = " ";
            Email = " ";
            Phone = " ";
        }

        // passed constructor
        public PersonEntry(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

    }
}
