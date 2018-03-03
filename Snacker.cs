using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnackGame
{
    public partial class Snacker : Form
    {
        private int direction = 0;
        private int score = 1;
        private Timer gameLoop = new Timer();
        private Random random = new Random();
        private Graphics graphics;
        private Food food;
        private Snack snack;
        private bool BOTEnabled = false;
        public Snacker()
        {
            InitializeComponent();
            snack = new Snack();
            food = new Food(random);
            gameLoop.Interval = 120;
            gameLoop.Tick += Update;
        }

        private void Snacker_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    if (LblMenu.Visible)
                    {
                        LblMenu.Visible = false;
                        LblStartStop.Visible = false;
                        BOTEnabled = false;
                        gameLoop.Start();
                    }
                    break;
                case Keys.B:
                    if (LblMenu.Visible)
                    {
                        LblMenu.Visible = false;
                        LblStartStop.Visible = false;
                        BOTEnabled = true;
                        gameLoop.Start();
                    }
                    break;
                case Keys.Space:
                    if (!LblMenu.Visible)
                    {
                        gameLoop.Enabled = (gameLoop.Enabled) ? false : true;
                    }
                    break;
                case Keys.Right:
                    if (direction != 2)
                        direction = 0;
                    break;
                case Keys.Down:
                    if (direction != 3)
                        direction = 1;
                    break;
                case Keys.Left:
                    if (direction != 0)
                        direction = 2;
                    break;
                case Keys.Up:
                    if (direction != 1)
                        direction = 3;
                    break;
            }
        }

        private void Snacker_Paint(object sender, PaintEventArgs e)
        {
            if (!LblMenu.Visible)
            {
                graphics = this.CreateGraphics();
                snack.Draw(graphics);
                food.Draw(graphics);
            }
        }

        private void Update(object sender, EventArgs e)
        {
            if(!LblMenu.Visible)
            {
                this.Text = string.Format("Snacker.IO - Score : {0}", score);
                if(BOTEnabled)
                    BOT();
                snack.Move(direction);

                for (int i = 1; i < snack.body.Length; i++)
                    if (snack.body[0].IntersectsWith(snack.body[i]))
                        Restart();

                if (snack.body[0].X < 0 || snack.body[0].X > 490)
                    Restart();

                if (snack.body[0].Y < 0 || snack.body[0].Y > 390)
                    Restart();

                if (snack.body[0].IntersectsWith(food.foodPiece))
                {
                    score++;
                    snack.Graw();
                    food.Generate(random);
                }
                if (score < 5)
                    gameLoop.Interval = 1;
                else if (score < 10)
                    gameLoop.Interval = 1;
                else
                    gameLoop.Interval = 1;
            }

            this.Invalidate();
        }

        private void BOT()
        {
            if(direction == 0)
            { 
                if(snack.body[0].X < food.foodPiece.X)
                {
                    if(snack.body[0].X == food.foodPiece.X)
                    {
                        if (snack.body[0].Y > food.foodPiece.Y)
                            direction = 3;
                        else
                            direction = 1;
                    }
                }
                else
                {
                    if (snack.body[0].Y > food.foodPiece.Y)
                        direction = 3;
                    else
                        direction = 1;
                }
            }
            else if (direction == 2)
            {
                if(snack.body[0].X > food.foodPiece.X)
                {
                    if(snack.body[0].X == food.foodPiece.X)
                    {
                        if (snack.body[0].Y > food.foodPiece.Y)
                            direction = 3;
                        else
                            direction = 1;
                    }
                }
                else
                {
                    if (snack.body[0].Y > food.foodPiece.Y)
                        direction = 3;
                    else
                        direction = 1;
                }
            }
            else if (direction == 3)
            {
                if(snack.body[0].Y > food.foodPiece.Y)
                {
                    if(snack.body[0].Y == food.foodPiece.Y)
                    {
                        if (snack.body[0].X < food.foodPiece.X)
                            direction = 0;//right
                        else
                            direction = 2;//left
                    }
                }
                else
                {
                    if (snack.body[0].X < food.foodPiece.X)
                        direction = 0;
                    else
                        direction = 2;
                }
            }
            else if (direction == 1)
            {
                if (snack.body[0].Y < food.foodPiece.Y)
                {
                    if (snack.body[0].Y == food.foodPiece.Y)
                    {
                        if (snack.body[0].X < food.foodPiece.X)
                            direction = 0;//right
                        else
                            direction = 2;//left
                    }
                }
                else
                {
                    if (snack.body[0].X < food.foodPiece.X)
                        direction = 0;
                    else
                        direction = 2;
                }
            }
        }

        private void Restart()
        {
            gameLoop.Start();
            graphics.Clear(SystemColors.Control);
            snack = new Snack();
            food = new Food(random);
            direction = 0;
            score = 1;
            LblMenu.Visible = true;
            LblStartStop.Visible = true;
        }
    }
}
