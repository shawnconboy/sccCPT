using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace monopoly
{
    public partial class GameForm : Form
    {
        // Tiles indexed 0–15 around the 5x5 outer ring
        private readonly List<PropertyTileControl> tileControls = new List<PropertyTileControl>();

        // Just for testing movement visually
        private int currentTestPosition = 0;

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            // Don't run board setup while in the designer
            if (DesignMode) return;

            SetupBoardControls();
            HighlightCurrentPosition();
        }

        private void SetupBoardControls()
        {
            tileControls.Clear();
            boardTable.Controls.Clear();

            // Board index → (col,row) mapping for 5x5 outer ring
            // Index layout:
            // (row 0)   [ 0 ][ 1 ][ 2 ][ 3 ][ 4 ]
            // (row 1)   [15 ][   ][   ][   ][ 5 ]
            // (row 2)   [14 ][   ][   ][   ][ 6 ]
            // (row 3)   [13 ][   ][   ][   ][ 7 ]
            // (row 4)   [12 ][11 ][10 ][ 9 ][ 8 ]
            //           (col0 col1 col2 col3 col4)

            int[] cols = { 0, 1, 2, 3, 4,
                           4, 4, 4, 4,
                           3, 2, 1, 0,
                           0, 0, 0 };

            int[] rows = { 0, 0, 0, 0, 0,
                           1, 2, 3, 4,
                           4, 4, 4, 4,
                           3, 2, 1 };

            // Simple names & prices just to see something
            string[] names = {
                "START",          // 0
                "Brown 1",        // 1
                "Brown 2",        // 2
                "Income Tax",     // 3
                "Station",        // 4
                "Light Blue 1",   // 5
                "Chance",         // 6
                "Light Blue 2",   // 7
                "Jail",           // 8
                "Pink 1",         // 9
                "Pink 2",         //10
                "Electric Co.",   //11
                "Free Parking",   //12
                "Orange 1",       //13
                "Orange 2",       //14
                "Go To Jail"      //15
            };

            int[] prices = {
                0,   // Start
                60,
                60,
                200, // Tax
                200, // Station
                100,
                0,   // Chance
                100,
                0,   // Jail
                140,
                140,
                150, // Utility
                0,   // Free Parking
                180,
                180,
                0    // Go To Jail
            };

            Color[] colors = {
                Color.Transparent,  // START
                Color.SaddleBrown,  // Brown 1
                Color.SaddleBrown,  // Brown 2
                Color.DarkGray,     // Tax
                Color.Black,        // Station
                Color.LightBlue,    // Light Blue 1
                Color.Gold,         // Chance
                Color.LightBlue,    // Light Blue 2
                Color.OrangeRed,    // Jail
                Color.HotPink,      // Pink 1
                Color.HotPink,      // Pink 2
                Color.LightGray,    // Utility
                Color.GreenYellow,  // Free Parking
                Color.Orange,       // Orange 1
                Color.Orange,       // Orange 2
                Color.Purple        // Go To Jail
            };

            for (int i = 0; i < 16; i++)
            {
                var tile = new PropertyTileControl
                {
                    PropertyName = names[i],
                    PriceText = prices[i] > 0 ? $"${prices[i]}" : "",
                    ColorBand = colors[i],
                    Dock = DockStyle.Fill,
                    Margin = new Padding(1)
                };

                int col = cols[i];
                int row = rows[i];

                boardTable.Controls.Add(tile, col, row);
                tileControls.Add(tile);
            }
        }

        private void HighlightCurrentPosition()
        {
            // Clear highlights
            foreach (var tile in tileControls)
            {
                tile.Highlight(false);
            }

            // Highlight the current test position
            if (currentTestPosition >= 0 && currentTestPosition < tileControls.Count)
            {
                tileControls[currentTestPosition].Highlight(true);
            }
        }

        // Optional: test button handler if you add a "Test Move" button
        private void testMoveButton_Click(object sender, EventArgs e)
        {
            currentTestPosition = (currentTestPosition + 1) % tileControls.Count;
            HighlightCurrentPosition();
        }
    }
}
