using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ability", menuName = "Ability")]
public class Ability : ScriptableObject
{
    [Header("General")]
    public new string name;
    public string description;
    public Sprite artwork;

    [Header("Cost")]
    public int cooldown;
    public List<Energy> energyCost = new List<Energy>();

    [Header("Functionality")]
    public List<Effect> effects = new List<Effect>();
}
