using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Vector2 worldPosition;
    private Vector2 mousePos;


    private void OnMouseDown()
    {
        //Show attributes in the description box (ALL)

        //Disable Energy sprite and Activate Energy animation (Abilities)
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
        Vector3 startDirection = new Vector3(1,1,1);
        float startSpeed = 1;
        ParticleSystem.ShapeModule particleShape;

        foreach (ParticleSystem element in (gameObject.GetComponent<InitializeAbility>().energyAnimations))
        {
            particleShape = element.shape;
            particleShape.scale = startDirection; // Sets the rotation of the energy particle effect to be counterclockwise 
            particleShape.arcSpeed = startSpeed; // Sets the speed of rotation of the energy particle effect around the ability

            element.Play();

            startDirection.x *= -1; // If the ability requires another energy, change the next particle effect to opposite rotation (counter)clockwise
            startSpeed += .2f; // If the ability requires another energy, increases rotation speed of next energy
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
