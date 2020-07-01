using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour {

	public GameObject obj;
	public float range = 5f, moveSpeed = 3f, jumpHeight = 10f;

	void Update () {
		if(Input.GetKey(KeyCode.Space))
			obj.transform.Translate(Vector2.up * jumpHeight * Time.deltaTime);
		  
		if(Input.GetKey(KeyCode.LeftArrow))
			obj.transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

		if(Input.GetKey(KeyCode.RightArrow))
			obj.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
		}

}