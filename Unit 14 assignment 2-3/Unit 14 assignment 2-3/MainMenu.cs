using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit_14_assignment_2_3
{
    class MainMenu:gWindow,IDrawable
    {
        //the strings that of the stext
        string btnTextPlay;
        string btnTextOptions;
        string btnTextExit;
        string titleMainMenu;
        //finds the center of the string in coordanates 
        Vector2 textTitleMiddlePoint;
        Vector2 textPlayMiddlePoint;
        Vector2 textOptionsMiddlePoint;
        Vector2 textExitMiddlePoint;
        //places text in the center of the screen
        Vector2 textPlayPosition;
        Vector2 textOptionsPosition;
        Vector2 textExitPosition;
        Vector2 textTitlePosition;
        //The actual Buttons
        cButton btnPlay;
        cButton btnOptions;
        cButton btnExit;
        //all SText
        sText mainMenuTitle;
        sText options;
        sText play;
        sText exit;

        SpriteSheet Background;

       public MainMenu(Game1 gameCore)
            :base(gameCore)
        {
            titleMainMenu = "Main Menu";
            btnTextPlay = "Play";
            btnTextExit = "Exit";
            btnTextOptions = "Options";


            textTitlePosition = new Vector2(246, 50);
            textPlayPosition = new Vector2(320, 185);
            textOptionsPosition = new Vector2(270, 335);
            textExitPosition = new Vector2(340, 482);
            


            Background = new SpriteSheet(gameCore.textureBank["spaceBackground"]);
            Background.SrcRectangle = new Rectangle(0, 0, gameCore.screenWidth, gameCore.screenHeight);
            
            

            mainMenuTitle = new sText(gameCore.fontBank["MainMenuFont"]);
            mainMenuTitle.Origin = textTitleMiddlePoint;
            mainMenuTitle.Position = textTitlePosition;
            mainMenuTitle.Text = titleMainMenu;

            play = new sText(gameCore.fontBank["MainMenuFont"]);
            play.Origin = textPlayMiddlePoint;
            play.Position = textPlayPosition;
            play.Text = btnTextPlay;

            options = new sText(gameCore.fontBank["MainMenuFont"]);
            options.Origin = textOptionsMiddlePoint;
            options.Position = textOptionsPosition;
            options.Text = btnTextOptions;

            exit = new sText(gameCore.fontBank["MainMenuFont"]);
            exit.Origin = textExitMiddlePoint;
            exit.Position = textExitPosition;
            exit.Text = btnTextExit;


            textPlayMiddlePoint = mainMenuTitle.gameFont.MeasureString(btnTextPlay);
            textOptionsMiddlePoint = mainMenuTitle.gameFont.MeasureString(btnTextOptions);
            textExitMiddlePoint = mainMenuTitle.gameFont.MeasureString(btnTextExit);
            textTitleMiddlePoint = mainMenuTitle.gameFont.MeasureString(titleMainMenu);


            btnPlay = new cButton(gameCore.textureBank["button"], gameCore.graphics.GraphicsDevice);
            btnPlay.setPosition(new Vector2(200, 150));

            btnOptions = new cButton(gameCore.textureBank["button"], gameCore.graphics.GraphicsDevice);
            btnOptions.setPosition(new Vector2(200, 300));

            btnExit = new cButton(gameCore.textureBank["button"], gameCore.graphics.GraphicsDevice);
            btnExit.setPosition(new Vector2(200, 450));

            

        }
        public override void Update(Game1 gameCore, GameTime gameTime)
        {
            MouseState mouse = Mouse.GetState();
            if (btnPlay.isClicked == true)
            {
                gameCore.CurentGameState = Game1.Gamestate.Playing;

            }
            else if (btnOptions.isClicked == true)
            {
                gameCore.CurentGameState = Game1.Gamestate.Options;

            }
            else if (btnExit.isClicked == true)
            {
                gameCore.Exit();
            }
            btnOptions.Update(mouse);
            btnExit.Update(mouse);
            btnPlay.Update(mouse);
            
        }



        public override void Draw(SpriteBatch spritebatch)
        {
            Background.Draw(spritebatch);
            
            btnPlay.Draw(spritebatch);
            btnOptions.Draw(spritebatch);
            btnExit.Draw(spritebatch);

            mainMenuTitle.Draw(spritebatch);
            play.Draw(spritebatch);
            options.Draw(spritebatch);
            exit.Draw(spritebatch);

            //spritebatch.DrawString(mainMenuFont, btnTextPlay, textPlayPosition, Color.White, 0, textPlayMiddlePoint, 1.0f, SpriteEffects.None, 0.4f);
            //spritebatch.DrawString(mainMenuFont, btnTextOptions, textOptionsPosition, Color.White, 0, textOptionsMiddlePoint, 1.0f, SpriteEffects.None, 0.4f);
            //spritebatch.DrawString(mainMenuFont, btnTextExit, textExitPosition, Color.White, 0, textExitMiddlePoint, 1.0f, SpriteEffects.None, 0.4f);
            //spritebatch.Draw(Content.Load<Texture2D>("mainMenu"), new Rectangle(120, 50, logoWidth, logoHeight), new Rectangle(0, 0, logoWidth * 2, logoHeight * 2), Color.White, 0f, new Vector2(0, 0), SpriteEffects.None, 1f);
        }
    }
}
