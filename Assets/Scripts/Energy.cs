using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnergyType
{
    Physical,
    Magic,
    Skill,
    Spirit,
    Prism
}

public class Energy : ScriptableObject 
{
    public EnergyType energyType;
    public Sprite sprite;
    public ParticleSystem energyAnimation;
}
