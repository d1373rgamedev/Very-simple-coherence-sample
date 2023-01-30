using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private float horizontalMovement;
    private float verticalMovement;

    // A field editable from inside Unity with a default value of 5
    public float speed = 5.0f;

    // How much will the player slide on the ground
    // The lower the value, the greater distance the user will slide
    public float drag;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        // This will detect forward and backward movement
        horizontalMovement = Input.GetAxisRaw("Horizontal");

        // This will detect sideways movement
        verticalMovement = Input.GetAxisRaw("Vertical");

        // Calculate the direction to move the player
        Vector3 movementDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;

        // Move the player
        rb.AddForce(movementDirection * speed, ForceMode.Force);
        // Apply drag
        rb.drag = drag;
    }
}