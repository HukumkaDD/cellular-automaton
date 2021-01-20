using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileMapEditor;
using Color = Microsoft.Xna.Framework.Color;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace GenProgram_v2._0
{
    class FieldLayer : Layer
    {
        private LayerImage layerImage;
        private Rectangle texRect;
        private Rectangle texRectRender;
        private Rectangle texScreenSize;
        private Vector2 offset;
        private Vector2 screenSize;
        private float scale;
        private int cellCount;
        private int cellSize;
        public FieldLayer(Vector2 screenSize, Vector2 offset, int cellCount, int cellSize, float scale)
        {
            this.cellSize = cellSize;
            this.cellCount = cellCount;
            this.screenSize = screenSize;
            this.offset = offset;
            this.scale = scale;
            layerImage = new LayerImage(offset, screenSize, cellCount, cellSize);
        }
        public override void LoadContent()
        {
            base.LoadContent();
            offset = new Vector2(0,0);
            texRectRender  = new Rectangle((int)offset.X, (int)offset.Y, (int)scale *(int)screenSize.X, (int)scale *(int)screenSize.Y);
            texRect = new Rectangle(0, 0, (int)(cellSize * cellCount + cellCount + 1), (int)(cellSize * cellCount + cellCount + 1));
            texScreenSize = new Rectangle(0, 0, (int)screenSize.X, (int)screenSize.Y);
            layerImage.TextureData = Fill();
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            layerImage.TextureData = Fill();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            layerImage.Draw(spriteBatch);
        }

        private Color[] Fill()
        {
            Color[] data = new Color[(texRect.Width) * (texRect.Height)];

            int stepX = texRect.Width / cellCount;
            int stepY = texRect.Height / cellCount;

            for (int i = 0; i < data.Length; i++)
                data[i] = Color.GhostWhite;

            for (int j1 = 0; j1 < texRect.Width; j1 += stepY)
                for (int j2 = 0; j2 < texRect.Height; j2++)
                    if (j1 * texRect.Height + j2 < data.Length)
                        data[j2 * texRect.Width + j1] = Color.LightGray;

            for (int j1 = 0; j1 < texRect.Width; j1 += stepX)
                for (int j2 = 0; j2 < texRect.Width; j2++)
                    if (j1 * texRect.Height + j2 < data.Length)
                        data[j1 * texRect.Height + j2] = Color.LightGray;
            
            return data;
        }
    }
}
