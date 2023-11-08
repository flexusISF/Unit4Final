using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float speed = 2.0f;
    private GameObject focalPoint;
    public bool hasPowerup;
    public bool isOnGround = true;
    public float jumpForce;
    public float gravityModifier;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector2.right * speed * forwardInput);
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = true;
        }
        
        
    }private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
