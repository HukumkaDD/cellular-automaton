using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileMapEditor;

namespace GenProgram_v2._0
{
    class EntityLayer:Layer
    {
        LayerImage layerImage;
        Color[] TextureData;
        Config config;
        Vector2 screenSize;
        Vector2 newScreenSize;
        SimpleEntity[] simpleEntities;
        float[] eneryLevel;
        bool[,] lifeEntities;
        public EntityLayer(Vector2 screenSize,Vector2 offset,int cellSize, Config config, float[] eneryLevel)
        {
            this.config = config;
            this.screenSize = screenSize;
            this.eneryLevel = eneryLevel;
            layerImage = new LayerImage(screenSize, offset, config.CellCount, cellSize);
            newScreenSize = new Vector2(cellSize * config.CellCount + config.CellCount + 1, cellSize * config.CellCount + config.CellCount + 1);
            TextureData = new Color[(int)newScreenSize.X * (int)newScreenSize.X];
            InitializeEntity(config.CellCount, config.PopSize);
        }

        public override void LoadContent()
        {
            base.LoadContent();
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            foreach (SimpleEntity x in simpleEntities)
                x.Update(eneryLevel, config.EnergyMaxCell, simpleEntities, ref lifeEntities);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            layerImage.TextureData = TextureData;
            //layerImage.Draw(spriteBatch);
            foreach (SimpleEntity x in simpleEntities)
                x.Draw(spriteBatch,(int)newScreenSize.X, config.CellCount);
        }

        public void InitializeEntity(int cellCount, int popSize)
        {
            Random rnd = new Random();           
            Point[] masPos = new Point[cellCount * cellCount];
            lifeEntities = new bool[cellCount, cellCount];
            simpleEntities = new SimpleEntity[popSize];
            for (int i = 0; i < masPos.Length; i++)
                masPos[i] = new Point(i / cellCount, i % cellCount);

            for (int i = 0; i < masPos.Length - 1; i++)
            {
                Point buf = masPos[i];
                int j = rnd.Next(0, cellCount) * cellCount + rnd.Next(i % cellCount, cellCount);
                masPos[i] = masPos[j];
                masPos[j] = buf;
            }

            for (int i = 0; i < lifeEntities.GetLength(0); i++)
                for (int j = 0; j < lifeEntities.GetLength(1); j++)
                    lifeEntities[i, j] = false;

             for (int i = 0; i < simpleEntities.Length; i++)
             {
                 simpleEntities[i] = new SimpleEntity(cellCount, masPos[i].X, masPos[i].Y, config.EnergyMaxEntity, 0, config.EnregyEntityIn, config.EnregyEntityOut, config.ShiftEnergy, config.ScaleShiftBorder, config.SpreadEnergySize);
                 simpleEntities[i].GraphicsInitialization((int)newScreenSize.X);
                 lifeEntities[masPos[i].X, masPos[i].Y] = true;
             }
        }
    }
}
