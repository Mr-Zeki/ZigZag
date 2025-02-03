using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    public GameObject LastGroundObject;

    [SerializeField] private GameObject groundPrefab;

    private GameObject newGroundObject;

    private int direction;


    private void Start()
    {
        GenerateRandomNewGrounds();
    }

    private void CreateNewGround()
    {
        var groundPosition = LastGroundObject.transform.position;
        direction = Random.Range(0, 2);

        if (direction == 0 )
        {
            newGroundObject = Instantiate(groundPrefab,new Vector3(groundPosition.x - 1f, groundPosition.y, groundPosition.z ), Quaternion.identity);
            LastGroundObject = newGroundObject;
        }
        else
        {
            newGroundObject = Instantiate(groundPrefab, new Vector3(groundPosition.x, groundPosition.y, groundPosition.z + 1f), Quaternion.identity);
            LastGroundObject = newGroundObject;
        }
    }

    private void GenerateRandomNewGrounds()
    {
        for (int i = 0; i < 100; i++)
        {
            CreateNewGround();
        }
    }

}
