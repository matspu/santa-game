using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    public Rigidbody rb;


    void Update(){
        rb.AddForce(Random.Range(10, 15) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
