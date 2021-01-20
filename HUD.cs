using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using GenProgram_v2._0;

namespace GenProgram
{
    class HUD
    {
        public HUD()
        {
            
        }

        public void LogicInitialization(int cellCount)
        {

        }

        public void SettingsUpdate(int windowSizeX)
        {
        }


        private int CountEnt(SimpleEntity[] entities)
        {
            int sum = 0;
            foreach (SimpleEntity x in entities)
                if (x.IsLive)
                    sum++;
            return sum;
        }

        private int CountMidEnergyEnt(SimpleEntity[] entities)
        {
            int k = 0;
            float sum = 0;
            foreach (SimpleEntity x in entities)
                if (x.IsLive)
                {
                    k++;
                    sum += x.EnergyPool;
                }

            if (k > 0)
                return (int)sum / k;
            else
                return 0;
        }

        private int CountMinEnergyEnt(SimpleEntity[] entities)
        {
            float min = 10000000f;
            foreach (SimpleEntity x in entities)
                if (x.IsLive && x.EnergyPool < min)
                    min = x.EnergyPool;

            if (min < 10000000f - 1)
                return (int)min;
            else
                return 0;
        }

        private int CountMaxEnergyEnt(SimpleEntity[] entities)
        {
            float max = 0f;
            foreach (SimpleEntity x in entities)
                if (x.IsLive && x.EnergyPool > max)
                    max = x.EnergyPool;

            return (int)max;
        }

        public void GraphicsInitialization(SpriteBatch spriteBatch, ContentManager Content)
        {
        }

        public void Draw(int timerMax, int time, SimpleEntity[] entities,float shiftEnergy, float energyCapacity, float energyMaxCell, float cellCount, float enregyEntityIn, float enregyEntityOut, float energyMaxEntity, bool IsEnergyMoveDown, bool IsEnergyMoveUp, bool IsEnergyMoveLeft, bool IsEnergyMoveRight, bool IsEnergyMoveCenter)
        {
            /*
            spriteBatch.DrawString(font, "field size:  " + cellCount + "x" + cellCount, new Vector2(50 + windowSizeY, 50), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "time: " + time, new Vector2(50 + windowSizeY, 85), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "live:  " + CountEnt(entities), new Vector2(50 + windowSizeY, 120), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "shift ee:  " + shiftEnergy, new Vector2(50 + windowSizeY, 155), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "in ee:  " + enregyEntityIn, new Vector2(50 + windowSizeY, 190), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "out ee:  " + enregyEntityOut, new Vector2(50 + windowSizeY, 225), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "system energy:   " + energyCapacity, new Vector2(50 + windowSizeY, 260), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "max energy cell:  " + energyMaxCell, new Vector2(50 + windowSizeY, 295), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "is energy move up?:     " + IsEnergyMoveUp, new Vector2(50 + windowSizeY, 330), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "is energy move down?:   " + IsEnergyMoveDown, new Vector2(50 + windowSizeY, 365), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "is energy move left?:   " + IsEnergyMoveLeft, new Vector2(50 + windowSizeY, 400), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "is energy move right?:  " + IsEnergyMoveRight, new Vector2(50 + windowSizeY, 435), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "is energy move center?: " + IsEnergyMoveCenter, new Vector2(50 + windowSizeY, 470), Color.WhiteSmoke);

            spriteBatch.DrawString(font, "min ee:  " + (int)CountMinEnergyEnt(entities), new Vector2(275 + windowSizeY, 50), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "avr ee:  " + (int)CountMidEnergyEnt(entities), new Vector2(275 + windowSizeY, 85), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "max ee:  " + (int)CountMaxEnergyEnt(entities), new Vector2(275 + windowSizeY, 120), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "max cap ee:  " + (int)energyMaxEntity, new Vector2(275 + windowSizeY, 155), Color.WhiteSmoke);
            spriteBatch.DrawString(font, "update: " + timerMax, new Vector2(50 + windowSizeY, 520), Color.WhiteSmoke);
            */
        }
    }
}
