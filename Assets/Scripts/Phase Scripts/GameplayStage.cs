using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayStage : Stage
{
    public enum GameplayPhases
    {
        Start,
        Shard,
        Selection,
        Battle,
        End
    }

    protected void Awake()
    {
        stateInitializerDict.Add(MatchStages.Gameplay, InitializeStep);
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void InitializeStep()
    {
        Debug.Log("Start Gameplay Stage");
    }
}
