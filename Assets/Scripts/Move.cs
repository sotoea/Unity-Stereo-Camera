using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public Camera right;
	public Camera left;
	float cameraTilt;

	// Use this for initialization
	void Start () {
		cameraTilt = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//GameObject.Find ("Cube").transform.position = transform.forward;
		transform.Translate (transform.forward * Input.GetAxis ("Vertical") * Time.deltaTime * 5, Space.World);
		transform.Translate (transform.right * Input.GetAxis ("Horizontal") * Time.deltaTime * 3, Space.World);
		transform.Rotate (new Vector3 (0, Input.GetAxis ("Mouse X") * Time.deltaTime * 120, 0));

		if (Input.GetAxis ("Mouse Y") != 0 && cameraTilt < 60 && cameraTilt > -60)
			cameraTilt += Input.GetAxis ("Mouse Y") * Time.deltaTime * 120;
		if (cameraTilt < -60)
			cameraTilt = -59.99f;
		if (cameraTilt > 60)
			cameraTilt = 59.99f;

		right.transform.localEulerAngles = new Vector3(-cameraTilt,0,0);
		left.transform.localEulerAngles = new Vector3(-cameraTilt,0,0);


	}
}
