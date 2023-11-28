using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour

{
    public GameObject objectToKick;
    public float kickForce = 500f;
    public Animator RightKick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            doKick();
        }
    }

    void doKick()
    {
        if (objectToKick != null)
        {
            Rigidbody rb = objectToKick.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 kickDirection = (objectToKick.transform.position - transform.position).normalized;
                rb.AddForce(kickDirection * kickForce);
            }
            else
            {
                Debug.LogWarning("The object to kick doesn't have a Rigidbody component.");
            }
        }
        else
        {
            Debug.LogWarning("Object to kick is not assigned.");
        }

        // Trigger the kicking animation
        if (RightKick != null)
        {
            RightKick.SetTrigger("KickTrigger"); // Replace "KickTrigger" with the name of your animation trigger parameter
        }
        else
        {
            Debug.LogWarning("Leg Animator is not assigned.");
        }
    }
}
