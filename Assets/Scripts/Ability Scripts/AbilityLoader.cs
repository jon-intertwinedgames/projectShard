using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityLoader : MonoBehaviour
{
    //Ability Variables
    public Ability ability;
    public Image abilityArtwork;
    public string abilityDescription;

    //Energy Variables
    public GameObject energyPrefab;
    [HideInInspector] public List<Energy> energyCost;
    [HideInInspector] public List<ParticleSystem> energyAnimations;

    private void Awake()
    {
        InitializeAbilityInfo();
        InitializeCost();
    }

    private void InitializeAbilityInfo()
    {
        transform.name = ability.name;
        abilityArtwork.sprite = ability.artwork;
        abilityDescription = ability.description;
    }

    private void InitializeCost()
    {
        energyCost = new List<Energy>(ability.energyCost);
        energyAnimations = new List<ParticleSystem>();

        foreach (Energy element in energyCost)
        {
            CreateEnergyCost(element);
            CreateEnergyDragAnimation(element);
        }
    }

    private void CreateEnergyCost(Energy energy)
    {
        //The prefab instantiates under the "Cost" child. 
        energyPrefab = Instantiate(energyPrefab, Vector3.zero, Quaternion.identity, transform.GetChild(1));
        energyPrefab.GetComponent<EnergyLoader>().energy = energy;
        energyPrefab.name = energy.name;
    }

    private void CreateEnergyDragAnimation(Energy energy)
    {
        ParticleSystem energyAnimation = Instantiate(energy.energyAnimation, Vector3.zero, Quaternion.identity, transform.GetChild(0));
        energyAnimation.transform.position = transform.parent.position;
        energyAnimations.Add(energyAnimation);
    }

}
