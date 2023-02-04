using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Present : MonoBehaviour
{
    void Update(){
        transform.Rotate(0, 70 * Time.deltaTime, 0);
    }


    
}
