using Assets.Scripts.DemoGameCore.logic;
using hundun.idleshare.enginecore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;
using static Unity.VisualScripting.Member;

namespace Assets.Scripts.DemoGameCore.logic
{
    public class DemoTextureManager : AbstractTextureManager
    {
        private static readonly string BASE_FOLDER = "game/";

        private static Sprite getSprite(String name)
        {
            name = name.Replace(".png", "");
            return Resources.Load<Sprite>(BASE_FOLDER + name);
        }

        private static Texture2D getTexture2D(String name)
        {
            var sprite = getSprite(name);
            return sprite.texture;
        }

        private static Sprite[][] split(Texture2D source, int cellWidth, int cellHeight)
        {
            int numCol = (int)(source.width / cellWidth);
            int numRow = (int)(source.height / cellHeight);
            Sprite[][] result = new Sprite[numRow][];
            for (int rol = 0; rol < numRow; rol++)
            {
                result[rol] = new Sprite[numCol];
                for (int col = 0; col < numCol; col++)
                {
                    result[rol][col] = Sprite.Create(source, new Rect(col * cellWidth, rol * cellHeight, cellWidth, cellHeight), new Vector2(1f, 1f));
                }
            }
            return result;
        }

        public override void lazyInitOnGameCreateStage2()
        {
            winTexture = getSprite("win.png");
            menuTexture = getSprite("menu.png");
            defaultBoardNinePatchTexture = getSprite("defaultBoardNinePatch.png");
            {
                var texture = getTexture2D("resourceIcons.png");
                Sprite[][] regions = split(texture, 16, 16);


                defaultIcon = regions[0][0];
                resourceIconMap.Add(ResourceType.COIN, regions[0][1]);
                resourceIconMap.Add(ResourceType.COOKIE, regions[0][2]);
            }
            {
                var texture = getTexture2D("resourceEntities.png");
                Sprite[][] regions = split(texture, 32, 32);
                resourceEntityMap.Add(ResourceType.COOKIE, regions[0][1]);
            }
            {
                var texture = getTexture2D("constructionEntities.png");
                Sprite[][] regions = split(texture, 32, 32);
                //constructionEntityMap.Add(ConstructionId.COOKIE_CLICK_PROVIDER, regions[0][0]);
                constructionEntityMap.Add(ConstructionId.COOKIE_AUTO_PROVIDER, regions[0][1]);
                constructionEntityMap.Add(ConstructionId.COOKIE_SELLER, regions[0][2]);
                //constructionEntityMap.Add(ConstructionId.WIN_PROVIDER, regions[0][3]);
            }
            {
                var texture = getTexture2D("gameAreaIcons.png");
                Sprite[][] regions = split(texture, 100, 50);
                gameAreaLeftPartRegionMap.Add(GameArea.AREA_COOKIE, regions[2][0]);
                gameAreaLeftPartRegionMap.Add(GameArea.AREA_BUILDING, regions[1][0]);
                gameAreaLeftPartRegionMap.Add(GameArea.AREA_WIN, regions[0][0]);
                gameAreaRightPartRegionMap.Add(GameArea.AREA_COOKIE, regions[2][1]);
                gameAreaRightPartRegionMap.Add(GameArea.AREA_BUILDING, regions[1][1]);
                gameAreaRightPartRegionMap.Add(GameArea.AREA_WIN, regions[0][1]);
            }
            {
                defaultAreaBack = getSprite("areas_0.png");
                gameAreaBackMap.Add(GameArea.AREA_COOKIE, getSprite("areas_1.png"));
                gameAreaBackMap.Add(GameArea.AREA_BUILDING, getSprite("areas_2.png"));
                gameAreaBackMap.Add(GameArea.AREA_WIN, getSprite("areas_3.png"));
            }
        }
    }
}
