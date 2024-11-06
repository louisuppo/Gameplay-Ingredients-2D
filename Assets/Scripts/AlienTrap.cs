using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienTrap : MonoBehaviour
{
    public Animator animAlien;
    public Animator animLight;
    [SerializeField] private Animator animButton;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OUI");
        if (collision.CompareTag("Player"))
        {
            animButton.SetTrigger("Push");
            animLight.SetTrigger("Bug");
            Invoke("AlienATK", 1f);
            Invoke("AlienThief", 3.5f);
        }
    }

    private void AlienATK()
    {
        animAlien.SetTrigger("Alien");
    }

        private void AlienThief()
    {
        PlayerInventory.Instance.RemoveItemFromInventory("GREENKEY");
    }
}
