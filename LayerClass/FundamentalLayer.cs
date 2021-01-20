using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TileMapEditor;

namespace GenProgram_v2._0
{
    class EnergySpread
    {
        private Vector2 screenSize;
        private int cellCount;
        private int step;
        private int max;
        private float energyCapacity;
        private float energyMaxCapacity;
        private float percent;
        public float[] EnergyLevel { get; set; }
        public Color[] EnergyColor { get; set; }
        public float EnergyMaxCapacity { get; set; }
        public void EnergyFill()
        {

            max = Convert.ToInt32(energyCapacity / (cellCount * cellCount * percent));

            for (int i = 0; i < EnergyLevel.Length; i++)
                EnergyLevel[i] = energyCapacity / (cellCount * cellCount);

            ColorManager colorManager = new ColorManager();
            for (int i = 0; i < cellCount; i++)
                for (int j = 0; j < cellCount; j++)
                {
                    int leftborder = step * i * (int)screenSize.X + step * j + 1;

                    for (int k1 = 0; k1 < step - 1; k1++)
                        for (int k2 = 0; k2 < step - 1; k2++)
                            if (leftborder + k1 + k2 * (int)screenSize.X < EnergyColor.Length)
                                EnergyColor[leftborder + k1 + (k2 + 1) * (int)screenSize.X] = colorManager.GetColor((int)(EnergyLevel[i * cellCount + j] * 510 / max));
                }
        }
        public void EnergyUpdate()
        {
            ColorManager colorManager = new ColorManager();
            for (int i = 0; i < cellCount; i++)
                for (int j = 0; j < cellCount; j++)
                {
                    int leftborder = step * i * (int)screenSize.X + step * j + 1;

                    for (int k1 = 0; k1 < step - 1; k1++)
                        for (int k2 = 0; k2 < step - 1; k2++)
                            if (leftborder + k1 + k2 * (int)screenSize.X < EnergyColor.Length)
                                EnergyColor[leftborder + k1 + (k2 + 1) * (int)screenSize.X] = colorManager.GetColor(Convert.ToInt32((EnergyLevel[i * cellCount + j] * 510) / max));
                    //energyColor[leftborder + k1 + (k2 + 1) * windowSize] = new Color(Convert.ToInt32((energyLevel[i * cellCount + j] * 255) / max), 255, 50);

                }

        }
        #region EnergyShift
        public void EnergyShiftDown()
        {
            for (int i = 0; i < cellCount; i++)
                for (int j = 0; j < cellCount; j++)
                {
                    if (i + 1 < cellCount)
                    {
                        float a = EnergyLevel[i * cellCount + j] * ((float)RandomManager.Rvalue(5, 10) / 1000);
                        if (EnergyLevel[i * cellCount + j] < Math.Abs(a))
                        {
                            if (EnergyLevel[(i + 1) * cellCount + j] + EnergyLevel[i * cellCount + j] < energyMaxCapacity)
                            {
                                EnergyLevel[(i + 1) * cellCount + j] += EnergyLevel[i * cellCount + j] * Math.Sign(a);
                                EnergyLevel[i * cellCount + j] -= EnergyLevel[i * cellCount + j] * Math.Sign(a);
                            }
                            else
                            {
                                EnergyLevel[i * cellCount + j] -= energyMaxCapacity - EnergyLevel[(i + 1) * cellCount + j];
                                EnergyLevel[(i + 1) * cellCount + j] = energyMaxCapacity;
                            }
                        }
                        else
                        {
                            if (EnergyLevel[(i + 1) * cellCount + j] + a > energyMaxCapacity)
                            {
                                EnergyLevel[i * cellCount + j] -= energyMaxCapacity - EnergyLevel[(i + 1) * cellCount + j];
                                EnergyLevel[(i + 1) * cellCount + j] = energyMaxCapacity;
                            }
                            else
                            {
                                EnergyLevel[(i + 1) * cellCount + j] += a;
                                EnergyLevel[i * cellCount + j] -= a;
                            }
                        }
                    }
                }
        }
        public void EnergyShiftUp()
        {
            for (int i = cellCount - 1; i > 0; i--)
                for (int j = cellCount - 1; j >= 0; j--)
                {
                    float a = EnergyLevel[i * cellCount + j] * ((float)(float)RandomManager.Rvalue(5, 10) / 1000);
                    if (EnergyLevel[i * cellCount + j] < Math.Abs(a))
                    {
                        if (EnergyLevel[(i - 1) * cellCount + j] + EnergyLevel[i * cellCount + j] < energyMaxCapacity)
                        {
                            EnergyLevel[(i - 1) * cellCount + j] += EnergyLevel[i * cellCount + j];
                            EnergyLevel[i * cellCount + j] -= EnergyLevel[i * cellCount + j];
                        }
                        else
                        {
                            EnergyLevel[i * cellCount + j] -= energyMaxCapacity - EnergyLevel[(i - 1) * cellCount + j];
                            EnergyLevel[(i - 1) * cellCount + j] = energyMaxCapacity;
                        }
                    }
                    else
                    {
                        if (EnergyLevel[(i - 1) * cellCount + j] + a > energyMaxCapacity)
                        {
                            EnergyLevel[i * cellCount + j] -= energyMaxCapacity - EnergyLevel[(i - 1) * cellCount + j];
                            EnergyLevel[(i - 1) * cellCount + j] = energyMaxCapacity;
                        }
                        else
                        {
                            EnergyLevel[(i - 1) * cellCount + j] += a;
                            EnergyLevel[i * cellCount + j] -= a;
                        }
                    }
                }
        }
        public void EnergyShiftLeft()
        {
            for (int j = cellCount - 1; j > 0; j--)
                for (int i = cellCount - 1; i >= 0; i--)
                {
                    float a = EnergyLevel[i * cellCount + j] * ((float)(float)RandomManager.Rvalue(5, 10) / 1000);
                    if (EnergyLevel[i * cellCount + j] < Math.Abs(a))
                    {
                        if (EnergyLevel[i * cellCount + (j - 1)] + EnergyLevel[i * cellCount + j] < energyMaxCapacity)
                        {
                            EnergyLevel[i * cellCount + (j - 1)] += EnergyLevel[i * cellCount + j];
                            EnergyLevel[i * cellCount + j] -= EnergyLevel[i * cellCount + j];
                        }
                        else
                        {
                            EnergyLevel[i * cellCount + j] -= energyMaxCapacity - EnergyLevel[i * cellCount + (j - 1)];
                            EnergyLevel[i * cellCount + (j - 1)] = energyMaxCapacity;
                        }
                    }
                    else
                    {
                        if (EnergyLevel[i * cellCount + (j - 1)] + a > energyMaxCapacity)
                        {
                            EnergyLevel[i * cellCount + j] -= energyMaxCapacity - EnergyLevel[i * cellCount + (j - 1)];
                            EnergyLevel[i * cellCount + (j - 1)] = energyMaxCapacity;
                        }
                        else
                        {
                            EnergyLevel[i * cellCount + (j - 1)] += a;
                            EnergyLevel[i * cellCount + j] -= a;
                        }
                    }
                }
        }
        public void EnergyShiftRight()
        {
            for (int j = cellCount - 2; j >= 0; j--)
                for (int i = cellCount - 1; i >= 0; i--)
                {
                    float a = EnergyLevel[i * cellCount + j] * ((float)(float)RandomManager.Rvalue(5, 10) / 1000);
                    if (EnergyLevel[i * cellCount + j] < Math.Abs(a))
                    {
                        if (EnergyLevel[i * cellCount + (j + 1)] + EnergyLevel[i * cellCount + j] < energyMaxCapacity)
                        {
                            EnergyLevel[i * cellCount + (j + 1)] += EnergyLevel[i * cellCount + j];
                            EnergyLevel[i * cellCount + j] -= EnergyLevel[i * cellCount + j];
                        }
                        else
                        {
                            EnergyLevel[i * cellCount + j] -= energyMaxCapacity - EnergyLevel[i * cellCount + (j + 1)];
                            EnergyLevel[i * cellCount + (j + 1)] = energyMaxCapacity;
                        }
                    }
                    else
                    {
                        if (EnergyLevel[i * cellCount + (j + 1)] + a > energyMaxCapacity)
                        {
                            EnergyLevel[i * cellCount + j] -= energyMaxCapacity - EnergyLevel[i * cellCount + (j + 1)];
                            EnergyLevel[i * cellCount + (j + 1)] = energyMaxCapacity;
                        }
                        else
                        {
                            EnergyLevel[i * cellCount + (j + 1)] += a;
                            EnergyLevel[i * cellCount + j] -= a;
                        }
                    }
                }
        }
        public void EnergyShiftCenter()
        {
            int posCi = cellCount / 2;
            int posCj = cellCount / 2;
            for (int i = 0; i < cellCount; i++)
                for (int j = 0; j < cellCount; j++)
                {
                    int direction = 0;
                    int posi = i;
                    int posj = j;

                    if (i > cellCount / 2)
                        posi--;
                    else
                        posi++;

                    if (j > cellCount / 2)
                        posj--;
                    else
                        posj++;

                    float a = EnergyLevel[i * cellCount + j] * ((float)(float)RandomManager.Rvalue(5, 10) / 1000);

                    if (EnergyLevel[i * cellCount + j] < Math.Abs(a))
                    {
                        if (EnergyLevel[posi * cellCount + posj] + EnergyLevel[i * cellCount + j] < energyMaxCapacity)
                        {
                            EnergyLevel[posi * cellCount + posj] += EnergyLevel[i * cellCount + j] * Math.Sign(a);
                            EnergyLevel[i * cellCount + j] -= EnergyLevel[i * cellCount + j] * Math.Sign(a);
                        }
                        else
                        {
                            EnergyLevel[i * cellCount + j] -= energyMaxCapacity - EnergyLevel[posi * cellCount + posj];
                            EnergyLevel[posi * cellCount + posj] = energyMaxCapacity;
                        }
                    }
                    else
                    {
                        if (EnergyLevel[posi * cellCount + posj] + a > energyMaxCapacity)
                        {
                            EnergyLevel[i * cellCount + j] -= energyMaxCapacity - EnergyLevel[posi * cellCount + posj];
                            EnergyLevel[posi * cellCount + posj] = energyMaxCapacity;
                        }
                        else
                        {
                            EnergyLevel[posi * cellCount + posj] += a;
                            EnergyLevel[i * cellCount + j] -= a;
                        }
                    }
                }
        }
        #endregion
        public EnergySpread(Vector2 screenSize, int cellCount, float energyCapacity, float percent, float energyMaxCapacity)
        {
            this.screenSize = screenSize;
            this.cellCount = cellCount;
            this.percent = percent;
            this.energyCapacity = energyCapacity;
            this.energyMaxCapacity = energyMaxCapacity;
            step = (int)screenSize.X / cellCount;
            max = 0;
            EnergyColor = new Color[(int)screenSize.X * (int)screenSize.X];
            EnergyLevel = new float[cellCount * cellCount];
        }
    }
    class FundamentalLayer : Layer
    {
        private Config config;
        private LayerImage layerImageField;
        public EnergySpread EnergySpread { get; set; }
        public FundamentalLayer(Vector2 screenSize, Vector2 offset, int cellSize, Config config)
        {
            this.config = config;
            EnergySpread = new EnergySpread(new Vector2(cellSize * config.CellCount + config.CellCount + 1, cellSize * config.CellCount + config.CellCount + 1),
                config.CellCount, config.EnergyCapacity, config.EnergyScale, config.EnergyMaxCell);
            layerImageField = new LayerImage(offset, screenSize, config.CellCount, cellSize);
        }
        public override void LoadContent()
        {
            base.LoadContent();
            EnergySpread.EnergyFill();
        }
        public override void UnloadContent()
        {
            base.UnloadContent();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (config.EnergyMoveDown)
                EnergySpread.EnergyShiftDown();
            if (config.EnergyMoveUp)
                EnergySpread.EnergyShiftUp();
            if (config.EnergyMoveLeft)
                EnergySpread.EnergyShiftLeft();
            if (config.EnergyMoveRight)
                EnergySpread.EnergyShiftRight();
            if (config.EnergyMoveCenter)
                EnergySpread.EnergyShiftCenter();
            EnergySpread.EnergyUpdate();
            layerImageField.TextureData = EnergySpread.EnergyColor;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            layerImageField.TextureData = EnergySpread.EnergyColor;
            layerImageField.Draw(spriteBatch);
        }
        public override T GetBase<T>()
        {
            return (dynamic)EnergySpread.EnergyLevel;
        }
    }
}
