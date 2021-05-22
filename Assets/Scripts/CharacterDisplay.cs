using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterDisplay : MonoBehaviour
{
    public Character character;

    public Image avatar;
    public Image background;

    //if using regular text, replace TMPUGUI with Text reference type
    //public TextMeshProUGUI nameText;
    public TextMeshProUGUI currentHealthText;
    public TextMeshProUGUI maxHealthText;
    //public TextMeshProUGUI armorText;

    void Start()
    {
        avatar.sprite = character.avatar;
        background.sprite = character.background;

        //nameText.text = character.name;
        currentHealthText.text = character.currentHealth.ToString();
        maxHealthText.text = character.maxHealth.ToString();

        //armorText.text = character.armor.ToString();

    }

}
