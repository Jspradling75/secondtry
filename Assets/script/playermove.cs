using UnityEngine;

public class playermove : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "Rb"
    public Rigidbody Rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked this "Fixed"Update because we are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if( Input.GetKey("d") )
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
