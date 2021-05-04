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
    public class Paddle
    {
        // Speeds & Positions
        public float xPos;
        public float yPos;
        public float speed = 5;

        // Screen dimensions.
        public float Width; //width of paddle
        public float Height; //height of paddle
        public float ScreenWidth; //width of game screen
        
        // Textures & Sprites
        private Texture2D imgPaddle;  //cached image of the paddle
        private SpriteBatch spriteBatch;  //allows us to write on backbuffer when we need to draw self
        
        // The function of our paddle which the player can move. 
        public Paddle(float x, float y, float screenWidth, SpriteBatch spriteBatch, GameContent gameContent)
        {
            xPos = x;
            yPos = y;
            imgPaddle = gameContent.imgPaddle;
            Width = imgPaddle.Width;
            Height = imgPaddle.Height;
            this.spriteBatch = spriteBatch;
            ScreenWidth = screenWidth;
        }

        public void Draw()
        {
            spriteBatch.Draw(imgPaddle, new Vector2(xPos, yPos), null, Color.White, 0, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);
        }
        
        // Moving left.
        public void MoveLeft()
        {
            xPos = xPos - speed;
            
            if (xPos < 1)   // TODO: Find a better way to do this.
            {
                xPos = 1;
            }
        }

        // Moving right.
        public void MoveRight()
        {
            xPos = xPos + speed;
            
            if ((xPos + Width) > ScreenWidth)   // TODO: find a better way to do this.
            {
                xPos = ScreenWidth - Width;
            }
        }
        
        // No idea what this does. I'll have to experiment.
        public void MoveTo(float x)
        {
            if (x >= 0)
            {
                if (x < ScreenWidth-Width)
                {
                    xPos = x;
                }
                else
                {
                    xPos = ScreenWidth - Width;
                }
            }
            
            else
            {
                if (x<0)
                {
                    xPos = 0;
                }
            }
        }
    }
}