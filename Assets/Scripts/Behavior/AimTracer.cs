using UnityEditor.Tilemaps;
using UnityEngine;

public class AimTracer : MonoBehaviour
{
    private SpriteRenderer sprite;
    private GameController controller;

    private void Awake()
    {
        controller = GetComponent<GameController>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 vector)
    {
        flipCharacter(vector);
    }

    private void flipCharacter(Vector2 vector)
    {
        float rotZ = UnityEngine.Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        sprite.flipX = Mathf.Abs(rotZ) > 90;
    }
}
