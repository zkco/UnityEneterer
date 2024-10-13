using UnityEngine;

[CreateAssetMenu(fileName = "DefaultStat", menuName = "Stat/Default/Default", order = 0)]
public class DefaultStat : ScriptableObject
{
    [Header("Base Stats")]
    public string _name = string.Empty;
    public float speed;
}
