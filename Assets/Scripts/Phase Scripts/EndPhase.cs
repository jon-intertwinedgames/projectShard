using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPhase : Phase
{
    // Start is called before the first frame update
    protected override void Start()
    {
        stateInitializerDict.Add(GameplayStage.GameplayPhases.End, InitializeStep);
        base.Start();
    }

    protected override void InitializeStep()
    {
        Debug.Log("End Phase Initialized");
    }
}
