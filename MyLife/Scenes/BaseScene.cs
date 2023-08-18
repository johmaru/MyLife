using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nez;

namespace MyLife.Scenes
{
    public abstract class BaseScene : Scene
    {
        public BaseScene(){ }

        public void SetupScene()
        {
            AddRenderer(new DefaultRenderer());
        }

    }
}
