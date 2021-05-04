using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Monogame.Classes
{
    public class GameContent
    {
        // If something doesn't work, replace all variables with "{ get; set; }"

        public Texture2D imgBrick;
        public Texture2D imgPaddle;
        public Texture2D imgBall;
        public Texture2D imgPixel;
        public SoundEffect startSound;
        public SoundEffect brickSound;
        public SoundEffect paddleBounceSound;
        public SoundEffect wallBounceSound;
        public SoundEffect missSound;
        public SpriteFont labelFont;
 
        public GameContent(ContentManager Content)
        {
            //load images
            imgBall = Content.Load<Texture2D>("Ball");
            imgPixel = Content.Load<Texture2D>("Pixel");
            imgPaddle = Content.Load<Texture2D>("Paddle");
            imgBrick = Content.Load<Texture2D>("Brick");
        
            //load sounds
            startSound = Content.Load<SoundEffect>("StartSound");
            brickSound = Content.Load<SoundEffect>("BrickSound");
            paddleBounceSound = Content.Load<SoundEffect>("PaddleBounceSound");
            wallBounceSound = Content.Load<SoundEffect>("WallBounceSound");
            missSound = Content.Load<SoundEffect>("MissSound");
            
            //load fonts
            labelFont = Content.Load<SpriteFont>("Arial20");
        }
    }
}