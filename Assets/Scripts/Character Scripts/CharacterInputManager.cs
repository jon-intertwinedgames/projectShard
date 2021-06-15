using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInputManager : MonoBehaviour
{
    private CharacterLoader initializeCharacter;
    private string placeholderText;

    public static event Action ClickedMe;

    private void Awake()
    {
        initializeCharacter = gameObject.GetComponent<CharacterLoader>();
    }

    public void OnMouseDown()
    {
        ClickedMe();
        //SetAbilities();
    }

    public void OnMouseOver()
    {
        DisplayDescription();
    }

    private void DisplayDescription()
    {
        placeholderText = "Placeholder Text";
        DescriptionManager.setNewDescription(
            initializeCharacter.character.name,
            placeholderText,
            initializeCharacter.character.avatar);
    }

    private void SetAbilities()
    {
        Debug.Log("Set Abilities was called.");
        //AbilityPanelDisplay.SetAbilities(initializeCharacter.abilities);
    }
}
