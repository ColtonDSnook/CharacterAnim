using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class BaseMovement : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float rotateSpeed;

    [Header("References")]
    [SerializeField]
    private Rigidbody myRigidbody;


    void Awake()
    {
        if (!myRigidbody)
        {
            myRigidbody = GetComponent<Rigidbody>();
        }
    }

    
    public void Move(Vector3 moveDirection)
    {
        myRigidbody.velocity = moveDirection.normalized * moveSpeed;
    }
}
