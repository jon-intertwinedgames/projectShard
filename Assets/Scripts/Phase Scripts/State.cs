using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    protected static Dictionary<Enum, Action> stateInitializerDict = new Dictionary<Enum, Action>();

    protected abstract void InitializeStep();
}
