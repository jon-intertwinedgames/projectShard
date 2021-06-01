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


    private void OnMouseDown()
    {
        changeToSelectionColor();
    }

    public void changeToSelectionColor()
    {
        Debug.Log("Entered Selection Color Change");
        var main = instance.main;
        main.startColor = selectionColor;
        //instance.main = ParticleSystem.MainModule;
        //instance.main.startColor = selectionColor.linear;
        //particleMain.startColor = selectionColor;
        
    }

    public void setRotationDirection(float direction)
    {
        //particleShape.scale = (direction,1,1);
        //startDirection.x *= -1;
    }

    public void increaseStartSpeed()
    {
        arcSpeed += arcSpeedModifier;
    }

    public void setArcSpeed(float speedModifier)
    {
        particleShape.arcSpeed = speedModifier;
    }


}

   

