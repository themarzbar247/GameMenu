using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit_14_assignment_2_3
{
    class sText:IDrawable
    {
        public SpriteFont gameFont;
        public string Text;
        public Vector2 Position;
        public Color Colour;
        public float Rotation;
        public Vector2 Origin;
        public Vector2 Scale;
        public SpriteEffects spriteEffects;
        public float layerDepth;
        public bool Visable;
        public sText(SpriteFont font)
        {
            gameFont = font;
            Text = "" ;
            Position = new Vector2(0,0);
            Colour = Color.White;
            Rotation = 0f;
            Origin = new Vector2(0, 0);
            Scale = new Vector2(1, 1);
            spriteEffects = SpriteEffects.None;
            layerDepth = 0.5f;
            Visable = true;    
                   
        }
        
        public void Draw(SpriteBatch spritebatch)
        {
            
            if (Visable)
            {
                spritebatch.DrawString(gameFont, Text, Position, Colour, Rotation, Origin, Scale, spriteEffects, layerDepth);
            }
            
        }

    }
}
