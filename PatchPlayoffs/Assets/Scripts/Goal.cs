using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Goal : MonoBehaviour {
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
            if (score == 3) {
                SceneManager.LoadScene("WinScreen");
            }
            scoreText.text = "Score: " + score;
            rb.position = new Vector3(-51.88f, 5.43f, -104.64f);
            rb.velocity = new Vector3(0,0,0);
        }
    }
}