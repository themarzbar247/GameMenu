using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit_14_assignment_2_3
{
    abstract class  gWindow
    {
        sText mainMenuTitle;
        public gWindow(Game1 gameCore)
        {
            mainMenuTitle = new sText(gameCore.fontBank["MainMenuFont"]);
        }
        public abstract void Update(Game1 gameCore, GameTime gameTime);
        public abstract void Draw(SpriteBatch spritebatch);
        
    }
   
    
}
