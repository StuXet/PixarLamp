using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform StartingPosition;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;

    void Update()
    {
        if (gameObject.transform.position.y < -15)
        {
            gameObject.transform.position = StartingPosition.position;
            audioSource.PlayOneShot(audioClip);
        }
    }
}
