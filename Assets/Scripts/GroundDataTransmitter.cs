using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmitter : MonoBehaviour
{
    [SerializeField] private GroundFallController controller;

    public void setGroundRigidBodyValue()
    {
        StartCoroutine(controller.SetRigidbodyValue());
    }
}
