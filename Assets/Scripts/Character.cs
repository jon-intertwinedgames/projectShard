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

    public GameObject ability1;
    public GameObject ability2;
    public GameObject ability3;
    public GameObject ability4;

    /*Consider the following attributes later:
     * type
     * attack
     * defense
     * magic
     * description
     * passive ability
     * image animations
     */
}
