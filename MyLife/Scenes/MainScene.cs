using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nez;

namespace MyLife.Scenes
{
    public class MainScene : BaseScene
    {
        private SceneResolutionPolicy policy;
        public MainScene()
        {
            policy = SceneResolutionPolicy.ExactFit;
        }

        public override void Initialize()
        {
            base.Initialize();
        }
    }
}
