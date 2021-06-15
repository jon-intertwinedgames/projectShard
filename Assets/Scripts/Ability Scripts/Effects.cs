using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EffectType
{
    ReduceStat,
    IncreaseStat,
    AddAffliction,
    RemoveAffliction
}

public enum Affliction
{
    None,
    Blind,
    Burn,
    Poison,
    Stun,
    Taunt
}

[System.Serializable]
public struct Effect
{
    [Header("Effect Settings")]
    public EffectType effectType;
    public int effectAmount;
    public Affliction affliction;

    [Header("Target Settings")]
    public Target target;
    public int numberOfTargets;
    public bool isRandom;

    [Header("Timing Settings")]
    //public ExecuteTime executeTime; 
    public int duration;

}

public class Effects : MonoBehaviour
{
    private void Start()
    {
        randomClass();
    }
    public void randomClass(int num = 3)
    {

    }
}
