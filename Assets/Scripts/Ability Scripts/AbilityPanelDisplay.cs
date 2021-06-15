using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityPanelDisplay : MonoBehaviour
{
    public List<GameObject> abilities;

    private void Start()
    {
        CharacterInputManager.ClickedMe += delegate { gameObject.SetActive(true); };
    }

    public void SetAbilities(List<Ability> newAbilities)
    {
        int i = 0;

        foreach (GameObject element in abilities)
        {
            element.GetComponent<AbilityLoader>().ability = newAbilities[i];
            i++;
        }
    }
}
