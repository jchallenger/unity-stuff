using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForce : MonoBehaviour
{
    Rigidbody rb;

    float force = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0){
            rb.AddForce(Vector3.right * force, ForceMode.Force);
        } else if(Input.GetAxis("Horizontal") < 0){
            rb.AddForce(-Vector3.right * force, ForceMode.Force);
        }

        if(Input.GetAxis("Vertical") > 0){
            rb.AddForce(Vector3.forward * force, ForceMode.Force);
        } else if(Input.GetAxis("Vertical") < 0){
            rb.AddForce(-Vector3.forward * force, ForceMode.Force);
        }
    }
}
