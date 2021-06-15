using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MatchEndStage : Stage
{
    public enum EndPhases
    {
        Winner,
        Reward,
    }

    protected void Awake()
    {
        stateInitializerDict.Add(MatchStages.MatchEnd, InitializeStep);
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void InitializeStep()
    {
        Debug.Log("Start Match End Stage");
    }

}
