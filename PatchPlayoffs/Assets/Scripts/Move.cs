using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float moveSpeed, rotateSpeed, move, rotation;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 7f;
        rotateSpeed = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.Translate(Vector3.right * move);
        transform.Rotate(0f, rotation, 0f);
    }
}
