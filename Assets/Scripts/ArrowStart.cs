using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowStart : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetKey(KeyCode.E))
        {
            PlayerMovement playerMovement = collision.gameObject.GetComponent<PlayerMovement>();

            if (playerMovement != null)
            {
                playerMovement.enabled = false;
            }
        }
    }
}
