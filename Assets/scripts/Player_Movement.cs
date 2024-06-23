using UnityEngine;

public class Player_Movement : MonoBehaviour
{   
    public Rigidbody rb;

    public float xForce;

    public float yForce;

    public float zForce;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w")) {
            rb.AddForce(0,0,zForce * Time.deltaTime,ForceMode.Acceleration);
        }

        if (Input.GetKey("s")) {
            rb.AddForce(0,0,-zForce * Time.deltaTime,ForceMode.Acceleration);
        }

        if (Input.GetKey("d")) {
            rb.AddForce(xForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rb.AddForce(-xForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
            FindObjectOfType<Game_Manager>().GameOver();
        }

        // Debug.Log(rb.velocity.magnitude);

    }
}
