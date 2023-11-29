using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Goal : MonoBehaviour
{
    public TMP_Text scoreText;
    int score;
    // Start is called before the first frame update
    void Awake() {
        score = 0;
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Ball")){
            //goal scored
           
            score++;
            scoreText.text = "Score: " + score;
            other.transform.position = new Vector3(-3.134753f, 5.310856f, -1.361157f);
        }
    }
}
