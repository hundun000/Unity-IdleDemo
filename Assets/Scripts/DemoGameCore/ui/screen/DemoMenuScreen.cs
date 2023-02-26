using Assets.Scripts.DemoGameCore.logic;
using hundun.idleshare.enginecore;
using hundun.unitygame.adapters;
using hundun.unitygame.enginecorelib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.DemoGameCore.ui.screen
{
    public class DemoMenuScreen : BaseIdleMenuScreen<DemoIdleGame, RootSaveData>
    {




        

        override public void postMonoBehaviourInitialization(DemoIdleGame game) {
            base.postMonoBehaviourInitialization(
            game,
            () =>
            {
                game.saveHandler.gameplayLoadOrStarter(true);
                SceneManager.LoadScene(DemoPlayScreen.SCENE_NAME);
                game.audioPlayManager.intoScreen(typeof(DemoPlayScreen).Name);
            },
            () =>
            {
                game.saveHandler.gameplayLoadOrStarter(false);
                SceneManager.LoadScene(DemoPlayScreen.SCENE_NAME);
                game.audioPlayManager.intoScreen(typeof(DemoPlayScreen).Name);
            }
            );

        }

        override public void show()
        {
            this.postMonoBehaviourInitialization(DemoIdleGameContainer.Game);

            base.show();

            
        }
    }
}

