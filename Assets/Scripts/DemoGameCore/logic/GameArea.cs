using hundun.unitygame.adapters;
using hundun.unitygame.gamelib;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.DemoGameCore.logic
{
    internal class GameArea
    {
        public const String AREA_COOKIE = "ENUM_AREA@AREA_COOKIE";
        public const String AREA_BUILDING = "ENUM_AREA@AREA_BUILDING";
        public const String AREA_WIN = "ENUM_AREA@AREA_WIN";
    
        public static readonly List<String> values = JavaFeatureExtension.ArraysAsList(AREA_COOKIE, AREA_BUILDING, AREA_WIN);
    }
}
