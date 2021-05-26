using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializeAbility : MonoBehaviour
{
    public Ability ability;
    public Image abilityArtwork;
    public GameObject energyPrefab;

    private void Start()
    {
        abilityArtwork.sprite = ability.artwork;

        InitializeCost();
    }

    private void InitializeCost()
    {
        foreach (Energy element in ability.cost)
        {
            Instantiate(energyPrefab, new Vector3(0, 0, 0), Quaternion.identity, transform.Find("Cost"));
            energyPrefab.GetComponent<InitializeEnergy>().energy = element;
            energyPrefab.name = element.name;
        }
    }


}
