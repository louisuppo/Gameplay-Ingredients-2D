using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ArrowStart : MonoBehaviour
{
    bool inPuzzel = true;
    [SerializeField] GameObject key;
    [SerializeField] GameObject laserbem;
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Input.GetKey(KeyCode.E) && inPuzzel == true)
        {
            inPuzzel = false;
            PlayerMovement playerMovement = collision.gameObject.GetComponent<PlayerMovement>();

            if (playerMovement != null)
            {
                SpawnArrows.Instance.startArrows();
                playerMovement.enabled = false;
            }
        }
        if (DetectArrows.score == 8)
        {
            restartMouv(collision.gameObject);
        }            //temps de tout le puzzle

    }

    void restartMouv (GameObject collision)
    {
        inPuzzel = true;
        key.SetActive(true);
        laserbem.SetActive(true);
        PlayerMovement playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
        playerMovement.enabled = true;
        Debug.Log("Finish");
    }
}
