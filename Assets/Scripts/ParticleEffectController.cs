using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectController : MonoBehaviour
{
    public Color selectionColor = Color.HSVToRGB(255,222,0);


    public void changeToSelectionColor()
    {
        ParticleSystem.MinMaxGradient color = gameObject.GetComponent<ParticleSystem>().main.startColor;

    }

}
