using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializeAbility : MonoBehaviour
{
    // Ability Variables
    public Ability ability;
    public Image abilityArtwork;
    public string abilityDescription;

    // Energy Variables
    public GameObject energyPrefab;

    [HideInInspector] //List of energy cost (according to SO)
    public List<Energy> energyCost;

    [HideInInspector] //List of all energy particle effects
    public List<ParticleSystem> energyAnimations;     

    private void Start()
    {
        transform.name = ability.name;
        abilityArtwork.sprite = ability.artwork;
        abilityDescription = ability.description;

        InitializeCost();
    }

    private void InitializeCost()
    {
        energyCost = new List<Energy>(ability.cost); //Reference "Energy List" of Ability SO
        energyAnimations = new List<ParticleSystem>();

        foreach (Energy element in energyCost)
        {
            establishEnergy(element);
            establishParticleEffect(element);
        }
    }

    // Instantiate an energy prefab and assign it the proper Energy type
    private void establishEnergy(Energy energy)
    {
        energyPrefab = Instantiate(energyPrefab, Vector3.zero, Quaternion.identity, transform.GetChild(1));
        energyPrefab.GetComponent<InitializeEnergy>().energy = energy;
        energyPrefab.name = energy.name;
    }


    // Instantiate energy particle effect and add it to the "Energy Animation List"
    private void establishParticleEffect(Energy energy)
    {
        ParticleSystem energyAnimation = Instantiate(energy.energyAnimation, Vector3.zero, Quaternion.identity, transform.GetChild(0));
        energyAnimation.transform.position = transform.parent.position;
        energyAnimations.Add(energyAnimation);
    }

}
