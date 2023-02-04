using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform player;
    public GameObject [] items;
    private int item;

    void Start(){
        StartCoroutine(Spawn());
        StartCoroutine(SpawnSnowball());
        StartCoroutine(SpawnIce());
    }




    IEnumerator Spawn(){
        yield return new WaitForSeconds(0.5f);
        item = Random.Range(0, 2);
        transform.position = new Vector3(Random.Range(0f, 8f), player.position.y, player.position.z +100f);
        if(item == 0){
            GameObject itemSpawn = Instantiate(items[0], transform.position, Quaternion.identity);
            Destroy(itemSpawn, 10);
        } else if(item == 1){
            GameObject itemSpawn = Instantiate(items[1], new Vector3(transform.position.x, transform.position.y-0.5f, transform.position.z), Quaternion.Euler(-90f, 0f, 0f));
            Destroy(itemSpawn, 10);
        }

        
    
        StartCoroutine(Spawn());
    }

    IEnumerator SpawnSnowball(){
        yield return new WaitForSeconds(5);
        GameObject snowball = Instantiate(items[2], new Vector3(-7f, transform.position.y, transform.position.z-65f), Quaternion.identity);
        Destroy(snowball, 5);
        StartCoroutine(SpawnSnowball());
    }

    IEnumerator SpawnIce(){
        yield return new WaitForSeconds(3);
        GameObject ice = Instantiate(items[3], new Vector3(4f, transform.position.y-0.54f, transform.position.z-65f), Quaternion.identity);
        Destroy(ice, 5);
        StartCoroutine(SpawnIce());
    }

    

}
