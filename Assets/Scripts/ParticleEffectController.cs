using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectController : MonoBehaviour
{
    // Static Variables
    [SerializeField] public static float arcSpeed = 1;
    [SerializeField] public static float arcSpeedModifier = .2f;
    [SerializeField] public static Vector3 startDirection = Vector3.one;
    [SerializeField] public Color selectionColor = new Color(255, 222, 0);

    private ParticleSystem instance;
    public ParticleSystem.MainModule particleMain;
    public ParticleSystem.ShapeModule particleShape;


    private void Start()
    {
        instance = gameObject.GetComponent<ParticleSystem>();
        particleMain = instance.main;
        particleShape = instance.shape;
    }


    public void OnMouseDown()
    {

    }

    public void changeToSelectionColor()
    {
        var main = instance.main;
        main.startColor = selectionColor;
    }


}

   

