using GenProgram;
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
    class SimpleEntity
    {
        private LayerImage layerImage;
        private SpriteBatch spriteBatch;
        private Texture2D rectTexture;
        private Color[] data;
        private Rectangle texRect;
        private Vector2 position;
        private float[] mspreadOut;
        private float[] shiftOut;
        private float energyShift;
        private float scaleShiftBorder;
        private bool isLive;
        private int cellCount;
        private int x;
        private int y;
        private int spreadSize;
        private float energyPool;
        private float energyMaxPool;
        private float energyIn;
        private float energyOut;
        private int step;

        public bool IsLive { get; set; }
        public float EnergyPool { get; set; }


        public SimpleEntity()
        {
        }

        public SimpleEntity(int cellCount, int x, int y, float energyMaxPool, float energyPool, float energyIn, float energyOut, float energyShift, float scaleShiftBorder = 3, int spreadSize = 2)
        {
            IsLive = true;
            this.cellCount = cellCount;
            this.x = x;
            this.y = y;
            this.energyMaxPool = energyMaxPool;
            this.energyPool = energyPool;
            this.energyIn = energyIn;
            this.energyOut = energyOut;
            this.spreadSize = spreadSize;
            this.energyShift = energyShift;
            this.scaleShiftBorder = scaleShiftBorder;
            mspreadOut = new float[(2 * spreadSize + 1) * (2 * spreadSize + 1)];
            shiftOut = new float[3 * 3];
        }

        private void GraphicsUpdate(int windowSize, int cellCount)
        {
            int step = windowSize / cellCount;

            for (int k1 = 1; k1 < step - 2; k1++)
                for (int k2 = 1; k2 < step - 2; k2++)
                    if ((k1 + k2) % 2 == 0)
                        data[k1 * (step - 2) + k2] = new Color(38, 24, 177);

            rectTexture.SetData(data);
        }

        public void GraphicsInitialization(int windowSize)
        {
            step = windowSize / cellCount;
            data = new Color[(step - 2) * (step - 2)];
            texRect = new Rectangle(step * x + 1, step * y + 1, step - 2, step - 2);
            position = new Vector2(step * x + 1, step * y + 1);
        }

        public void Draw(SpriteBatch spriteBatch, int windowSize, int cellCount)
        {
            if (IsLive)
            {
                int step = windowSize / cellCount;

                if(rectTexture==null)
                    rectTexture = new Texture2D(spriteBatch.GraphicsDevice, texRect.Width, texRect.Height);
                GraphicsUpdate(windowSize, cellCount);
                spriteBatch.Draw(rectTexture, position, Color.White);
            }
        }

        private void EnergyIn(float[] cellEnegry)
        {
            float realEnergyIn = energyIn;
            if (cellEnegry[y * cellCount + x] > energyIn)
            {
                realEnergyIn = energyIn;
                //cellEnegry[y * cellCount + x] -= realEnergyIn;
            }
            else
            {
                realEnergyIn = cellEnegry[y * cellCount + x];
                //cellEnegry[y * cellCount + x] = 0;
            }

            if (energyPool + realEnergyIn < energyMaxPool)
            {
                energyPool += realEnergyIn;
                cellEnegry[y * cellCount + x] -= realEnergyIn;
            }
            else
            {
                cellEnegry[y * cellCount + x] -= energyMaxPool - energyPool;
                energyPool = energyMaxPool;
            }

        }

        private static float[,] ConvertToMatrix(float[] arr, int n, int m)
        {
            float[,] result = new float[n, m];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i / m, i % m] = arr[i];
            }

            return result;
        }

        private static float[,] SpreadMatr(float[,] arr, float a, float max)
        {
            var l = arr.GetLength(0);
            float[,] res = new float[l, l];
            float distr = a / (arr.Length - 1);
            int count = 0;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if ((i == (l + 1) / 2 - 1) && (j == (l + 1) / 2 - 1))
                    {
                        res[i, j] = 0;
                    }
                    else
                    {
                        res[i, j] = distr;
                    }
                }
            }
            int[][] indexes = new int[arr.Length][];

            bool flag = true;
            //int c = 0;
            while (flag == true)
            {
                float sum = 0;
                flag = false;

                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        if ((i == (l + 1) / 2 - 1) && (j == (l + 1) / 2 - 1))
                        {
                            continue;
                        }
                        else
                        {
                            if (arr[i, j] + res[i, j] > max)
                            {
                                flag = true;
                                count++;
                                sum += (arr[i, j] + res[i, j]) - max;
                                res[i, j] -= arr[i, j] + res[i, j] - max;
                            }
                        }
                    }
                }

                if (count == arr.Length - 1)
                {
                    flag = true;
                    res[(l + 1) / 2 - 1, (l + 1) / 2 - 1] = sum;
                    break;
                }

                float newDistr = sum / (arr.Length - count - 1);
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        if ((i == (l + 1) / 2 - 1) && (j == (l + 1) / 2 - 1))
                        {
                            continue;
                        }
                        else
                        {
                            if (arr[i, j] + res[i, j] < max)
                            {
                                res[i, j] += newDistr;
                            }
                        }
                    }
                }
            }

            return res;
        }

        private void EnergyOut(float[] cellEnegry, float energymax, ref bool[,] masPos)
        {

            float spreadEnergy;
            int k = 0;


            for (int i = x - spreadSize; i <= x + spreadSize; i++)
                for (int j = y - spreadSize; j <= y + spreadSize; j++)
                {
                    if (i >= 0 && i < cellCount && j >= 0 && j < cellCount)
                        mspreadOut[k] = cellEnegry[j * cellCount + i];
                    else
                        mspreadOut[k] = energymax;
                    k++;
                }

            /*
                        for (int i = x - spreadSize; i <= x + spreadSize; i++)
                            for (int j = y - spreadSize; j <= y + spreadSize; j++)
                                if (!(i == x && j == y))
                                {
                                    if (i >= 0 && i < cellCount && j >= 0 && j < cellCount)
                                    {                         
                                        //cellEnegry[j * cellCount + i]
                                        //mspreadOut[i * spreadSize + j]=;
                                        k++;
                                    }
                                }             
                                else
                                    mspreadOut[0] = 0;

                        if (energyPool < energyOut)
                        {
                            spreadEnergy = energyPool / k;
                            energyPool = 0;
                            IsLive = false;
                        }
                        else
                        {
                            energyPool -= energyOut;
                            spreadEnergy = energyOut / k;
                        }

                        for (int i = x - spreadSize; i <= x + spreadSize; i++)
                for (int j = y - spreadSize; j <= y + spreadSize; j++)
                    if (!(i == x && j == y))
                        if (i >= 0 && i < cellCount && j >= 0 && j < cellCount)
                            cellEnegry[j * cellCount +i] += spreadEnergy;

                        */

            if (energyPool < energyOut)
            {
                spreadEnergy = energyPool;
                energyPool = 0;
                IsLive = false;
                masPos[x, y] = false;
            }
            else
            {
                energyPool -= energyOut;
                spreadEnergy = energyOut;
            }

            float[,] spreadMtrToo = SpreadMatr(ConvertToMatrix(mspreadOut, 2 * spreadSize + 1, 2 * spreadSize + 1), spreadEnergy, energymax);

            int i1 = 0;
            int j1 = 0;
            for (int i = x - spreadSize; i <= x + spreadSize; i++)
            {
                j1 = 0;
                for (int j = y - spreadSize; j <= y + spreadSize; j++)
                {
                    if (i >= 0 && i < cellCount && j >= 0 && j < cellCount)
                        cellEnegry[j * cellCount + i] += spreadMtrToo[i1, j1];
                    j1++;
                }

                i1++;
            }


        }

        private void Shift(float[] cellEnegry, float energymax, SimpleEntity[] entity, ref bool[,] masPos)
        {
            if (energyPool < energyShift)
                return;

            List<Point> posMax = new List<Point>();
            float shiftEnergyMax = -1;

            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && i < cellCount && j >= 0 && j < cellCount)
                    {
                        if (!masPos[i, j])
                        {
                            if (cellEnegry[j * cellCount + i] > shiftEnergyMax)
                            {
                                posMax = new List<Point>();
                                posMax.Add(new Point(i, j));
                                shiftEnergyMax = cellEnegry[j * cellCount + i];
                            }
                            if (Math.Abs(shiftEnergyMax - cellEnegry[j * cellCount + i]) < 0.01f)
                            {
                                posMax.Add(new Point(i, j));
                            }
                        }
                    }
                }

            if (posMax.Count == 0)
                return;

            Point posMax1 = posMax[RandomManager.Rvalue(0, posMax.Count - 1)];
            if (cellEnegry[posMax1.Y * cellCount + posMax1.X] > scaleShiftBorder * cellEnegry[y * cellCount + x])
            {
                masPos[x, y] = false;
                energyPool -= energyShift;
                cellEnegry[y * cellCount + x] += energyShift;
                x = posMax1.X;
                y = posMax1.Y;
                texRect.X = step * x + 1;
                texRect.Y = step * y + 1;
                texRect.Width = step - 2;
                texRect.Height = step - 2;
                position.X = step * x + 1;
                position.Y = step * y + 1;
                masPos[x, y] = true;
            }

        }

        public void Update(float[] cellEnegry, float energymax, SimpleEntity[] entity, ref bool[,] masPos)
        {
            if (IsLive)
            {
                EnergyIn(cellEnegry);
                EnergyOut(cellEnegry, energymax, ref masPos);
                Shift(cellEnegry, energymax, entity, ref masPos);
            }
        }
    }
}
