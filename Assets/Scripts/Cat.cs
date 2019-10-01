using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour {

	public static Rigidbody2D rb;
    public float curHealth = 2;
    [SerializeField]
    private Animator animator;



    void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	public static void DoJump(float jumpForce)
	{
		rb.AddForce (Vector2.up * jumpForce);
	}
   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "D") {

            animator.SetTrigger("On");
        }
    }
    

}
