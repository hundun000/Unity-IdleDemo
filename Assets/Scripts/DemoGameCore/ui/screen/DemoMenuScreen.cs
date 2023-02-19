using Assets.Scripts.DemoGameCore.logic;
using hundun.idleshare.enginecore;
using hundun.unitygame.adapters;
using hundun.unitygame.enginecorelib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.DemoGameCore.ui.screen
{
    public class DemoMenuScreen : AbstractMenuScreen<DemoIdleGame, RootSaveData>
    {
        
        public DemoMenuScreen(DemoIdleGame game) : base(
            game,
            "Demo Idle",
            () => {
                game.saveHandler.gameLoadOrNew(true);
                SceneManager.LoadScene(DemoPlayScreen.SCENE_NAME);
                game.audioPlayManager.intoScreen(typeof(DemoPlayScreen).Name);
            },
            () => {
                game.saveHandler.gameLoadOrNew(false);
                SceneManager.LoadScene(DemoPlayScreen.SCENE_NAME);
                game.audioPlayManager.intoScreen(typeof(DemoPlayScreen).Name);
            }
            )
        {

        }

    }
}
