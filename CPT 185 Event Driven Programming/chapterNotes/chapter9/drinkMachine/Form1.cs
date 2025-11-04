namespace drinkMachine
{
    public struct Drink
    {
        public string name;
        public double cost;
        public int count;
    }

    public partial class Form1 : Form
    {
        // variable declarations
        Drink cola = new Drink();
        Drink rootBeer = new Drink();
        Drink sprite = new Drink();
        Drink monster = new Drink();

        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cola.name = "Cola";
            cola.cost = 1.50;
            cola.count = 20;
            colaCostLabel.Text = cola.cost.ToString("c");
            colaInventory.Text = cola.count.ToString();

            rootBeer.name = "Root Beer";
            rootBeer.cost = 1.50;
            rootBeer.count = 20;
            rootBeerCostLabel.Text = rootBeer.cost.ToString("c");
            rootBeerInventory.Text = rootBeer.count.ToString();

            sprite.name = "Sprite";
            sprite.cost = 1.50;
            sprite.count = 20;
            spriteCostLabel.Text = sprite.cost.ToString("c");
            spriteInventory.Text = sprite.count.ToString();

            monster.name = "Monster";
            monster.cost = 3.00;
            monster.count = 20;
            monsterCostLabel.Text = monster.cost.ToString("c");
            monsterInventory.Text = monster.count.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // cola purchase
            if (cola.count == 0)
            {
                MessageBox.Show("Sorry. We're all out of that.");
            }
            else
            {
                cola.count--;
                colaInventory.Text = cola.count.ToString();
                total += cola.cost;
                totalLabel.Text = $"Total : {total:c}";
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }
    }

    
}
