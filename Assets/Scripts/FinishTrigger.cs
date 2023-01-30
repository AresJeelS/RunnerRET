using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehavior playerBehavior = other.attachedRigidbody.GetComponent<PlayerBehavior>();
        if (playerBehavior)
        {
            playerBehavior.StartFinishBehaviour();
            FindObjectOfType<GameManager>().ShowFinishWindow();
        }
    }
}
