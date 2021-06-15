using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterLoader : MonoBehaviour
{
    [Header("General")]
    public Character character;
    public Image avatar;
    public Image background;

    [Header("Stats")]
    public TextMeshProUGUI currentHealthText;
    public TextMeshProUGUI maxHealthText;

    [Header("Abilities")]
    public List<Ability> abilitySet = new List<Ability>();
    public GameObject abilityPrefab;

    void Awake()
    {
        InitializeCharacterArt();
        InitializeCharacterStats();
    }

    private void InitializeCharacterArt()
    {
        avatar.sprite = character.avatar;
        background.sprite = character.background;
    }

    private void InitializeCharacterStats()
    {
        currentHealthText.text = character.currentHealth.ToString();
        maxHealthText.text = character.maxHealth.ToString();
    }

    private void InitializeCharacterAbilities()
    {

    }
}
