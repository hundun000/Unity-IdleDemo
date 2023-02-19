using Assets.Scripts.DemoGameCore;
using Assets.Scripts.DemoGameCore.ui.screen;
using hundun.unitygame.adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DemoMenuScreenContainer : ScreenContainerMonoBehaviour<DemoMenuScreen>
{

    override protected void Start()
    {
        base.Start();

        this.Content = ((DemoScreenContext)DemoIdleGameContainer.Game.screenContext).menuScreen;

        Content.title = this.UiRoot.transform.Find("title").gameObject.GetComponent<Text>();
        Content.buttonContinueGame = this.UiRoot.transform.Find("buttonContinueGame").gameObject.GetComponent<Button>();
        Content.buttonNewGame = this.UiRoot.transform.Find("buttonNewGame").gameObject.GetComponent<Button>();

        Content.show();
    }


    void Update()
    {
        float delta = Time.deltaTime;
        Content.render(delta);

    }
}
