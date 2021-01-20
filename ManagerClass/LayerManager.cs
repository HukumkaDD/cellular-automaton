using GenProgram;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GenProgram_v2._0
{
    public class LayerManager
    {
        private static LayerManager instance;
        public int CellCount;
        public int CellSize;
        public float Scale;
        [XmlIgnore]
        private Vector2 offset;
        [XmlIgnore]
        private List<Layer> layers;
        [XmlIgnore]
        public Vector2 ScreenSize { set; get; }
        [XmlIgnore]
        public GraphicsDevice GraphicsDevice { set; get; }
        [XmlIgnore]
        public SpriteBatch SpriteBatch { set; get; }
        [XmlIgnore]
        public ContentManager Content { private set; get; }
        public static LayerManager Instance
        {
            get
            {
                if (instance == null)
                {
                    string exeFolder = Application.StartupPath;
                    string path = Path.Combine(exeFolder, @"ScreenConfig/ScreenConfig.xml");
                    XmlManager<LayerManager> xml = new XmlManager<LayerManager>();
                    instance = xml.Load(path);
                }
                return instance;
            }
        }
        public LayerManager()
        {
            offset = new Vector2(0, 0);
        }
        public void Update(GameTime gameTime)
        {
            foreach (var layer in layers)
                layer.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var layer in layers)
                layer.Draw(spriteBatch);
        }
        public void LoadContent(ContentManager content, Config config)
        {
            this.Content = new ContentManager(content.ServiceProvider, "Content");

            layers = new List<Layer>();
            layers.Add(new FieldLayer(ScreenSize, offset, CellCount, CellSize, Scale));                         // Клетки поля
            layers.Add(new FundamentalLayer(ScreenSize, offset, CellSize, config));                             // Энергия поля
            layers.Add(new EntityLayer(ScreenSize, offset, CellSize, config, layers[1].GetBase<float[]>()));    // Сущности
            foreach (var layer in layers)
                layer.LoadContent();
        }
    }
}
