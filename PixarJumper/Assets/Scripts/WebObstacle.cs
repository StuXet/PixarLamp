using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebObstacle : MonoBehaviour
{
    [SerializeField] float speedDebuff;
    float tempSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //tempSpeed = player speed
            //playerspeed = speedDebuff
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //player speed = tempSpeed
        }
    }
}
