using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnergyManager : MonoBehaviour
{
    public static EnergyManager instance = null;
    public static bool isInitialized = false;

    private static Dictionary<EnergyType, int> energyPoolDictionary = new Dictionary<EnergyType, int>();
    public static Dictionary<EnergyType, int> EnergyPoolDictionary = new Dictionary<EnergyType, int>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if (isInitialized) return;
        isInitialized = true;

        InitializeEnergyPool();
    }

    private void InitializeEnergyPool()
    {
        energyPoolDictionary.Add(EnergyType.Physical, 0);
        energyPoolDictionary.Add(EnergyType.Magic, 0);
        energyPoolDictionary.Add(EnergyType.Skill, 0);
        energyPoolDictionary.Add(EnergyType.Spirit, 0);
    }

    private void AddEnergyToPool(EnergyType energyType)
    {
        energyPoolDictionary[energyType] ++;
    }

    private void AddEnergyToPool(EnergyType energyType, int amount)
    {
        energyPoolDictionary[energyType] += amount;
    }

    //remove energy from pool
}
