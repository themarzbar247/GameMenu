using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Unit_14_assignment_2_3
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        enum Gamestate
        {
            MainMenu,
            Options,
            Playing,
        }
        Gamestate CurentGameState = Gamestate.MainMenu;

        //Screen Adjustments
        int screenWidth = 800, screenHeight = 600;
        int logoWidth = 1145/2, logoHeight = 114/2;

        SpriteFont mainMenuFont;
        cButton btnPlay;
        cButton btnOptions;
        cButton btnExit;
        string btnTextPlay = "Play";
        string btnTextOptions = "options";

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
          


        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //screen size
            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;
            //graphics.IsFullScreen = true;
            graphics.ApplyChanges();
            IsMouseVisible = true;

            //font
            mainMenuFont = Content.Load<SpriteFont>("MainMenuFont");

            //Buttons
            btnPlay = new cButton(Content.Load<Texture2D>("button"), graphics.GraphicsDevice);
            btnPlay.setPosition(new Vector2(200, 150));

            btnOptions = new cButton(Content.Load<Texture2D>("button"), graphics.GraphicsDevice);
            btnOptions.setPosition(new Vector2(200, 300));

            btnExit = new cButton(Content.Load<Texture2D>("button"), graphics.GraphicsDevice);
            btnExit.setPosition(new Vector2(200, 450));
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            MouseState mouse = Mouse.GetState();

            switch (CurentGameState)
            {
                case Gamestate.MainMenu:
                    if (btnPlay.isClicked == true)
                    {
                        CurentGameState = Gamestate.Playing;
                        
                    }
                    else if(btnOptions.isClicked == true)
                    {
                        CurentGameState = Gamestate.Options;
                        
                    }
                    btnOptions.Update(mouse);
                    btnExit.Update(mouse);
                    btnPlay.Update(mouse);
                    break;

                case Gamestate.Options:

                    break;

                case Gamestate.Playing:

                    break;

            }

           

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Gray);
            spriteBatch.Begin();

            //finds the center of the string in coordanates in side the rectangle
            Vector2 textPlayMiddlePoint = mainMenuFont.MeasureString(btnTextPlay);
            Vector2 textOptionsMiddlePoint = mainMenuFont.MeasureString(btnTextOptions);
           //places text in the center of the screen
            Vector2 textPlayPosition = new Vector2(475, 230);
            Vector2 textOptionsPosition = new Vector2(520, 380);
        
            switch (CurentGameState)
            {
                case Gamestate.MainMenu:

                    spriteBatch.Draw(Content.Load<Texture2D>("spaceBackground"), new Rectangle(0, 0, screenWidth, screenHeight),new Rectangle(0,0,screenWidth,screenHeight), Color.White,0f, new Vector2(0,0), SpriteEffects.None, 1f);
                    btnPlay.Draw(spriteBatch);
                    btnOptions.Draw(spriteBatch);
                    spriteBatch.DrawString(mainMenuFont, btnTextPlay, textPlayPosition, Color.White, 0, textPlayMiddlePoint, 1.0f, SpriteEffects.None, 0.4f);
                    spriteBatch.DrawString(mainMenuFont, btnTextOptions, textOptionsPosition, Color.White, 0, textOptionsMiddlePoint, 1.0f, SpriteEffects.None, 0.4f);
                    spriteBatch.Draw(Content.Load<Texture2D>("mainMenu"), new Rectangle(120, 50, logoWidth, logoHeight),new Rectangle(0,0,logoWidth*2,logoHeight*2), Color.White, 0f, new Vector2(0, 0), SpriteEffects.None,1f);
                    break;

                case Gamestate.Options:
                    spriteBatch.Draw(Content.Load<Texture2D>("spaceBackground"), new Rectangle(0, 0, screenWidth, screenHeight), new Rectangle(0, 0, screenWidth, screenHeight), Color.White, 0f, new Vector2(0, 0), SpriteEffects.None, 1f);
                    spriteBatch.DrawString(mainMenuFont, "Options",new Vector2(150,100), Color.White);

                    break;

                case Gamestate.Playing:
                    spriteBatch.Draw(Content.Load<Texture2D>("spaceBackground"), new Rectangle(0, 0, screenWidth, screenHeight), new Rectangle(0, 0, screenWidth, screenHeight), Color.White, 0f, new Vector2(0, 0), SpriteEffects.None, 1f);
                    

                    break;

            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
