using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instantiateBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody instBulletRigidBody = instantiateBullet.GetComponent<Rigidbody>();
            instBulletRigidBody.AddForce(transform.forward * speed);
        }
    }
}
