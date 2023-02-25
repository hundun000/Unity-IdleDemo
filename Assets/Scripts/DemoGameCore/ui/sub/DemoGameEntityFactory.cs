using Assets.Scripts.DemoGameCore.logic;
using Assets.Scripts.DemoGameCore.ui.screen;
using hundun.idleshare.enginecore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.DemoGameCore.ui.sub
{
    internal class DemoGameEntityFactory : BaseGameEntityFactory<DemoIdleGame, RootSaveData>
    {
        private const int HIDEN_FRAME_RANGE = 5;

        private const int EXPECTED_DRAW_MIN_X = 0;
        private const int EXPECTED_DRAW_MAX_X = 300;
        private const int EXPECTED_DRAW_MIN_Y = 0;
        private const int EXPECTED_DRAW_MAX_Y = 200;

        public float FLY_UNION_SPEED = 2;

        public float RESOURCE_MAX_DRAW_NUM = 15;


        

        public void postPrefabInitialization(DemoPlayScreen parent, Transform drawContaioner)
        {
            base.postPrefabInitialization(parent, drawContaioner);
        }

        override public GameEntity newConstructionEntity(String id, int index)
        {
            switch (id)
            {
                case ConstructionId.COOKIE_CLICK_PROVIDER:
                    return null;
                case ConstructionId.COOKIE_AUTO_PROVIDER:
                    return this.rowStableConstructionEntity(id, index, 1);
                case ConstructionId.COOKIE_SELLER:
                    return this.rowStableConstructionEntity(id, index, 0);
                default:
                    // no need GameEntity
                    return null;
            }

        }




        override public int calculateResourceDrawNum(String resourceId, long logicAmount)
        {
            return (int)Math.Min(RESOURCE_MAX_DRAW_NUM, logicAmount);
        }

        override public int calculateConstructionDrawNum(String constructionid, long logicAmount, int max)
        {
            return (int)Math.Min(max, logicAmount);
        }

        override public GameEntity newResourceEntity(String resourceId, int index)
        {
            switch (resourceId)
            {
                case ResourceType.COOKIE:
                    return this.failingResourcEntity(resourceId, EXPECTED_DRAW_MIN_X, EXPECTED_DRAW_MAX_X, EXPECTED_DRAW_MAX_Y, EXPECTED_DRAW_MIN_Y, FLY_UNION_SPEED, FLY_UNION_SPEED * 0.2, HIDEN_FRAME_RANGE);
                //return this.randomMoveResourcEntity(resourceId, layoutConst.EXPECTED_DRAW_MIN_X, layoutConst.EXPECTED_DRAW_MAX_X, layoutConst.EXPECTED_DRAW_MIN_Y, layoutConst.EXPECTED_DRAW_MAX_Y, FLY_UNION_SPEED);
                default:
                    return null;
            }
        }
    }
}
