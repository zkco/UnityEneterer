using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private GameController m_Controller;
    private Transform playerTransform;

    private void Awake()
    {
        m_Controller = gameObject.GetComponent<GameController>();
        playerTransform = GameManager.Instance.playerTransform;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, -10);
    }
}
