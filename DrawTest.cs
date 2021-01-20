using GenProgram;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = Microsoft.Xna.Framework.Input.Keys;

namespace GenProgram_v2._0
{
    class DrawTest : MonoGame.Forms.Controls.MonoGameControl
    {
        private ContentManager content;
        private SpriteBatch spriteBatch;
        private Config config;                   // Параметры модели
        private int time = 0;                    // Время до следующего обновления

        public DrawTest(ref Config config)
        {
            this.config = config;
        }

        private int CountEnt(SimpleEntity[] entities)
        {
            int sum = 0;
            foreach (SimpleEntity x in entities)
                if (x.IsLive)
                    sum++;
            return sum;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            content = new ContentManager(Services, "Content");
            spriteBatch = new SpriteBatch(this.GraphicsDevice);

            LayerManager.Instance.GraphicsDevice = this.GraphicsDevice;
            LayerManager.Instance.SpriteBatch = spriteBatch;
            LayerManager.Instance.ScreenSize = new Vector2(Size.Width, Size.Height);
            LayerManager.Instance.CellCount = config.CellCount;
            LayerManager.Instance.LoadContent(content, config);

            base.Initialize();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here
            InputManager.Instance.Update();

            /*if (Keyboard.GetState().IsKeyDown(Keys.Space))
                IsVisibleEntity = true;
            if (Keyboard.GetState().IsKeyUp(Keys.Space))
                IsVisibleEntity = false;*/

            if (time % (int)(60 / config.RateRefresh) == 0)
            {
                LayerManager.Instance.Update(gameTime);
                //config.PopSizeCurrent = CountEnt(entities);
                BindingContext[config].Position++;
            }
            time++;
            time %= 60;
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw()
        {
            base.Draw();
            spriteBatch.Begin();
            LayerManager.Instance.Draw(spriteBatch);
            spriteBatch.End();

            //GraphicsDevice.Clear(Color.SteelBlue);
            //field.Draw();
            //fundametal.Draw(IsVisibleEntity);
            //foreach (Entity x in entities)
                //x.Draw(Convert.ToInt32(this.Size.Width * config.WindowScale), config.CellCount);
            // hud.Draw(60, time, entities, shiftEnergy, energyCapacity, energyMaxCell, cellCount, enregyEntityIn, enregyEntityOut, energyMaxEntity, IsEnergyMoveDown, IsEnergyMoveUp, IsEnergyMoveLeft, IsEnergyMoveRight, IsEnergyMoveCenter);

        }
    }
}
