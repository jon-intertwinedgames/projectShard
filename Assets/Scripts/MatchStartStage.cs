using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchStartStage : Stage
{
    public enum StartPhases
    {
        LoadBackground,
        LoadCharacters,
        LoadAbilities,
        LoadEnergies,
        LoadDescription,
        DecideStart,
    }

    protected void Awake()
    {
        stateInitializerDict.Add(MatchStages.MatchStart, InitializeStep);
    }

    protected override void Start()
    {
        // Start adding num stages here.
        base.Start();
    }

    protected override void InitializeStep()
    {
        Debug.Log("Start Match Start Stage");
    }
}
