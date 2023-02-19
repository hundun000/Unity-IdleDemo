using Assets.Scripts.DemoGameCore;
using hundun.unitygame.adapters;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DemoIdleGameContainer : ContainerMonoBehaviour<DemoIdleGame>
{

    public static DemoIdleGame Game { get; private set; }

    void Awake()
    {
        this.Content = new DemoIdleGame();
        DemoIdleGameContainer.Game = Content;
        Content.create();
    }

    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
