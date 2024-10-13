using UnityEngine;
using UnityEngine.UI;

public class SubmitCharacterNameButton : ButtonOnClickDefault
{
    [SerializeField] private InputField inputField;
    [SerializeField] private Text PlayerName;

    protected override void Awake()
    {
        base.Awake();
        
    }

    public void SubmitCharacterName()
    {
        string nameHolder = inputField.text;
        PlayerName.text = nameHolder;
    }
}