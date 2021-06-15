using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Stage : State
{
    public enum MatchStages
    {
        MatchStart,
        Gameplay,
        MatchEnd
    }

    public static int NumOfStages
    {
        get;
        private set;
    }

    private static MatchStages currentStage;

    public static MatchStages CurrentStage
    {
        get => currentStage;
        protected set
        {
            if (currentStage != value)
            {
                currentStage = value;

                try
                {
                    stateInitializerDict[currentStage]();
                }
                catch (Exception e)
                {
                    throw new Exception("The given type isn't any kind of stage mentioned.");
                }
            }
        }
    }

    protected virtual void Start()
    {
        NumOfStages++;
    }

    public static void GoToNextStage()
    {
        if ((int)CurrentStage == NumOfStages - 1)
        {
            CurrentStage = 0;
        }
        else
        {
            CurrentStage += 1;
        }
    }

    protected abstract override void InitializeStep();
}
