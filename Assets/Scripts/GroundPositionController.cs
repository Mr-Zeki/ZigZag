using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    private GroundSpawnController spawnController;

    private Rigidbody rb;

    [SerializeField] private float endYValue;

    private int groundDirection;


    private void Start()
    {
        spawnController = FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>();
    }

    private void CheckGroundVerticalLimit()
    {
       
        if (transform.position.y <= endYValue)
        {
            setRigidbodyValue();
            setGroundNewPosition();
        } 
    }

    private void setGroundNewPosition()
    {
        var groundPosition = spawnController.LastGroundObject.transform.position;
        groundDirection = Random.Range(0, 2);

        if (groundDirection == 0)
        {
            transform.position = new Vector3(groundPosition.x - 1f, groundPosition.y, groundPosition.z);
        }
        else
        {
            transform.position = new Vector3(groundPosition.x, groundPosition.y, groundPosition.z + 1f);
        }
        spawnController.LastGroundObject = gameObject;
    }

    private void setRigidbodyValue()
    {
        rb.isKinematic = true;
        rb.useGravity = false;
    }

    private void Update()
    {
        CheckGroundVerticalLimit();
    }

}
