using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterScript : MonoBehaviour
{

    [SerializeField] int hp;
    [SerializeField] float squishMult;
    [SerializeField] AudioSource audioSource;
    //[SerializeField] AudioSource audioSource2;
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioClip audioClip2;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("dsdf");
        if (collision.tag == "Player")
        {
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        hp--;
        audioSource.PlayOneShot(audioClip);
        if (hp <= 0)
        {
            Destroy(gameObject);
            audioSource.PlayOneShot(audioClip2);
        }
        gameObject.transform.localScale = new Vector3(1,transform.localScale.y / squishMult, 1);
    }
}
