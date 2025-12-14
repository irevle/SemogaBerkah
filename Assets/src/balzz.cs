using Unity.VisualScripting;
using UnityEngine;

public class balzz : MonoBehaviour
{
    #region Fields
    float force = 10f;
    float jump = 20f;
    Rigidbody rb;
    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/

    public void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {

        this.rb = this.GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * force);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * force);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * force);
        }
        else if (Input.GetKey(KeyCode.S)) 
        { 
            rb.AddForce(Vector3.back * force); 
        }else if (Input.GetKey(KeyCode.Space))
        { 
            rb.AddForce(Vector3.up * jump);
        }
    }
}
