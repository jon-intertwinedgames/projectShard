using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public new string name;
    public Sprite avatar;
    public Sprite background;

    public int currentHealth;
    public int maxHealth;
    public int armor;

    public Ability ability1;
    public Ability ability2;
    public Ability ability3;
    public Ability ability4;

    /*Consider the following attributes later (they can be added to a dictionary):
     * type
     * attack
     * defense
     * magic
     * description
     * passive ability
     * image animations
     */
}
