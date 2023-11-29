using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Goal : MonoBehaviour
{
    public TMP_Text scoreText;
    public Rigidbody rb;
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
            rb.position = new Vector3(-10f, 1.478365f, -5f);
            rb.velocity = new Vector3(0,0,0);
            rb.rotation = Quaternion.identity;
        }
    }
}
