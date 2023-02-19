using Assets.Scripts.DemoGameCore.logic;
using hundun.idleshare.enginecore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.DemoGameCore.ui.screen
{

    internal class DemoScreenContext : AbstractIdleScreenContext<DemoIdleGame, RootSaveData>
    {
        public DemoMenuScreen menuScreen;
        public DemoPlayScreen playScreen;
        public DemoScreenContext(DemoIdleGame game) : base(game)
        {
        }

        public override void lazyInit()
        {
            this.menuScreen = new DemoMenuScreen(game);
            this.playScreen = new DemoPlayScreen(game);
        }
    }
}
