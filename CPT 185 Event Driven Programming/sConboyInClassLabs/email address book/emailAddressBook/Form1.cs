using System;
using System.Collections.Generic;

namespace emailAddressBook
{
    public partial class Form1 : Form
    {
        Person[] people;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                // get data from txt file
                string[] entries = File.ReadAllLines("People.txt");

                people = new Person[entries.Length];

                for (int i = 0; i < entries.Length; i++)
                {
                    // tokenize these bitties
                    string[] data = entries[i].Split('#');
                    people[i] = new Person(data[0], data[1], data[2]);
                    personListbox.Items.Add(people[i].Name);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void personListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // pass data to and open form
            Details detailForm = new Details(people[personListbox.SelectedIndex]);
            detailForm.ShowDialog();
        }
    }

    // peron class
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // default constructor
        public Person()
        {
            Name = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
        }

        // better constructor
        public Person(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
