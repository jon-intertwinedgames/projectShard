using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitySet : MonoBehaviour
{
    public List<GameObject> abilitySlots;
    public List<GameObject> abilitySet;

    // Start is called before the first frame update
    void Awake()
    {
        MoveAbilitiesToSlotPositions();
    }

    public void MoveAbilitiesToSlotPositions()
    {
        for (int i = 0; i < abilitySet.Count; i++)
        {
            abilitySet[i].transform.position = abilitySlots[i].transform.position;
        }
    }
}
