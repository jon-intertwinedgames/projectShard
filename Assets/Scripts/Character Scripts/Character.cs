using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class Character : ScriptableObject
{
    [Header("General Information")]
    public new string name;
    public Sprite avatar;
    public Sprite background;

    [Header("Statistics")]
    public int currentHealth;
    public int maxHealth;
    public int armor;

    [Header("Abilities")]
    public List<Ability> abilities;

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
