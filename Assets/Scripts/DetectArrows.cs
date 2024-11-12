using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DetectArrows : MonoBehaviour
{
    private int score = 0;
    public TextMeshPro textScore;

    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.gameObject.CompareTag("ArrowRight") && Input.GetKey(KeyCode.RightArrow))
        {
            score++;
            Destroy(collision.gameObject);
            textScore.text = score.ToString();
        }
        if (collision.gameObject.CompareTag("ArrowUp") && Input.GetKey(KeyCode.UpArrow))
        {
            score++;
            Destroy(collision.gameObject);
            textScore.text = score.ToString();
        }
        if (collision.gameObject.CompareTag("ArrowDown") && Input.GetKey(KeyCode.DownArrow))
        {
            score++;
            Destroy(collision.gameObject);
            textScore.text = score.ToString();
        }
        if (collision.gameObject.CompareTag("ArrowLeft") && Input.GetKey(KeyCode.LeftArrow))
        {
            score++;
            Destroy(collision.gameObject);
            textScore.text = score.ToString();
        }

        //fix it ici
        else
        {
            void OnTriggerExit2D(Collider2D collision)
            {
                score--;
            }
        }
    }
}
