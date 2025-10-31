using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsTimer = System.Windows.Forms.Timer;

namespace reelHustler
{
    public partial class Form1 : Form
    {
        // --- World/grid ---
        private const int Cell = 20;
        private const int Cols = 30;
        private const int Rows = 22;
        private const int FieldMargin = 20;
        private const float EPS = 0.01f;

        // 0 = grass, 1 = mowed, 2 = obstacle
        private readonly int[,] field = new int[Cols, Rows];

        // --- Mower state ---
        private RectangleF mower;                 // mower body in pixels
        private int dir = 0;                      // 0=Right, 1=Down, 2=Left, 3=Up (cardinal)
        private float headingDeg => dir * 90f;    // derived (snap)
        private float speed = 0f;
        private const float MaxSpeed = 4.0f;
        private const float Accel = 0.35f;        // a touch peppier
        private const float Friction = 0.18f;

        // Controls
        private bool keyUp, keyDown;

        // Loop
        private readonly WinFormsTimer loop = new WinFormsTimer { Interval = 16 };
        private readonly WinFormsTimer secondTimer = new WinFormsTimer { Interval = 1000 };

        // Scoring
        private int grassCount = 0;
        private int mowedCount = 0;
        private int seconds = 0;

        public Form1()
        {
            InitializeComponent();

            Text = "Lawn Mower Simulator (WinForms) — Snappy";
            ClientSize = new Size(Cols * Cell + FieldMargin * 2, Rows * Cell + FieldMargin * 2 + 60);
            DoubleBuffered = true;
            KeyPreview = true;

            InitField();
            SpawnMower();

            loop.Tick += (s, e) => TickGame();
            secondTimer.Tick += (s, e) => { seconds++; Invalidate(); };

            KeyDown += OnKeyDown;
            KeyUp += OnKeyUp;
            Paint += OnPaint;

            loop.Start();
            secondTimer.Start();
        }

        private void InitField()
        {
            var rand = new Random();
            grassCount = 0; mowedCount = 0;

            for (int x = 0; x < Cols; x++)
                for (int y = 0; y < Rows; y++)
                {
                    bool border = (x == 0 || y == 0 || x == Cols - 1 || y == Rows - 1);
                    if (!border && rand.NextDouble() < 0.05)
                    {
                        field[x, y] = 2; // obstacle
                    }
                    else
                    {
                        field[x, y] = 0; // grass
                        grassCount++;
                    }
                }

            // clear a small start pad
            for (int x = 1; x <= 3; x++)
                for (int y = 1; y <= 3; y++)
                {
                    if (field[x, y] != 1)
                    {
                        if (field[x, y] == 0) grassCount--;
                        field[x, y] = 1;
                    }
                }
        }

        private void SpawnMower()
        {
            float x = FieldMargin + Cell * 2 - 12;
            float y = FieldMargin + Cell * 2 - 8;
            mower = new RectangleF(x, y, 24, 16);
            dir = 0;        // facing right
            speed = 0f;
        }

        private void TickGame()
        {
            // throttle/friction
            if (keyUp) speed = Math.Min(MaxSpeed, speed + Accel);
            if (keyDown) speed = Math.Max(-MaxSpeed * 0.6f, speed - Accel);
            if (!keyUp && !keyDown)
            {
                if (speed > 0) speed = Math.Max(0, speed - Friction);
                else if (speed < 0) speed = Math.Min(0, speed + Friction);
            }

            // cardinal unit vector
            float dx = 0, dy = 0;
            switch (dir)
            {
                case 0: dx = 1; dy = 0; break;  // right
                case 1: dx = 0; dy = 1; break;  // down
                case 2: dx = -1; dy = 0; break; // left
                case 3: dx = 0; dy = -1; break; // up
            }
            dx *= speed;
            dy *= speed;

            // Move with slide: resolve X then Y so you glide along walls
            MoveWithSlide(dx, dy);

            // mow tiles under mower
            MowUnderMower();

            Invalidate();
        }

        // Move axis-by-axis and slide along obstacles/bounds
        private void MoveWithSlide(float dx, float dy)
        {
            // X axis
            if (Math.Abs(dx) > float.Epsilon)
            {
                var next = mower; next.X += dx;
                // bounds clamp on X
                var playLeft = FieldMargin;
                var playRight = FieldMargin + Cols * Cell;
                if (next.Left < playLeft) { next.X = playLeft + EPS; speed = 0; }
                if (next.Right > playRight) { next.X = playRight - next.Width - EPS; speed = 0; }

                // obstacle resolve on X (slide: only cancel X if needed)
                if (OverlapsObstacle(next, out Rectangle block))
                {
                    if (dx > 0)
                        next.X = block.Left - next.Width - EPS;  // push to left of obstacle
                    else
                        next.X = block.Right + EPS;              // push to right of obstacle
                    // kill X component only
                    dx = 0;
                }

                mower = next;
            }

            // Y axis
            if (Math.Abs(dy) > float.Epsilon)
            {
                var next = mower; next.Y += dy;
                // bounds clamp on Y
                var playTop = FieldMargin;
                var playBottom = FieldMargin + Rows * Cell;
                if (next.Top < playTop) { next.Y = playTop + EPS; speed = 0; }
                if (next.Bottom > playBottom) { next.Y = playBottom - next.Height - EPS; speed = 0; }

                // obstacle resolve on Y
                if (OverlapsObstacle(next, out Rectangle block))
                {
                    if (dy > 0)
                        next.Y = block.Top - next.Height - EPS;  // push above obstacle
                    else
                        next.Y = block.Bottom + EPS;              // push below obstacle
                    dy = 0;
                }

                mower = next;
            }
        }

