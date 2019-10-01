using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    public float curHealth = 4;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            curHealth -= 1;
            if (curHealth == 0)
            {
                animm();
            }
        }
    }
    public void animm()
    {
        animator.SetTrigger("in");
    }
}
