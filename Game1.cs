using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame
{
    public class Game1 : Game
    {
        // Boilerplate stuff.
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Classes.GameContent gameContent;

        // Variables
        private Classes.Paddle paddlePlayer;
        private Classes.Wall wall;

        // Note: Set to 502x700 or equivilent for best results.
        private int screenWidth = 502;
        private int screenHeight = 700;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            //texture = this.Content.Load<Texture2D>("Logo"); (No Longer Needed)
            gameContent = new Classes.GameContent(Content);

            // Get the screen dimensions. (To be honest? Probably don't need this...)
            //screenWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            //screenHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;

            _graphics.PreferredBackBufferWidth = screenWidth;
            _graphics.PreferredBackBufferHeight = screenHeight;
            _graphics.ApplyChanges();
            
            // Create game objects
            int paddleX = (screenWidth - gameContent.imgPaddle.Width) / 2;   // Center the paddle on the screen
            int paddleY = screenHeight - 100;                               // Set paddle 100px from the bottom
            paddlePlayer = new Classes.Paddle(paddleX, paddleY, screenWidth, _spriteBatch, gameContent);  // Create the game paddle

            wall = new Classes.Wall(1,50, _spriteBatch, gameContent);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            
            _spriteBatch.Begin(); // Begin drawing everything.
            // TODO: Add your drawing code here
            paddlePlayer.Draw();
            wall.Draw();
            _spriteBatch.End(); // Finish drawing.

            base.Draw(gameTime);
        }
    }
}
