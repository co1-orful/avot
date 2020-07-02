using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour {

	public float moveSpeed = 3f, jumpHeight = 10f;
	private bool inAir;

	new private Rigidbody2D rigidbody;
	private Animator animator;
	private SpriteRenderer sprite;

	void Awake () 
	{
		rigidbody = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		sprite = GetComponentInChildren<SpriteRenderer>();
	}

	void Update () {
		if(Input.GetButton("Jump") && !inAir)
			Jump();
		if (Input.GetButton("Horizontal")) 
			Run();
		}
		


	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
            inAir = false;
    }

   private void Jump()
   {
   	rigidbody.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
		inAir = true;
   }

   private void Run()
   {
   	Vector3 direction = transform.right * Input.GetAxis("Horizontal");

		transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, moveSpeed * Time.deltaTime);

		sprite.flipX = direction.x > 0.0f;
   }
}
