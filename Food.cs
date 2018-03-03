using System;
using System.Drawing;

namespace SnackGame
{
    public class Food
    {
        public Rectangle foodPiece;
        private int x, y, height = 10, width = 10;

        public Food(Random random)
        {
            Generate(random);
            foodPiece = new Rectangle(x, y, width, height);
        }

        public void Draw(Graphics graphics)
        {
            foodPiece.X = x;
            foodPiece.Y = y;
            graphics.FillRectangle(Brushes.Brown, foodPiece);
        }
        public void Generate(Random random)
        {
            x = random.Next(0, 50) * 10;
            y = random.Next(0, 40) * 10;
        }
    }
}
