using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject scoreText;
    public GameObject gameOverText;
    public ParticleSystem narutoEffect;


    public int forwardForce = 1500;

    public int score = 0;


    void Start(){
        ParticleSystem narutoEffect = GetComponent<ParticleSystem>();
    }

    void Update(){
        if(transform.position.y < -1f){
            StartCoroutine(Restart(1));

        }
    }


    public void ChangePSSpeed(int increase){
        narutoEffect.Stop();
        var particleMainSettings = narutoEffect.main;
        particleMainSettings.startSpeed = increase;
        narutoEffect.Play();
    }

    void FixedUpdate(){
        if(score <= 20){
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        } else if(score >= 20){
            rb.AddForce(0, 0, 1700 * Time.deltaTime);
            ChangePSSpeed(45);
        } else if(score >= 30){
            rb.AddForce(0, 0, 2000 * Time.deltaTime);
        } else{
            rb.AddForce(0, 0, 2500 * Time.deltaTime);
        }

        if(Input.GetKey("d")){
            rb.AddForce(45 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-45 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if(Input.GetKey("r")){
            Time.timeScale = 1;
            SceneManager.LoadScene("World");
        }
    }


    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "present"){
            Destroy(col.gameObject);
            score += 1;
            scoreText.GetComponent<TMPro.TextMeshProUGUI>().text = score.ToString();
        } 
    }
    

    




    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "tree"){
            StartCoroutine(Restart(3));
            //Time.timeScale = 0;
        }
    }

    IEnumerator Restart(int wait){
        gameOverText.SetActive(true);
        forwardForce = 500;
        yield return new WaitForSeconds(wait);
        SceneManager.LoadScene("World");
    }


}
