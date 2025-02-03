using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] private GroundDataTransmitter dataTransmitter;
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            dataTransmitter.setGroundRigidBodyValue();
        }
    }
}
