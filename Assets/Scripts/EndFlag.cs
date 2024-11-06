using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && (PlayerInventory.Instance.IsInInventory("REDGEM")))
        {
            PlayerInventory.Instance.RemoveItemFromInventory("REDGEM");
        }
    }
}
