using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform StartingPosition;
    
    void Update()
    {
        if (gameObject.transform.position.y < -15)
        {
            gameObject.transform.position = StartingPosition.position;
        }
    }
}