        // Find if a rect overlaps any obstacle tile; returns that tile's pixel rectangle
        private bool OverlapsObstacle(RectangleF r, out Rectangle obstaclePixelRect)
        {
            int minX = Math.Max(0, (int)Math.Floor((r.Left - FieldMargin) / Cell));
            int maxX = Math.Min(Cols - 1, (int)Math.Floor((r.Right - FieldMargin) / Cell));
            int minY = Math.Max(0, (int)Math.Floor((r.Top - FieldMargin) / Cell));
            int maxY = Math.Min(Rows - 1, (int)Math.Floor((r.Bottom - FieldMargin) / Cell));

            for (int x = minX; x <= maxX; x++)
                for (int y = minY; y <= maxY; y++)
                {
                    if (field[x, y] == 2)
                    {
                        int px = FieldMargin + x * Cell;
                        int py = FieldMargin + y * Cell;
                        var tileRect = new Rectangle(px, py, Cell, Cell);
                        if (tileRect.IntersectsWith(Rectangle.Ceiling(r)))
                        {
                            obstaclePixelRect = tileRect;
                            return true;
                        }
                    }
                }

            obstaclePixelRect = Rectangle.Empty;
            return false;
        }

        private void MowUnderMower()
        {
            int minX = Math.Max(0, (int)Math.Floor((mower.Left - FieldMargin) / Cell));
            int maxX = Math.Min(Cols - 1, (int)Math.Floor((mower.Right - FieldMargin) / Cell));
            int minY = Math.Max(0, (int)Math.Floor((mower.Top - FieldMargin) / Cell));
            int maxY = Math.Min(Rows - 1, (int)Math.Floor((mower.Bottom - FieldMargin) / Cell));

            for (int x = minX; x <= maxX; x++)
                for (int y = minY; y <= maxY; y++)
                {
                    if (field[x, y] == 0)
                    {
                        field[x, y] = 1;
                        mowedCount++;
                    }
                }
        }

        // INPUT: snap turns on Left/Right; Up/Down = throttle
        private void OnKeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                dir = (dir + 3) & 3; // -1 mod 4
            }
            else if (e.KeyCode == Keys.Right)
            {
                dir = (dir + 1) & 3; // +1 mod 4
            }
            else if (e.KeyCode == Keys.Up)
            {
                keyUp = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyDown = true;
            }

            if (e.KeyCode == Keys.R) { InitField(); SpawnMower(); seconds = 0; }
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void OnKeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) keyUp = false;
            if (e.KeyCode == Keys.Down) keyDown = false;
        }

        private void OnPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.Clear(Color.FromArgb(18, 18, 18));
            var fieldRect = new Rectangle(FieldMargin, FieldMargin, Cols * Cell, Rows * Cell);
            g.FillRectangle(Brushes.DarkGreen, fieldRect);

            for (int x = 0; x < Cols; x++)
                for (int y = 0; y < Rows; y++)
                {
                    var r = new Rectangle(FieldMargin + x * Cell, FieldMargin + y * Cell, Cell, Cell);
                    switch (field[x, y])
                    {
                        case 0: g.FillRectangle(Brushes.ForestGreen, r); break;
                        case 1: g.FillRectangle((y % 2 == 0) ? Brushes.MediumSeaGreen : Brushes.SeaGreen, r); break;
                        case 2: g.FillRectangle(Brushes.SaddleBrown, r); g.DrawRectangle(Pens.Black, r); break;
                    }
                }

            DrawMower(g);

            using var font = new Font("Segoe UI", 11, FontStyle.Bold);
            float percent = grassCount > 0 ? (mowedCount * 100f / grassCount) : 100f;
            string info = $"Time: {seconds}s    Mowed: {percent:0.0}%    R=Reset   Esc=Quit   ←/→ snap turn, ↑/↓ throttle";
            g.DrawString(info, font, Brushes.White, FieldMargin, FieldMargin + Rows * Cell + 10);
        }

        private void DrawMower(Graphics g)
        {
            // rotate around center using cardinal heading
            var centerX = mower.X + mower.Width / 2f;
            var centerY = mower.Y + mower.Height / 2f;

            var state = g.Save();
            g.TranslateTransform(centerX, centerY);
            g.RotateTransform(headingDeg);
            g.TranslateTransform(-centerX, -centerY);

            using var body = new SolidBrush(Color.LightGray);
            g.FillRectangle(body, mower);
            g.DrawRectangle(Pens.Black, Rectangle.Round(mower));

            var front = new RectangleF(mower.Right - 6, mower.Top + 2, 4, mower.Height - 4);
            g.FillRectangle(Brushes.Red, front);

            var wh = new SizeF(4, mower.Height);
            g.FillRectangle(Brushes.DimGray, new RectangleF(mower.Left - 3, mower.Top, wh.Width, wh.Height));
            g.FillRectangle(Brushes.DimGray, new RectangleF(mower.Right - 1, mower.Top, wh.Width, wh.Height));

            g.Restore(state);
        }
    }
}
