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

    public static SpawnArrows Instance;
    void Awake()
    {
        Instance = this;
    }

    void Start()
    {

    }

    public void startArrows()
    {
        Debug.Log("sdfjisdijfsdjfsd");
        InvokeRepeating("SpawnRight", 1f, 5f);
        InvokeRepeating("SpawnUp", 2f, 5f);
        InvokeRepeating("SpawnDown", 3f, 5f);
        InvokeRepeating("SpawnLeft", 4f, 5f);
    }

    private void SpawnRight()
    {
        GameObject ArrowRight = Instantiate(arrowRight, spawnArrowRight.position, spawnArrowRight.rotation);
        Rigidbody2D ArrowRightRB = ArrowRight.GetComponent<Rigidbody2D>();
        ArrowRightRB.velocity = spawnArrowRight.up * -speedArrows;    }

    private void SpawnUp()
    {
        GameObject ArrowUp = Instantiate(arrowUp, spawnArrowUp.position, spawnArrowUp.rotation);
        Rigidbody2D ArrowUpRB = ArrowUp.GetComponent<Rigidbody2D>();
        ArrowUpRB.velocity = spawnArrowUp.up * -speedArrows;
    }
    private void SpawnDown()
    {
        GameObject ArrowDown = Instantiate(arrowDown, spawnArrowDown.position, spawnArrowDown.rotation);
        Rigidbody2D ArrowDownRB = ArrowDown.GetComponent<Rigidbody2D>();
        ArrowDownRB.velocity = spawnArrowDown.up * -speedArrows;
    }
    private void SpawnLeft()
    {
        GameObject ArrowLeft = Instantiate(arrowLeft, spawnArrowLeft.position, spawnArrowLeft.rotation);
        Rigidbody2D ArrowLeftRB = ArrowLeft.GetComponent<Rigidbody2D>();
        ArrowLeftRB.velocity = spawnArrowLeft.up * -speedArrows;
    }
}
