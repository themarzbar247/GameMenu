using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit_14_assignment_2_3
{
    class Options:gWindow
    {
        public Options(Game1 gameCore)
            :base(gameCore)
        {

        }
        public override void Update(Game1 gameCore, GameTime gameTime)
        {

        }
       public override void Draw(SpriteBatch spritebatch)
        {
            //spritebatch.Draw(Content.Load<Texture2D>("spaceBackground"), new Rectangle(0, 0, screenWidth, screenHeight), new Rectangle(0, 0, screenWidth, screenHeight), Color.White, 0f, new Vector2(0, 0), SpriteEffects.None, 1f);
            //spritebatch.DrawString(mainMenuFont, "Options", new Vector2(150, 100), Color.White);
        }
    }
}
