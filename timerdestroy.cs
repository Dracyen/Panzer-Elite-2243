using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerdestroy : MonoBehaviour
{
    public float timecount;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    { 
        TimeToExplode();   
    }

    void TimeToExplode()
    {
        if (timecount > 0)
        {
            timecount -= Time.deltaTime;
        }
        else
        {
            /*enabled = false;

            gameObject.AddComponent<Rigidbody>();*/
            Destroy(gameObject, timecount);
            
        }
    }
}
