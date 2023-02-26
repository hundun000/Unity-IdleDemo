using hundun.idleshare.gamelib;
using hundun.unitygame.gamelib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnityEngine.EventSystems.EventTrigger;

namespace Assets.Scripts.DemoGameCore.logic
{
    public class BuiltinConstructionsLoader
    {

        public static List<BaseConstruction> initProviders()
        {
            List<BaseConstruction> constructions = new List<BaseConstruction>();
            // clicker-provider
            {
                BaseConstruction construction = new BaseClickGatherConstruction(ConstructionId.COOKIE_CLICK_PROVIDER);
                construction.detailDescroptionConstPart = "Click gain some cookie";
                construction.descriptionPackage = BaseConstruction.GATHER_DESCRIPTION_PACKAGE;

                OutputComponent outputComponent = new OutputComponent(construction);
                outputComponent.outputGainPack = (toPack(JavaFeatureForGwt.mapOf(
                        ResourceType.COOKIE, 1
                        )));
                construction.outputComponent = (outputComponent);

                UpgradeComponent upgradeComponent = new UpgradeComponent(construction);
                construction.upgradeComponent = (upgradeComponent);

                LevelComponent levelComponent = new LevelComponent(construction, false);
                construction.levelComponent = (levelComponent);

                constructions.Add(construction);
            }
            // auto-provider
            {
                BaseConstruction construction = new BaseAutoConstruction(ConstructionId.COOKIE_AUTO_PROVIDER);
                construction.detailDescroptionConstPart = "Auto gain some cookie";
                construction.descriptionPackage = BaseConstruction.MAX_LEVEL_AUTO_DESCRIPTION_PACKAGE;

                OutputComponent outputComponent = new OutputComponent(construction);
                outputComponent.outputGainPack = (toPack(JavaFeatureForGwt.mapOf(
                        ResourceType.COOKIE, 1
                        )));
                construction.outputComponent = (outputComponent);

                UpgradeComponent upgradeComponent = new UpgradeComponent(construction);
                upgradeComponent.upgradeCostPack = (toPack(JavaFeatureForGwt.mapOf(
                        ResourceType.COIN, 25
                        )));
                construction.upgradeComponent = (upgradeComponent);

                LevelComponent levelComponent = new LevelComponent(construction, false);
                construction.levelComponent = (levelComponent);

                construction.maxDrawNum = (9);
                constructions.Add(construction);
            }
            // seller
            {
                BaseConstruction construction = new BaseAutoConstruction(ConstructionId.COOKIE_SELLER);
                construction.detailDescroptionConstPart = "Auto sell cookies";
                construction.descriptionPackage = BaseConstruction.WORKING_LEVEL_AUTO_DESCRIPTION_PACKAGE;

                OutputComponent outputComponent = new OutputComponent(construction);
                outputComponent.outputCostPack = (toPack(JavaFeatureForGwt.mapOf(
                        ResourceType.COOKIE, 1
                        )));
                outputComponent.outputGainPack = (toPack(JavaFeatureForGwt.mapOf(
                        ResourceType.COIN, 5
                        )));
                construction.outputComponent = (outputComponent);

                UpgradeComponent upgradeComponent = new UpgradeComponent(construction);
                upgradeComponent.upgradeCostPack = (toPack(JavaFeatureForGwt.mapOf(
                        ResourceType.COIN, 500
                        )));
                construction.upgradeComponent = (upgradeComponent);

                LevelComponent levelComponent = new LevelComponent(construction, true);
                construction.levelComponent = (levelComponent);

                construction.maxDrawNum = (9);
                constructions.Add(construction);
            }
            // win
            {
                BaseConstruction construction = new BaseBuffConstruction(ConstructionId.WIN_PROVIDER, BuffId.WIN);
                construction.detailDescroptionConstPart = "Get a trophy and win the game";
                construction.descriptionPackage = BaseConstruction.WIN_DESCRIPTION_PACKAGE;

                OutputComponent outputComponent = new OutputComponent(construction);
                construction.outputComponent = (outputComponent);

                UpgradeComponent upgradeComponent = new UpgradeComponent(construction);
                upgradeComponent.upgradeCostPack = (toPack(JavaFeatureForGwt.mapOf(
                        ResourceType.COIN, 500
                        )));
                construction.upgradeComponent = (upgradeComponent);

                LevelComponent levelComponent = new LevelComponent(construction, false);
                construction.levelComponent = (levelComponent);

                construction.maxLevel = (1);
                constructions.Add(construction);
            }
            return constructions;
        }

        private static ResourcePack toPack(Dictionary<String, int> map)
        {
            ResourcePack pack = new ResourcePack();
            List<ResourcePair> pairs = new List<ResourcePair>(map.Count);
            foreach (KeyValuePair<String, int> entry in map)
            {
                pairs.Add(new ResourcePair(entry.Key, (long)entry.Value));
            }
            pack.baseValues = (pairs);
            return pack;
        }



    }
}
