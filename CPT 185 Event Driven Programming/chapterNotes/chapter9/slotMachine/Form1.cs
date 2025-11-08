using System;
using System.Windows.Forms;
using System.Drawing;
using Timer = System.Windows.Forms.Timer;

namespace slotMachine
{
    public partial class Form1 : Form
    {
        private readonly Random rand = new Random();

        // --- SPIN ANIMATION STATE ---
        private readonly Timer spinTimer = new Timer(); // WinForms timer
        private int ticks;
        private int stopTickReel1, stopTickReel2, stopTickReel3;
        private int idx1, idx2, idx3; // last shown indexes
        private bool isSpinning = false;

        public Form1()
        {
            InitializeComponent();

            // Timer ~20 frames/sec
            spinTimer.Interval = 50;
            spinTimer.Tick += SpinTimer_Tick;

            // (Optional) nicer scaling
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Show an initial random frame
            var _ = loadImages();
        }

        // Picks three random images, sets the picture boxes, and returns the indexes
        private int[] loadImages()
        {
            int img1 = rand.Next(fruitImageList.Images.Count);
            int img2 = rand.Next(fruitImageList.Images.Count);
            int img3 = rand.Next(fruitImageList.Images.Count);

            pictureBox1.Image = fruitImageList.Images[img1];
            pictureBox2.Image = fruitImageList.Images[img2];
            pictureBox3.Image = fruitImageList.Images[img3];

            // Track last shown indexes (used by animation end + scoring)
            idx1 = img1; idx2 = img2; idx3 = img3;

            return new int[] { img1, img2, img3 };
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            if (isSpinning || fruitImageList.Images.Count < 3) return;

            isSpinning = true;
            spinButton.Enabled = false;
            ticks = 0;

            // Staggered stop times (feel free to tweak)
            stopTickReel1 = 18 + rand.Next(6);                    // ~1.0s
            stopTickReel2 = stopTickReel1 + 10 + rand.Next(6);    // ~1.5s
            stopTickReel3 = stopTickReel2 + 10 + rand.Next(6);    // ~2.0s

            spinTimer.Start();
        }

        private void SpinTimer_Tick(object sender, EventArgs e)
        {
            ticks++;

            // Advance each reel until its stop tick
            if (ticks <= stopTickReel1)
            {
                idx1 = rand.Next(fruitImageList.Images.Count);
                pictureBox1.Image = fruitImageList.Images[idx1];
            }
            if (ticks <= stopTickReel2)
            {
                idx2 = rand.Next(fruitImageList.Images.Count);
                pictureBox2.Image = fruitImageList.Images[idx2];
            }
            if (ticks <= stopTickReel3)
            {
                idx3 = rand.Next(fruitImageList.Images.Count);
                pictureBox3.Image = fruitImageList.Images[idx3];
            }

            // All reels have passed their stop tick → stop and score
            if (ticks > stopTickReel3)
            {
                spinTimer.Stop();
                isSpinning = false;
                spinButton.Enabled = true;

                EvaluateResult(idx1, idx2, idx3);
            }
        }

        private void EvaluateResult(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                MessageBox.Show("JACKPOT! All three match!");
            }
            else if (a == b || a == c || b == c)
            {
                MessageBox.Show("Two of a kind! Small win!");
            }
            else
            {
                MessageBox.Show("No match. Try again!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
