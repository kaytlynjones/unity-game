using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkController : MonoBehaviour
{
    public Animator walkAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        walkAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!(Input.GetAxis("Vertical") == 0 )) {
            walkAnim.Play("walk4");
        }
    }
}
