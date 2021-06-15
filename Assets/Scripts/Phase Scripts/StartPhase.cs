using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPhase : Phase
{

    protected void Awake()
    {
        stateInitializerDict.Add(GameplayStage.GameplayPhases.Start, InitializeStep);
    }

    protected override void Start()
    {        
        CurrentPhase = GameplayStage.GameplayPhases.Start;
        base.Start();
    }

    protected override void InitializeStep()
    {
        Debug.Log("Start Phase Initialized");
    }
}
