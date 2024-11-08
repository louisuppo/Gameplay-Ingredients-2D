using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    [SerializeField] int nextLevel;
    public bool needGem;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (needGem==true)
        {
            if (collision.CompareTag("Player") && (PlayerInventory.Instance.IsInInventory("REDGEM")))
            {
                PlayerInventory.Instance.RemoveItemFromInventory("REDGEM");
                SceneManager.LoadScene(nextLevel);
            }
        }

        else if (needGem==false)
        {
            if (collision.CompareTag("Player"))
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}
