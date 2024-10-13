using UnityEngine;
using UnityEngine.UI;

public class CurrentCharacterSprite : MonoBehaviour
{
    private Sprite mySprite;
    public Sprite InputSprite;

    public bool isChanged = false;

    private void Awake()
    {
        mySprite = GetComponent<Image>().sprite;
    }

    private void Update()
    {
        if(isChanged == true)
        {
            mySprite = InputSprite;
            isChanged = false;
        }
    }
}