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
        if (nameHolder.Length >= 2 && nameHolder.Length <= 10)
        {
            PlayerName.text = nameHolder;
            base.ChangeSetActiveStatusToFalse();
        }
    }
}