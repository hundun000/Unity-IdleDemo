using hundun.idleshare.gamelib;
using hundun.unitygame.gamelib;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Tilemaps;

namespace Assets.Scripts.DemoGameCore.logic
{
    internal class DemoSaveHandler : StarterSaveHandler<RootSaveData, SystemSettingSaveData, GameplaySaveData>
    {

        public DemoSaveHandler(IFrontend frontEnd, ISaveTool<RootSaveData> saveTool) : base(frontEnd, Factory.INSTANCE, saveTool)
        {
            

        }

        override protected RootSaveData genereateStarterRootSaveData()
        {
            var gameplaySaveData = new GameplaySaveData();
            gameplaySaveData.constructionSaveDataMap = (
                    JavaFeatureForGwt.mapOf(
                            ConstructionId.COOKIE_SELLER,
                            ConstructionSaveData.builder()
                                    .level(1)
                                    .workingLevel(0)
                                    .build()));
            gameplaySaveData.ownResoueces = (new Dictionary<String, long>());
            //gameplaySaveData.ownResoueces.Add(ResourceType.COOKIE, 42);
            gameplaySaveData.unlockedResourceTypes = (new HashSet<String>());
            gameplaySaveData.unlockedResourceTypes.Add(ResourceType.COOKIE);
            gameplaySaveData.unlockedResourceTypes.Add(ResourceType.COIN);
            gameplaySaveData.unlockedAchievementNames = (new HashSet<String>());

            var systemSettingSaveData = new SystemSettingSaveData();
            systemSettingSaveData.language = Language.EN;
            var rootSaveData = new RootSaveData(gameplaySaveData, systemSettingSaveData);
            return rootSaveData;

        }
    }
}
