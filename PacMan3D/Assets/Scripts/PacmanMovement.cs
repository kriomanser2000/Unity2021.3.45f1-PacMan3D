using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    private Vector3 movement;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        movement = new Vector3(moveX, 0, moveZ).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity = movement * speed;
    }
}
