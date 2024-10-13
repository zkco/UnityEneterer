using JetBrains.Annotations;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class CharacterSelectButton : ButtonOnClickDefault
{
    [Header("Player")]
    [SerializeField] private SpriteRenderer _playerMainSprite;
    [SerializeField] private Animator _playerMainAnimator;
    [Header("Changed To")]
    [SerializeField] private Sprite _characterSprites;
    [SerializeField] private RuntimeAnimatorController _characterAnimator;
    [Header("CurrentSpriteChange")]
    [SerializeField] private Image _inputSprite;

    protected override void Awake()
    {
        base.Awake();
    }

    public void ChangeCharacter()
    {
        GameManager.Instance.Player.GetComponentInChildren<SpriteRenderer>().sprite = _characterSprites;
        _playerMainAnimator.runtimeAnimatorController = _characterAnimator;

        _inputSprite.sprite = _characterSprites;
    }
}