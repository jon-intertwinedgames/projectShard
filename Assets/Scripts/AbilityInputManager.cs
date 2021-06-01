using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityInputManager : MonoBehaviour
{
    private Vector2 worldPosition;
    private Vector2 mousePos;
    private InitializeAbility intializeAbility;
    private ParticleEffectController particleEffectController;
    private List<ParticleSystem> energyAnimations;

    private void Start()
    {
        
    }

    private void OnMouseDown()
    {
        //Show attributes in the description box (ALL)

    }

    public void OnMouseDrag()
    {
        mousePos = Input.mousePosition;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);

        gameObject.transform.position = worldPosition;

    }

    public void OnMouseUp()
    {
        //If object is dropped on the arena, activate lock coroutine

        //Else ability snaps back to ability slot
        gameObject.transform.position = transform.parent.position;

        StartCoroutine("EndEnergyAnimation");

    }

    public void OnMouseDragEnter()
    {
        StartCoroutine("StartEnergyAnimation");
    }

    IEnumerator StartEnergyAnimation()
    {
        energyAnimations = gameObject.GetComponent<InitializeAbility>().energyAnimations;
        
        var direction = ParticleEffectController.startDirection;
        var arcSpeed = ParticleEffectController.arcSpeed;

        foreach (ParticleSystem element in energyAnimations)
        {
            particleEffectController = element.GetComponent<ParticleEffectController>();
            particleEffectController.particleShape.scale = direction;
            particleEffectController.particleShape.arcSpeed = arcSpeed; 

            element.Play();

            direction.x *= -1; // If the ability requires another energy, change the next particle effect to opposite rotation (counter)clockwise
            arcSpeed += ParticleEffectController.arcSpeedModifier; // If the ability requires another energy, increases rotation speed of next energy
      
        }

        yield return null;
    }

    IEnumerator EndEnergyAnimation()
    {
        foreach (ParticleSystem element in (gameObject.GetComponent<InitializeAbility>().energyAnimations))
        {
            element.Stop();
        }

        yield return null;
    }

}
