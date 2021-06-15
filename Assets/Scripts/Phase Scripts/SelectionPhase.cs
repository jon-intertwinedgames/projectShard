using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionPhase : Phase
{
    // Start is called before the first frame update
    protected override void Start()
    {
        stateInitializerDict.Add(GameplayStage.GameplayPhases.Selection, InitializeStep);
        base.Start();
    }

    protected override void InitializeStep()
    {
        Debug.Log("Selection Phase Initialized");
    }

}
