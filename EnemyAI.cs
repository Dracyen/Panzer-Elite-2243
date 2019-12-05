using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    public Transform enemyTransform;

    public float speedEnemy = 4f;

    // Update is called once per frame
    void Update()
    {
        EnemyFollow();

    }

    void EnemyFollow()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * speedEnemy * Time.deltaTime);
    }
}
