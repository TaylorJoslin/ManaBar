using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class playerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float moveSpeed;
    private Vector2 moveInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = moveInput * moveSpeed;
    }
}

   
    
