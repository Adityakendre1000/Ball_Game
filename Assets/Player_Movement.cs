using UnityEngine;

public class Player_Movement : MonoBehaviour
{   
    public Rigidbody rb;

    public float xForce = 200f;

    public float yForce = 200f;

    public float zForce = 200f;

    // Start is called before the first frame update
    void Start()
    {
        // rb.AddForce(xForce * Time.deltaTime ,yForce * Time.deltaTime ,zForce * Time.deltaTime );
        // I want to add friction to the player so that it stops moving after a while
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w")) {
            rb.AddForce(0,0,zForce * Time.deltaTime);
        }
        if (Input.GetKey("d")) {
            rb.AddForce(xForce * Time.deltaTime,0,0);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-xForce * Time.deltaTime,0,0);
        }
        if (Input.GetKey("s")) {
            rb.AddForce(0,0,-zForce * Time.deltaTime);
        }
    }
}
