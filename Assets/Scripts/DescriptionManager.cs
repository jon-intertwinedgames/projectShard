using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DescriptionManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI descriptionName;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private Image descriptionImage;

    public static DescriptionManager instance;
    public static GameObject selectedObject;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = gameObject.GetComponent<DescriptionManager>();
    }

    public static TextMeshProUGUI getDescriptionName()
    {
        return instance.descriptionName;
    }

    public static void setDescriptionName(string name)
    {
        instance.descriptionName.text = name;
    }

    public static TextMeshProUGUI getDescriptionText()
    {
        return instance.descriptionText;
    }

    public static void setDescriptionText(string text)
    {
        instance.descriptionText.text = text;
    }

    public static void setDescriptionImage(Image image)
    {
        instance.descriptionImage = image;
    }

    public static void setDescriptionImage(Sprite image)
    {

        instance.descriptionImage.sprite = image;
    }

    public static void setNewDescription(string name, string text, Sprite sprite)
    {
        setDescriptionName(name);
        setDescriptionText(text);
        setDescriptionImage(sprite);
    }

    /*Update selection color solution
    public static void setSelectedItem(GameObject gameObject)
    {
        selectedObject = gameObject;
        gameObject.tag = "Selected";
    }

    public static void resetSelectedItem()
    {

        selectedObject.tag = "Unselected";
    }
    */
}
