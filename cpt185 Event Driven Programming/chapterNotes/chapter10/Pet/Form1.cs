using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet
{
    public partial class Form1 : Form
    {
        List<PetClass> pets = new List<PetClass>();

        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            String petName = nameTextbox.Text;
            String petType = typeTextbox.Text;
            int age = int.Parse(ageTextbox.Text);

            PetClass newPet = new PetClass(petName, petType, age);

            pets.Add(newPet);

            petListbox.Items.Clear();
            for (int i = 0; i < pets.Count; i++)
            {
                // add each item from list to listbox. showing in the form "Name", "Type", "Age"
                petListbox.Items.Add(pets[i].displayPetInfo());
            }

            nameTextbox.Clear();
            typeTextbox.Clear();
            ageTextbox.Clear();
            nameTextbox.Focus();
        }
    }
}
