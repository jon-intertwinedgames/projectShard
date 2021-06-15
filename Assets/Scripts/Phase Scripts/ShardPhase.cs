using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShardPhase : Phase
{
    // Start is called before the first frame update
    protected override void Start()
    {
        stateInitializerDict.Add(GameplayStage.GameplayPhases.Shard, InitializeStep);
        base.Start();
    }

    protected override void InitializeStep()
    {
        Debug.Log("Shard Phase Initialized");
    }
}
