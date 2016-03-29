using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit_14_assignment_2_3
{
    class SpriteSheet:IDrawable
    {
        public Texture2D spriteTexture;
        public Vector2 Position;
        public Vector2 Scale;
        public Vector2 Origin;
        public float Rotation;
        public float layerDepth;
        public Rectangle SrcRectangle;
        public Color Colour;
        public SpriteEffects SpriteEffects;
        public bool Visable;
        

       public SpriteSheet(Texture2D texture)
        {
            spriteTexture = texture;
            Position = new Vector2(0, 0);
            Scale = new Vector2(1, 1);
            Origin = new Vector2(0, 0);
            Rotation = 0f;
            layerDepth = 0.5f;
            SrcRectangle = new Rectangle(0,0,800,600);
            Colour = Color.White;
            SpriteEffects = SpriteEffects.None;
                    
            Visable = true;

        }
        public void Draw(SpriteBatch spritebatch)
        {
            if (Visable)
            {
              spritebatch.Draw(spriteTexture, Position, SrcRectangle, Colour, Rotation, Origin, Scale, SpriteEffects, layerDepth);
            
            }
        }
    }
}
