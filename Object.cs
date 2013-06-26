using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace WindowsGame1
{
    class Object
    {
        Vector2 possition;
        Rectangle rectangle;
        Texture2D texture;

        public Object() 
        { 
        }

        public void Load(ContentManager Content, Texture2D Texture, Vector2 Possition, Rectangle Rectangle)
        {
            texture = Texture;
            possition = Possition;
            rectangle = Rectangle;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, possition, rectangle, Color.White);
        }
    }
}
