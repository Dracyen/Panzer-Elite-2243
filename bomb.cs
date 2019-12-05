using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public GameObject Bomb;
    public GameObject Player;

    

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        dropBomb();
    }


    void dropBomb()
    {
        if (Input.GetKeyDown("b"))
        {
            Instantiate(Bomb, Player.transform.position, Quaternion.identity);

        }
    }

   
    
}
