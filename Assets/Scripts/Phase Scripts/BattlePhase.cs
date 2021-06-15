using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePhase : Phase
{
    // Start is called before the first frame update
    protected override void Start()
    {
        stateInitializerDict.Add(GameplayStage.GameplayPhases.Battle, InitializeStep);
        base.Start();
    }

    protected override void InitializeStep()
    {
        Debug.Log("Battle Phase Initialized");
    }

}
