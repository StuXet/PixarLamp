using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterScript : MonoBehaviour
{

    [SerializeField] int hp;
    [SerializeField] float squishMult;

    
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
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        gameObject.transform.localScale = new Vector3(1,transform.localScale.y / squishMult, 1);
    }
}
