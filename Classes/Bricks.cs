using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame.Classes
{
    public class Bricks
    {
        // Positions of bricks on screen.
        public float xPos;
        public float yPos;
        public float Width; //width of brick
        public float Height; //height of brick
        public bool isVisible; //does brick still exist?
        private Color color;
 
        private Texture2D imgBrick; //cached image of the brick
        private SpriteBatch spriteBatch;  //allows us to write on backbuffer when we need to draw self
        
        // TODO: Figure out why Brick() needs a void, and why Paddle() doesn't.
        public Bricks(float x, float y, Color color, SpriteBatch spriteBatch, GameContent gameContent)
        {
            xPos = x;
            yPos = y;
            imgBrick = gameContent.imgBrick;
            Width = imgBrick.Width;
            Height = imgBrick.Height;
            this.spriteBatch = spriteBatch;
            isVisible = true;
            this.color = color;
        }

        public void Draw()
        {
            if (isVisible)
            {
                spriteBatch.Draw(imgBrick, new Vector2(xPos, yPos), null, color, 0, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);
            }
        }
    }
}