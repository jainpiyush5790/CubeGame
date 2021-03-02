using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a refrence to the Rigidibody component called "rb"
    public Rigidbody rb;
          

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // we marked this as "FixedUpdate because we
    // are using it to mess with physics.

    


    void FixedUpdate ()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


       
    }
}