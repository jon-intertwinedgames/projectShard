using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializeAbility : MonoBehaviour
{
    public Ability ability;
    public Image abilityArtwork;
    public GameObject energyPrefab;

    [HideInInspector]
    public List<ParticleSystem> energyAnimations;

    private void Start()
    {
        abilityArtwork.sprite = ability.artwork;
        transform.name = ability.name;

        InitializeCost();
    }

    private void InitializeCost()
    {
        energyAnimations = new List<ParticleSystem>();

        foreach (Energy element in ability.cost)
        {
           energyPrefab = Instantiate(energyPrefab, Vector3.zero, Quaternion.identity, transform.GetChild(1));
           energyPrefab.GetComponent<InitializeEnergy>().energy = element;
           energyPrefab.name = element.name;

           ParticleSystem energyAnimation = Instantiate(element.energyAnimation, Vector3.zero, Quaternion.identity, transform.GetChild(0));
           energyAnimation.transform.position = transform.parent.position;
           energyAnimations.Add(energyAnimation);
        }
    }



}
