using Assets.Scripts.DemoGameCore;
using hundun.unitygame.adapters;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DemoIdleGameContainer
{
    private static DemoIdleGame game;
    public static DemoIdleGame Game { get {
            if (game == null)
            {
                game = new DemoIdleGame();
                game.create();
            }
            return game;
        }
    }

}
