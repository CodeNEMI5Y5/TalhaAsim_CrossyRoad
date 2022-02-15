using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Vector3 playerMovement;
    private Vector3 currentPosition;
    
    public Rigidbody rb;
    public float jumpForce;
    


    private void Start()
    {
        //Getting the rigidbody of the object this script is attached to
        rb = GetComponent<Rigidbody>();                     
    }

    void Update()
    {

            currentPosition = transform.position;

            //Getting the horizontal and vertical input of user into a vector3 Variable
            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                playerMovement.z = Input.GetAxisRaw("Horizontal");
                VerticalMove();
            }

            else if (Input.GetAxisRaw("Vertical") != 0)
            {
                playerMovement.x = Input.GetAxisRaw("Vertical");
                HorizontalMove();
            }


    }


    private void HorizontalMove()
    {
        rb.AddForce(0, jumpForce, jumpForce);
    }

    private void VerticalMove()
    {
        rb.AddForce(jumpForce, jumpForce, 0);
    }
}
