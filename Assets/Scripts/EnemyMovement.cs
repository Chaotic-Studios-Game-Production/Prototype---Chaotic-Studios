using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] int moveRange = 500;
    float movePixelX = 2f;
    int count = 0;
    bool flip = false;
    Rigidbody2D myRigidBody;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(flip.Equals(false))
        {
            myRigidBody.velocity = new Vector2(movePixelX, 0f);
            count++;
            if(count > moveRange)
            {
                flip = true;
                movePixelX = -2f;
            }
        } else {
            myRigidBody.velocity = new Vector2(movePixelX, 0f);
            count--;
            if (count < -moveRange)
            {
                flip = false;
                movePixelX = 2f;
            }
        }
    }
}
