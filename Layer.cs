using GenProgram;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenProgram_v2._0
{
    public class Layer
    {
        protected ContentManager content;

        public Layer()
        {
        }

        public virtual void LoadContent()
        {
            content = new ContentManager(LayerManager.Instance.Content.ServiceProvider, "Content");
        }

        public virtual void UnloadContent()
        {
            content.Unload();
        }

        public virtual void Update(GameTime gameTime)
        {
            InputManager.Instance.Update();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }

        public virtual T GetBase<T>()
        {
            return default(T);
        }

    }
}
