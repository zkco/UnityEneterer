using Unity.VisualScripting;
using UnityEngine;

public class ButtonOnClickDefault : MonoBehaviour
{
    [SerializeField] protected GameObject UI;

    protected virtual void Awake()
    {
        
    }

    public void ChangeSetActiveStatusToFalse()
    {
        if(UI.activeSelf == true)
        {
            UI.SetActive(false);
        }
    }
    public void ChangeSetActiveStatusToTrue()
    {
        if (UI.activeSelf == false)
        {
            UI.SetActive(true);
        }
    }
}
