using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeDestroyBullet : MonoBehaviour
{
    public float timeCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeToDisappear();
    }

    void TimeToDisappear()
    {
        if(timeCount > 0)
        {
            timeCount -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject,timeCount);
        }
    }
}
