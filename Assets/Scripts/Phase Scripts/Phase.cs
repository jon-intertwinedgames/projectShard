using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Phase : State
{
    public static int NumOfPhases
    {
        get;
        private set;
    }

    private static Enum currentPhase;

    public static Enum CurrentPhase
    {
        get => currentPhase;
        protected set
        {
            if (currentPhase != value)
            {
                currentPhase = value;

                try
                {
                    stateInitializerDict[currentPhase]();
                }
                catch (Exception e)
                {
                    throw new Exception("The given type isn't any kind of phase mentioned.");
                }
            }
        }
    }

    protected virtual void Start()
    {
        NumOfPhases++;
    }

    public static void GoToNextPhase<T>()
    {
        if (Convert.ToInt32(currentPhase) == NumOfPhases - 1)
        {
            CurrentPhase = (Enum)Enum.ToObject(typeof(T), 0);
        }
        else
        {
            CurrentPhase = (Enum)Enum.ToObject(typeof(T), Convert.ToInt32(currentPhase) + 1);
        }
    }

    protected abstract override void InitializeStep();
}
