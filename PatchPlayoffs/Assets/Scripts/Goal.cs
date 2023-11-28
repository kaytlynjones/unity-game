using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Goal : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int score;
    // Start is called before the first frame update
    void Awake() {
        scoreText = GetComponent<TextMeshProUGUI>();
        // Debug.Log(scoreText);
        score = 0;
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Ball")){
            
           
            score++;
            // scoreText = GetComponent<TextMeshProUGUI>();
            Debug.Log("Score" + score);
            Debug.Log(scoreText);
            scoreText.text = "Score: " + score;
           
        }
    }
}
