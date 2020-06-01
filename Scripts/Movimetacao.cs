using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimetacao : MonoBehaviour
{

    private Rigidbody rb;
    public float velocidade;
    private float vertical;
    private float horizontal;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        rb.velocity = new Vector3(horizontal, rb.velocity.y, vertical) * velocidade;
    }
}
