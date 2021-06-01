using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializeEnergy : MonoBehaviour
{
    public Energy energy;
    public Image energyArtwork;

    void Start()
    {
        energyArtwork.sprite = energy.sprite;
    }

}
