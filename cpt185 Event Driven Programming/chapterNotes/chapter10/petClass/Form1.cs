namespace petClass
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Pet> pets = new List<Pet>();

        private void button1_Click(object sender, EventArgs e)
        {
            Pet newPet = new Pet();

            newPet.name = nameTextbox.Text;
            newPet.type = typeTextbox.Text;
            newPet.age = int.Parse(ageTextbox.Text);

            pets.Add(newPet);
            petListbox.Items.Add(newPet.name);
        }

        private void petListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = petListbox.SelectedIndex;

            Pet selectedPet = pets[index];

            nameResultLabel.Text = selectedPet.name;
            typeResultLabel.Text = selectedPet.type;
            ageResultLabel.Text = selectedPet.age.ToString();
        }
    }

    class Pet
    {
        public string name = "";
        public string type = "";
        public int age = 0;
    }
}
