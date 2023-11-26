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
        scoreText = GetComponent<TextMeshProUGUI>();
        score = 0;
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Ball")){
            //goal scored
           
            score++;
            // scoreText = GetComponent<TextMeshProUGUI>();
            Debug.Log("Score" + score);
            scoreText.text = "Score: ";
           
        }
    }
}
