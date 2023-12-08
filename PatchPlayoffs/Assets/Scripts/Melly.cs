using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melly : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed;
    private float maxMove;
    private Vector3 dir = Vector3.right;
    void Start()
    {
        speed = 1f;
        maxMove = .3f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        // transform.Translate(dir * speed * Time.deltaTime);
        
        // if (transform.position.x >= -85) {
        //     dir = Vector3.right;
        // } else if (transform.position.x <= -69) {
        //     dir = Vector3.left;
        // }
        float newX = Mathf.Sin(Time.time * speed);
        Debug.Log(newX);
        Vector3 move = new Vector3(maxMove * newX, 0f, 0f);
        
        transform.Translate(move);
        // transform.Translate(Vector3.right * newX);

        // transform.Translate(Vector3.right * newX);
    }
}
