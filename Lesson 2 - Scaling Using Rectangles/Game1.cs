using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lesson_2___Scaling_Using_Rectangles
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D rectTexture;
        Rectangle rectRectangle;

        Texture2D circTexture;
        Rectangle circRectangle;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            rectRectangle = new Rectangle(10, 10, 50, 50);
            circRectangle = new Rectangle(10, 200, 50, 50);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            rectTexture = Content.Load<Texture2D>("rectangle");
            circTexture = Content.Load<Texture2D>("circle");
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
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(circTexture, new Rectangle(190, 10, 400, 450), Color.Yellow);
            _spriteBatch.Draw(rectTexture, new Rectangle(300, 70, 40, 40), Color.White);
            _spriteBatch.Draw(circTexture, new Rectangle(315, 85, 10, 10), Color.Black);
            _spriteBatch.Draw(rectTexture, new Rectangle(435, 70, 40, 40), Color.White);
            _spriteBatch.Draw(circTexture, new Rectangle(450, 85, 10, 10), Color.Black);
            _spriteBatch.Draw(rectTexture, new Rectangle(270, 200, 240, 20), Color.Black);
            _spriteBatch.Draw(rectTexture, new Rectangle(270, 190, 20, 20), Color.Black);
            _spriteBatch.Draw(rectTexture, new Rectangle(490, 190, 20, 20), Color.Black);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
