using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rigidyBody;

	public float forwardForce = 1000f;
	public float sidewaysForce = 500f;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {

		rigidyBody.AddForce (0, 0, forwardForce * Time.deltaTime);


		if (Input.GetKey ("d")) {
			rigidyBody.AddForce (sidewaysForce * Time.deltaTime, 0, 0);	
		} else if (Input.GetKey ("a")) {
			rigidyBody.AddForce (-sidewaysForce * Time.deltaTime, 0, 0);	
		}
	}
}
