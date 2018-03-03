using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace SnackGame
{
    public class Snack
    {
        public Rectangle[] body;
        private int x = 0, y = 100, height = 10, width = 10;
        public Snack()
        {
            body = new Rectangle[1];
            body[0] = new Rectangle(x, y, width, height);
        }
        public void Draw()
        {
            for (int i = body.Length - 1; i > 0; i--)
                body[i] = body[i - 1];
        }
        public void Draw(Graphics graphics)
        {
            graphics.FillRectangles(Brushes.Green, body);
        }
        public void Move(int direction)
        {
            Draw();
            switch (direction)
            {
                case 0:
                    body[0].X += 10;
                    break;
                case 1:
                    body[0].Y += 10;
                    break;
                case 2:
                    body[0].X -= 10;
                    break;
                case 3:
                    body[0].Y -= 10;
                    break;
            }
        }

        public void Graw()
        {
            List<Rectangle> temp = body.ToList();
            temp.Add(new Rectangle(body[body.Length - 1].X, body[body.Length - 1].Y, width, height));
            body = temp.ToArray();
        }
    }
}
