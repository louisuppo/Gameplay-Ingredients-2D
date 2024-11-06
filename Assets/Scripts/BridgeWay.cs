using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BridgeWay : MonoBehaviour
{
    [SerializeField] private TextMeshPro TextPressE;

    [SerializeField] private Animator animBridge;
    [SerializeField] private Animator anim;

    private bool HandleFixIt = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("OUI");
        if (collision.CompareTag("Player") && (PlayerInventory.Instance.IsInInventory("LEVERHANDLE")) && (Input.GetKeyDown(KeyCode.E)))
        {
            Debug.Log("Levier add");

            anim.SetTrigger("Fix");
            PlayerInventory.Instance.RemoveItemFromInventory("LEVERHANDLE");
            Invoke("FixIt", 1f);
            TextPressE.text = "Press E again";
        }

        if (collision.CompareTag("Player") && HandleFixIt && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Levier active");
            animBridge.SetTrigger("Down");
            anim.SetTrigger("Active");
            TextPressE.gameObject.SetActive(false);
        }
    }

    private void FixIt()
    {
        HandleFixIt = true;
    }
        

    void Update()
    {
        if (PlayerInventory.Instance.IsInInventory("LEVERHANDLE"))
        {
            TextPressE.gameObject.SetActive(true);
        }

    }
}
