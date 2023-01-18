using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    public float speed = 2f;
    public float platformWidth = 10f;
    private bool movingRight = true;

    void Update()
    {
        // Move the enemy horizontally
        transform.position += new Vector3(speed * Time.deltaTime * (movingRight ? 1 : -1), 0, 0);

        // Check if the enemy has reached the end of the platform
        float rightEdge = (platformWidth / 2) - (transform.localScale.x / 2);
        float leftEdge = -rightEdge;
        if (transform.position.x > rightEdge)
        {
            movingRight = false;
        }
        else if (transform.position.x < leftEdge)
        {
            movingRight = true;
        }
    }
}
