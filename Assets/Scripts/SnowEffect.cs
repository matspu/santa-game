using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowEffect : MonoBehaviour
{
    public GameObject player;

    
    void Update(){
        transform.position = new Vector3(3.75f, player.transform.position.y, player.transform.position.z+22f);
    }
}
