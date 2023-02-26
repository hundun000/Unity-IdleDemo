using Assets.Scripts.DemoGameCore.logic;
using Assets.Scripts.DemoGameCore.ui.screen;
using hundun.idleshare.gamelib;
using hundun.unitygame.adapters;
using hundun.unitygame.gamelib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.DemoGameCore
{
    public class DemoChildGameConfig : ChildGameConfig
    {
        public DemoChildGameConfig()
        {

            //        BuiltinConstructionsLoader builtinConstructionsLoader = new BuiltinConstructionsLoader(game);
            //        this.setConstructions(builtinConstructionsLoader.load());

            Dictionary<String, List<String>> areaShownConstructionIds = new Dictionary<String, List<String>>();
            areaShownConstructionIds.put(GameArea.AREA_COOKIE, JavaFeatureForGwt.arraysAsList(
                    ConstructionId.COOKIE_CLICK_PROVIDER
            ));
            areaShownConstructionIds.put(GameArea.AREA_BUILDING, JavaFeatureForGwt.arraysAsList(
                    ConstructionId.COOKIE_AUTO_PROVIDER,
                    ConstructionId.COOKIE_SELLER
            ));
            areaShownConstructionIds.put(GameArea.AREA_WIN, JavaFeatureForGwt.arraysAsList(
                    ConstructionId.WIN_PROVIDER
            ));

            this.areaControlableConstructionIds = (areaShownConstructionIds);
            this.areaShowEntityByOwnAmountConstructionIds = (areaShownConstructionIds);

            Dictionary<String, List<String>> areaShowEntityByOwnAmountResourceIds = new Dictionary<String, List<String>>();
            this.areaShowEntityByOwnAmountResourceIds = (areaShowEntityByOwnAmountResourceIds);

            Dictionary<String, List<String>> areaShowEntityByChangeAmountResourceIds = new Dictionary<String, List<String>>();
            areaShowEntityByChangeAmountResourceIds.put(GameArea.AREA_COOKIE, JavaFeatureForGwt.arraysAsList(
                ResourceType.COOKIE
            ));
            this.areaShowEntityByChangeAmountResourceIds = (areaShowEntityByChangeAmountResourceIds);

            Dictionary<String, String> screenIdToFilePathMap = JavaFeatureForGwt.mapOf(
                    typeof(DemoMenuScreen).Name, "audio/Loop-Menu.wav"
                );
            this.screenIdToFilePathMap = (screenIdToFilePathMap);

            List<AchievementPrototype> achievementPrototypes = JavaFeatureForGwt.arraysAsList(
                    new AchievementPrototype("Game win", "You win the game!",
                            JavaFeatureForGwt.mapOf(BuffId.WIN, 1),
                            null
                            )
                    );
            this.achievementPrototypes = (achievementPrototypes);
        }
    }
}
