using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFlag1 : MonoBehaviour
{
    [SerializeField] int nextLevel;
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && (PlayerInventory.Instance.IsInInventory("GREENKEY")))
        {
            PlayerInventory.Instance.RemoveItemFromInventory("GREENKEY");
            SceneManager.LoadScene(nextLevel);
        }
    }
}
