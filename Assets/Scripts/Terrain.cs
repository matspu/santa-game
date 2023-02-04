using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain : MonoBehaviour
{
    public Transform player;
    public GameObject snow;


    void Update(){
        Instantiate(snow, new Vector3(player.position.x, player.position.y-0.5f, player.position.z), Quaternion.identity);
    }
}
