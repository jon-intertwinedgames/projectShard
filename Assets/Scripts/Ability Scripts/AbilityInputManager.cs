using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityInputManager : MonoBehaviour
{
    private Vector2 worldPosition;
    private Vector2 mousePos;
    private Vector2 defaultAbilityPos;
    private AbilityLoader abilityLoader;
    private ParticleEffectController particleEffectController;
    private List<ParticleSystem> energyAnimations;

    //public ParticleSystem selectedAnimation;
    //private bool isSelected;

    private void Awake()
    {
        abilityLoader = gameObject.GetComponent<AbilityLoader>();
    }

    public void OnMouseDown()
    {
        DisplayDescription();
        //DescriptionManager.resetSelectedItem();
        //DescriptionManager.setSelectedItem(this.gameObject); 
    }

    public void OnMouseUp()
    {
        //gameObject.transform.position = transform.parent.position;
        //GetComponentInParent<HorizontalLayoutGroup>().CalculateLayoutInputHorizontal();
        GetComponentInParent<AbilitySet>().MoveAbilitiesToSlotPositions();
        StartCoroutine("EndEnergyAnimation");
    }

    public void OnMouseDrag()
    {
        mousePosToWorldPos();
        gameObject.transform.position = worldPosition;
    }

    public void OnMouseOver()
    {
        DisplayDescription();
    }
    public void OnMouseDragEnter()
    {
        DisplayDescription();
        StartCoroutine("StartEnergyAnimation");
    }

    private void mousePosToWorldPos()
    {
        mousePos = Input.mousePosition;
        worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
    }

    private void DisplayDescription()
    {
        DescriptionManager.setNewDescription(
            abilityLoader.ability.name,
            abilityLoader.ability.description,
            abilityLoader.ability.artwork);
    }

    IEnumerator StartEnergyAnimation()
    {
        energyAnimations = abilityLoader.energyAnimations;
        
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
        foreach (ParticleSystem element in (abilityLoader.energyAnimations))
        {
            element.Stop();
        }

        yield return null;
    }

    public static IEnumerator StartSelectedAnimation()
    {
       // if(gameObject.instance.tag == "Selected")
        yield return null;
    }

}
