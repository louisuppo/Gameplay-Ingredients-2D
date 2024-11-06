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
        }
    }

    private void AlienATK()
    {
        animAlien.SetTrigger("Alien");
    }
}
