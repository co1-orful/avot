using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour {

	public GameObject obj;
	public float range = 5f, moveSpeed = 3f, jumpHeight = 10f;
	private bool inAir;

	void Update () {
		if((Input.GetKey(KeyCode.Space) | Input.GetKey(KeyCode.W)) && !inAir){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
			inAir = true;
			}

		if(Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A))
			obj.transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
			obj.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

		}

	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
            inAir = false;
    }

}
