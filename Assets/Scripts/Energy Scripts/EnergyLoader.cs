using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyLoader : MonoBehaviour
{
    public Energy energy;
    public Image energyArtwork;

    void Awake()
    {
        InitializeEnergyInfo();
    }

    private void InitializeEnergyInfo()
    {
        energyArtwork.sprite = energy.sprite;
    }
}
