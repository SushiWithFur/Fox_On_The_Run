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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    public bool isOnGround = true;
    public bool gameOver = false;
=======
    public bool isOnGround = true; 
>>>>>>> master
=======
    public bool isOnGround = true; 
>>>>>>> parent of 933d72d... Fixed backup error, lost some data, reworking lost data
=======
    public bool isOnGround = true; 
>>>>>>> parent of 933d72d... Fixed backup error, lost some data, reworking lost data
=======
    public bool isOnGround = true;
    public bool gameOver = false;
>>>>>>> parent of a50a0b9... Merge remote-tracking branch 'origin/master'

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnGround) 
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
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
    private void OnCollisionEnter(Collision collision)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of a50a0b9... Merge remote-tracking branch 'origin/master'
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        else if(collision.gameObject.CompareTag("Hunter"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
        }
       
<<<<<<< HEAD
=======
        isOnGround = true;
>>>>>>> master
=======
        isOnGround = true;
>>>>>>> parent of 933d72d... Fixed backup error, lost some data, reworking lost data
=======
        isOnGround = true;
>>>>>>> parent of 933d72d... Fixed backup error, lost some data, reworking lost data
=======
>>>>>>> parent of a50a0b9... Merge remote-tracking branch 'origin/master'
    }
}
