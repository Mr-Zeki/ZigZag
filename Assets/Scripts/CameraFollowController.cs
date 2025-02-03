using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    [SerializeField] private Transform target;

    private Vector3 offset;

    [SerializeField][Range(0,3)] private float lerpValue;

    private Vector3 newPosition;

    void Start()
    {
        offset = transform.position - target.position;    
    }

    private void LateUpdate()
    {
        SetCameraSmoothFollow();   
    }

    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, target.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }


}
