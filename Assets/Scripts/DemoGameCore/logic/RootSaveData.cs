using hundun.idleshare.gamelib;
using hundun.unitygame.gamelib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.DemoGameCore.logic
{
    public class RootSaveData
    {
        public GameplaySaveData gameplaySave;

        public RootSaveData(GameplaySaveData gameplaySave)
        {
            this.gameplaySave = gameplaySave;
        }
    }

    public class Factory : IFactory<RootSaveData, Object, GameplaySaveData> {

        public static readonly Factory INSTANCE = new Factory();

    public Object getSystemSave(RootSaveData rootSaveData)
    {
        return null;
    }

    public GameplaySaveData getGameplaySave(RootSaveData rootSaveData)
    {
        return rootSaveData.gameplaySave;
    }

    public RootSaveData newRootSave(GameplaySaveData gameplaySave, Object systemSettingSave)
    {
        return new RootSaveData(gameplaySave);
    }

    public GameplaySaveData newGameplaySave()
    {
        return new GameplaySaveData();
    }

    public Object newSystemSave()
    {
        return null;
    }

}
}
