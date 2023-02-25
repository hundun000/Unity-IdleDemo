using Assets.Scripts.DemoGameCore.logic;
using Assets.Scripts.DemoGameCore.ui.sub;
using hundun.idleshare.enginecore;
using hundun.unitygame.enginecorelib;
using hundun.unitygame.gamelib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.DemoGameCore.ui.screen
{
    public class DemoPlayScreen : BaseIdlePlayScreen<DemoIdleGame, RootSaveData>
    {


        public const String SCENE_NAME = "PlayScene";

        DemoGameEntityFactory gameEntityFactory;
        Transform drawContaioner;

        override protected void Awake()
        {
            base.Awake();

            this.gameEntityFactory = this.UiRoot.transform.Find("cell_drawContaioner/GameEntityFactory").GetComponent<DemoGameEntityFactory>();
            this.drawContaioner = this.UiRoot.transform.Find("cell_drawContaioner/root").transform;
        }


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
            foreach (Transform child in this.PopoupRoot.transform)
            {
                // temp Active make awak() called
                child.gameObject.SetActive(true);
                child.gameObject.SetActive(false);
            }

            screenBackgroundVM.postPrefabInitialization(this.game.textureManager);

            popupInfoBoardVM.postPrefabInitialization(this);


        }



        protected override void lazyInitUiRootContext()
        {
            storageInfoBoardVM.postPrefabInitialization(this, ResourceType.VALUES_FOR_SHOW_ORDER);

            constructionControlBoardVM.postPrefabInitialization(this);
            gameAreaControlBoardVM.postPrefabInitialization(this, GameArea.values);
        }

        override protected void lazyInitLogicContext()
        {
            base.lazyInitLogicContext();

            gameEntityFactory.postPrefabInitialization(this, drawContaioner);
            gameImageDrawer.lazyInit(this, gameEntityFactory);
        }
    }
}
