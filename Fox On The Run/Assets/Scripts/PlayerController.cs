using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 7f;
    public float zRange = 7.0f;
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);  
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.up * Time.deltaTime * horizontalInput * speed);
    }
}
