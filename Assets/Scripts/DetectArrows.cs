using TMPro;
using UnityEngine;

public enum Direction{
    NONE,
    LEFT,
    RIGHT,
    TOP, 
    DOWN
}

public class DetectArrows : MonoBehaviour
{
    public static float score = 0;
    public TextMeshPro textScore;

    public GameObject arrowCue;
    public Direction direction;


    private void Update()
    {
        if (score<= -10)
        {
            score = -10;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (direction == Direction.RIGHT && arrowCue != null)
            {
                ValidInput(arrowCue);
            }
            else
            {
                score--;
                textScore.text = score.ToString();
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (direction == Direction.LEFT && arrowCue != null)
            {
                ValidInput(arrowCue);
            }
            else
            {
                score--;
                textScore.text = score.ToString();
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (direction == Direction.TOP && arrowCue != null)
            {
                ValidInput(arrowCue);
            }
            else
            {
                score--;
                textScore.text = score.ToString();
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (direction == Direction.DOWN && arrowCue != null)
            {
                ValidInput(arrowCue);
            }
            else
            {
                score--;
                textScore.text = score.ToString();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ArrowRight"))
        {
            arrowCue = collision.gameObject;
            direction = Direction.RIGHT;
        }
        if (collision.gameObject.CompareTag("ArrowLeft"))
        {
            arrowCue = collision.gameObject;
            direction = Direction.LEFT;
        }
        if (collision.gameObject.CompareTag("ArrowUp"))
        {
            arrowCue = collision.gameObject;
            direction = Direction.TOP;
        }
        if (collision.gameObject.CompareTag("ArrowDown"))
        {
            arrowCue = collision.gameObject;
            direction = Direction.DOWN;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        arrowCue = null;
        direction = Direction.NONE;
    }


    //void OnTriggerStay2D(Collider2D collision)
    //{
    //    Debug.Log(collision.name);
    //    bool valid = true;
    //    if (Input.GetKey(KeyCode.RightArrow))
    //    {
    //        if (collision.gameObject.CompareTag("ArrowRight"))
    //        {
    //            ValidInput(collision.gameObject);
    //        }
    //        else
    //        {
    //            valid = false;
    //        }
    //    }
    //    //else if (collision.gameObject.CompareTag("ArrowUp") && Input.GetKey(KeyCode.UpArrow))
    //    //{
    //    //    score++;
    //    //    Destroy(collision.gameObject);
    //    //    textScore.text = score.ToString();
    //    //}
    //    //else if(collision.gameObject.CompareTag("ArrowDown") && Input.GetKey(KeyCode.DownArrow))
    //    //{
    //    //    score++;
    //    //    Destroy(collision.gameObject);
    //    //    textScore.text = score.ToString();
    //    //}
    //    //else if(collision.gameObject.CompareTag("ArrowLeft") && Input.GetKey(KeyCode.LeftArrow))
    //    //{
    //    //    score++;
    //    //    Destroy(collision.gameObject);
    //    //    textScore.text = score.ToString();
    //    //}
    //    if (!valid)
    //    {
    //        score--;
    //        textScore.text = score.ToString();

    //    }
    //    //fix it ici
    //}

    void ValidInput(GameObject arrow)
    {
        score++;
        Destroy(arrow);
        textScore.text = score.ToString();
    }
}
