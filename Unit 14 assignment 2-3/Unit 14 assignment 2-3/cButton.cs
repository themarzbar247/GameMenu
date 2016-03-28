using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit_14_assignment_2_3
{
    class cButton
    {
        Texture2D texture;
        Vector2 position;
        Rectangle rectangle;
        Color color = new Color(255, 255, 255, 255);
        public Vector2 size;
        public cButton(Texture2D newTexture, GraphicsDevice graphics)
        {
            texture = newTexture;
            //ScreenW = 800, ScreenH = 600
            //ImgW = 100, ImgH =20
            size = new Vector2(graphics.Viewport.Width/2 , graphics.Viewport.Height /4);
            
        }
        bool down;
        public bool isClicked;
        public void Update(MouseState mouse)
        {
            rectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            Rectangle mouseRectangle = new Rectangle(mouse.X, mouse.Y, 1, 1);

            if (mouseRectangle.Intersects(rectangle))
            {
                if (color.A == 255) down = false;
                if (color.A == 0) down = true;
                if (down) color.A += 3;
                else color.A -= 3;
                if (mouse.LeftButton == ButtonState.Pressed) isClicked = true;
            }
            else if(color.A < 255)
            {
                color.A += 3;
                isClicked = false;
            }   
        }

        public void setPosition(Vector2 newPosition)
        {
            position = newPosition;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, color);
        }
    }
}
