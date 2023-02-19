using Assets.Scripts.DemoGameCore.logic;
using hundun.unitygame.enginecorelib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace Assets.Scripts.DemoGameCore.ui.screen
{
    internal class DemoPlayScreen : StarterPlayScreen<DemoIdleGame, RootSaveData>
    {
        public const String SCENE_NAME = "PlayScene";

        public DemoPlayScreen(DemoIdleGame game) : base(game, GameArea.AREA_COOKIE, DemoIdleGame.LOGIC_FRAME_PER_SECOND)
        {

        }

        protected override void lazyInitBackUiAndPopupUiContent()
        {
            
        }

        protected override void lazyInitLogicContext()
        {
            
        }

        protected override void lazyInitUiRootContext()
        {
            
        }
    }
}
