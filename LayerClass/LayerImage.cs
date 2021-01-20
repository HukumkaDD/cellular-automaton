using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Text;
using System.Xml.Serialization;
using GenProgram_v2._0;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TileMapEditor
{
    class LayerImage
    {
        private Texture2D texture;
        private Rectangle texRect;
        private Rectangle sourceRect;
        private Rectangle destinationRect;
        public Color[] TextureData { get; set; }

        public LayerImage(Vector2 offset,Vector2 screenSize, int cellCount, int cellSize)
        {
            texRect = new Rectangle(0, 0, (int)(cellSize * cellCount + cellCount + 1), (int)(cellSize * cellCount + cellCount + 1));
            destinationRect = new Rectangle(0, 0, (int)screenSize.X, (int)screenSize.Y);
            sourceRect = new Rectangle((int)offset.X, (int)offset.Y, (int)screenSize.X, (int)screenSize.Y);
        }
        public void Update(SpriteBatch spriteBatch)
        {
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (texture == null)
                texture = new Texture2D(spriteBatch.GraphicsDevice, texRect.Width, texRect.Height);
            if (TextureData != null)
                texture.SetData(TextureData);
            spriteBatch.Draw(texture, destinationRect, sourceRect, Color.White);
        }

        public void Border()
        {
            /*
                         Vector2 borderwidth = screenSize;
            if ((int)(offset.X + texRectRender.X) > texRect.Width && texRectRender.Width > screenSize.X)
            {
                borderwidth.X = texRect.Width;
                texRectRender = new Rectangle((int)offset.X, (int)offset.Y, (int)(offset.X + borderwidth.X), (int)(offset.Y + borderwidth.Y));
            }
            if ((int)(offset.Y + texRectRender.Y) > texRect.Height && texRectRender.Height > screenSize.Y)
            {
                borderwidth.Y = texRect.Height;
                texRectRender = new Rectangle((int)offset.X, (int)offset.Y, (int)(offset.X + borderwidth.X), (int)(offset.Y + borderwidth.Y));
            }*/
        }

    }
}
