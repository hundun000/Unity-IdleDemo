using Assets.Scripts.DemoGameCore.logic;
using hundun.idleshare.enginecore;
using hundun.unitygame.enginecorelib;
using hundun.unitygame.gamelib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.DemoGameCore.ui.screen
{
    public class DemoPlayScreen : BaseIdlePlayScreen<DemoIdleGame, RootSaveData>
    {


        public const String SCENE_NAME = "PlayScene";

        private IdleScreenBackgroundVM screenBackgroundVM;
        private DemoStorageInfoBoardVM storageInfoBoardVM;

        public override void show()
        {
            this.postMonoBehaviourInitialization(DemoIdleGameContainer.Game);
            base.show();
        }

        override public void postMonoBehaviourInitialization(DemoIdleGame game)
        {
            base.postMonoBehaviourInitialization(game, GameArea.AREA_COOKIE, DemoIdleGame.LOGIC_FRAME_PER_SECOND);
        }

        protected override void lazyInitBackUiAndPopupUiContent()
        {
            this.screenBackgroundVM = this.Contrainer.transform.Find("DemoScreenBackgroundVM").gameObject.GetComponent<IdleScreenBackgroundVM>();
            screenBackgroundVM.postPrefabInitialization(this.game.textureManager);
        }

        protected override void lazyInitLogicContext()
        {
            gameAreaChangeListeners.Add(screenBackgroundVM);
        }

        protected override void lazyInitUiRootContext()
        {
            this.storageInfoBoardVM = this.UiRoot.transform.Find("DemoStorageInfoBoardVM").gameObject.GetComponent<DemoStorageInfoBoardVM>();

        }
    }
}
