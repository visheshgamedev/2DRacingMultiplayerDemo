using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CarController : MonoBehaviour
{
    private Rigidbody2D carRigibody2D;
    private Vector2 carXMovement;

    [SerializeField] private float carMovementSpeed = 5.0f;

    private void Awake()
    {
        carRigibody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            carXMovement = Vector2.right;
        }
    }

    private void FixedUpdate()
    {
        if(GetComponent<PhotonView>().IsMine == true)
            carRigibody2D.velocity = carXMovement * carMovementSpeed;
    }
}