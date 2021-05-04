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
    public class GameBorder
    {
        public float Width; // Width of the game.
        public float Height; // Height
        
        private Texture2D imgPixel; // Single pixel used to draw the lines.
        private SpriteBatch spriteBatch;  //allows us to write on backbuffer when we need to draw self
        
        public GameBorder(float screenWidth, float screenHeight, SpriteBatch spriteBatch, GameContent gameContent)
        {
            Width = screenWidth;
            Height = screenHeight;
            imgPixel = gameContent.imgPixel;
            this.spriteBatch = spriteBatch;
        }
        
        public void Draw()
        {
            spriteBatch.Draw(imgPixel, new Rectangle(0, 0,(int) Width - 1, 1),Color.White);  //draw top border
            spriteBatch.Draw(imgPixel, new Rectangle(0, 0, 1,(int) Height - 1), Color.White);  //draw left border
            spriteBatch.Draw(imgPixel, new Rectangle((int)Width - 1,0, 1, (int) Height-1), Color.White);  //draw right border
        }
    }
}