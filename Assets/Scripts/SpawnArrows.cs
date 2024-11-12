using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArrows : MonoBehaviour
{
    [SerializeField] GameObject arrowRight;
    [SerializeField] GameObject arrowUp;
    [SerializeField] GameObject arrowDown;
    [SerializeField] GameObject arrowLeft;

    [SerializeField] Transform spawnArrowRight;
    [SerializeField] Transform spawnArrowUp;
    [SerializeField] Transform spawnArrowDown;
    [SerializeField] Transform spawnArrowLeft;

    [SerializeField] private float speedArrows;


    void Start()
    {
        Invoke("SpawnRight", 1f);
        Invoke("SpawnUp", 2f);
        Invoke("SpawnDown", 3f);
        Invoke("SpawnLeft", 4f);
    }

    private void SpawnRight()
    {
        GameObject ArrowRight = Instantiate(arrowRight, spawnArrowRight.position, spawnArrowRight.rotation);
        Rigidbody2D ArrowRightRB = ArrowRight.GetComponent<Rigidbody2D>();
        ArrowRightRB.velocity = spawnArrowRight.up * -speedArrows;
    }

    private void SpawnUp()
    {
        GameObject ArrowUp = Instantiate(arrowUp, spawnArrowUp.position, spawnArrowUp.rotation);
        Rigidbody2D ArrowUpRB = arrowUp.GetComponent<Rigidbody2D>();
        ArrowUpRB.velocity = spawnArrowUp.up * -speedArrows;
    }
    private void SpawnDown()
    {
        GameObject ArrowDown = Instantiate(arrowDown, spawnArrowDown.position, spawnArrowDown.rotation);
        Rigidbody2D ArrowDownRB = arrowDown.GetComponent<Rigidbody2D>();
        ArrowDownRB.velocity = spawnArrowDown.up * -speedArrows;
    }
    private void SpawnLeft()
    {
        GameObject ArrowLeft = Instantiate(arrowLeft, spawnArrowLeft.position, spawnArrowLeft.rotation);
        Rigidbody2D ArrowLeftRB = arrowLeft.GetComponent<Rigidbody2D>();
        ArrowLeftRB.velocity = spawnArrowLeft.up * -speedArrows;
    }
}
