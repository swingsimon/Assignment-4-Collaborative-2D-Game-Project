using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class button
    {
        public Vector2 pos;
        public Vector2 size;
        public bool answer;
        public string text;

        Color color;

        public button(Vector2 pos, Vector2 size, bool answer, Color color, string text)
        {
            this.pos = pos;
            this.size = size;
            this.answer = answer;
            this.color = color;
            this.text = text;
        }

        public void Update()
        {
            buttonDraw();
        }

        public void buttonDraw()
        {
            Draw.LineSize = 0;
            Draw.FillColor = color;
            Draw.Rectangle(pos, size);

            float textPosX = pos.X + size.X / 2;
            float textPosY = pos.Y + size.Y / 2;
            Text.Color = Color.White;
            Text.Draw(text, textPosX, textPosY);
        }
    }
}