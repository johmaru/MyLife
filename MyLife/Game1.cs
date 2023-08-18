using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;

namespace MyLife
{
    public class Game1 : Core
    {
        protected override void Initialize()
        {
            base.Initialize();

            IsMouseVisible = true;
            Window.AllowUserResizing = true;
            DebugRenderEnabled = true;

            Scene = new Scenes.MainScene();
        }
    }

}