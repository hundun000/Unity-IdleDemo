using hundun.idleshare.gamelib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.DemoGameCore.logic
{
    public class DemoGameDictionary : IGameDictionary
    {

        public String constructionIdToShowName(String constructionId)
        {
            switch (constructionId)
            {

                case ConstructionId.COOKIE_CLICK_PROVIDER:
                    return "main cookie";
                case ConstructionId.COOKIE_AUTO_PROVIDER:
                    return "cliker";
                case ConstructionId.COOKIE_SELLER:
                    return "seller";
                case ConstructionId.WIN_PROVIDER:
                    return "win";

                default:
                    return "[dic:" + constructionId + "]";
            }
        }
    }
}
