using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Vector2 worldPosition;
    private Vector2 mousePos;

    private void OnMouseOver()
    {

    }

    private void OnMouseExit()
    {

    }

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
        StartCoroutine("StartAnimation");

    }

    public void OnMouseUp()
    {
        //If object is dropped on the arena, activate lock coroutine

        //Else ability snaps back to ability slot
        gameObject.transform.position = transform.parent.position;

        StartCoroutine("EndAnimation");

    }

    IEnumerator StartAnimation()
    {
        foreach (ParticleSystem element in (gameObject.GetComponent<InitializeAbility>().energyAnimations))
        {
            element.Play();
        }

        yield return null;
    }

    IEnumerator EndAnimation()
    {
        foreach (ParticleSystem element in (gameObject.GetComponent<InitializeAbility>().energyAnimations))
        {
            element.Stop();
        }

        yield return null;
    }

}
